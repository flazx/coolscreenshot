/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 20:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Demo
{
	

	
	/// <summary>
	/// Description of AlwaysOnTopForm.
	/// </summary>
	public partial class AlwaysOnTopForm : Form
	{
		[Flags()]
public enum SetWindowPosFlags : uint
{
    /// <summary>If the calling thread and the thread that owns the window are attached to different input queues, 
    /// the system posts the request to the thread that owns the window. This prevents the calling thread from 
    /// blocking its execution while other threads process the request.</summary>
    /// <remarks>SWP_ASYNCWINDOWPOS</remarks>
    SynchronousWindowPosition = 0x4000,
    /// <summary>Prevents generation of the WM_SYNCPAINT message.</summary>
    /// <remarks>SWP_DEFERERASE</remarks>
    DeferErase = 0x2000,
    /// <summary>Draws a frame (defined in the window's class description) around the window.</summary>
    /// <remarks>SWP_DRAWFRAME</remarks>
    DrawFrame = 0x0020,
    /// <summary>Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to 
    /// the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE 
    /// is sent only when the window's size is being changed.</summary>
    /// <remarks>SWP_FRAMECHANGED</remarks>
    FrameChanged = 0x0020,
    /// <summary>Hides the window.</summary>
    /// <remarks>SWP_HIDEWINDOW</remarks>
    HideWindow = 0x0080,
    /// <summary>Does not activate the window. If this flag is not set, the window is activated and moved to the 
    /// top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter 
    /// parameter).</summary>
    /// <remarks>SWP_NOACTIVATE</remarks>
    DoNotActivate = 0x0010,
    /// <summary>Discards the entire contents of the client area. If this flag is not specified, the valid 
    /// contents of the client area are saved and copied back into the client area after the window is sized or 
    /// repositioned.</summary>
    /// <remarks>SWP_NOCOPYBITS</remarks>
    DoNotCopyBits = 0x0100,
    /// <summary>Retains the current position (ignores X and Y parameters).</summary>
    /// <remarks>SWP_NOMOVE</remarks>
    IgnoreMove = 0x0002,
    /// <summary>Does not change the owner window's position in the Z order.</summary>
    /// <remarks>SWP_NOOWNERZORDER</remarks>
    DoNotChangeOwnerZOrder = 0x0200,
    /// <summary>Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to 
    /// the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent 
    /// window uncovered as a result of the window being moved. When this flag is set, the application must 
    /// explicitly invalidate or redraw any parts of the window and parent window that need redrawing.</summary>
    /// <remarks>SWP_NOREDRAW</remarks>
    DoNotRedraw = 0x0008,
    /// <summary>Same as the SWP_NOOWNERZORDER flag.</summary>
    /// <remarks>SWP_NOREPOSITION</remarks>
    DoNotReposition = 0x0200,
    /// <summary>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</summary>
    /// <remarks>SWP_NOSENDCHANGING</remarks>
    DoNotSendChangingEvent = 0x0400,
    /// <summary>Retains the current size (ignores the cx and cy parameters).</summary>
    /// <remarks>SWP_NOSIZE</remarks>
    IgnoreResize = 0x0001,
    /// <summary>Retains the current Z order (ignores the hWndInsertAfter parameter).</summary>
    /// <remarks>SWP_NOZORDER</remarks>
    IgnoreZOrder = 0x0004,
    /// <summary>Displays the window.</summary>
    /// <remarks>SWP_SHOWWINDOW</remarks>
    ShowWindow = 0x0040,
}

static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
static readonly IntPtr HWND_TOP = new IntPtr(0);
static readonly IntPtr HWND_BOTTOM = new IntPtr(1);

/// <summary>
/// Window handles (HWND) used for hWndInsertAfter
/// </summary>
public static class HWND
{
   public static IntPtr
   NoTopMost = new IntPtr(-2),
   TopMost = new IntPtr(-1),
   Top = new IntPtr(0),
   Bottom = new IntPtr(1);
}

/// <summary>
/// SetWindowPos Flags
/// </summary>
public static class SWP
{
   public static readonly int
   NOSIZE = 0x0001,
   NOMOVE = 0x0002,
   NOZORDER = 0x0004,
   NOREDRAW = 0x0008,
   NOACTIVATE = 0x0010,
   DRAWFRAME = 0x0020,
   FRAMECHANGED = 0x0020,
   SHOWWINDOW = 0x0040,
   HIDEWINDOW = 0x0080,
   NOCOPYBITS = 0x0100,
   NOOWNERZORDER = 0x0200,
   NOREPOSITION = 0x0200,
   NOSENDCHANGING = 0x0400,
   DEFERERASE = 0x2000,
   ASYNCWINDOWPOS = 0x4000;
}

		
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);
		
		[DllImport("user32.dll")]
		public static extern IntPtr GetActiveWindow();
		
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(HandleRef hwnd, out RECT lpRect);
		
		[StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }
			
			
		public AlwaysOnTopForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void AlwaysOnTopFormLoad(object sender, EventArgs e)
		{
			this.Focus();
			
			MoveWindowToMonitor(0);
		}
		
		 public void MoveWindowToMonitor(int monitor)
	    {
	        var windowHandler = AlwaysOnTopForm.GetActiveWindow();
	
	        //var windowRec = AlwaysOnTopForm.GetWindowRect(windowHandler);
	        // When I move a window to a different monitor it subtracts 16 from the Width and 38 from the Height, Not sure if this is on my system or others.
	        SetWindowPos(windowHandler, HWND_TOP, Screen.AllScreens[monitor].WorkingArea.Left,
	             Screen.AllScreens[monitor].WorkingArea.Top, this.ClientRectangle.Width + 16, this.ClientRectangle.Height + 38,
	             SetWindowPosFlags.ShowWindow);
	    }
	}
}
