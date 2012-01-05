/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 20:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
partial class Form2 : Form
{
    public Form2()
    {
        // Create a new ToolStrip control.
        ToolStrip ts = new ToolStrip();

        // Populate the ToolStrip control.
        ts.Items.Add("Apples");
        ts.Items.Add("Oranges");
        ts.Items.Add("Pears");
        ts.Items.Add(
            "Change Colors", 
            null, 
            new EventHandler(ChangeColors_Click));

        // Create a new MenuStrip.
        MenuStrip ms = new MenuStrip();

        // Dock the MenuStrip control to the top of the form.
        ms.Dock = DockStyle.Top;

        // Add the top-level menu items.
        ms.Items.Add("File");
        ms.Items.Add("Edit");
        ms.Items.Add("View");
        ms.Items.Add("Window");

        // Add the ToolStrip to Controls collection.
        this.Controls.Add(ts);

        // Add the MenuStrip control last.
        // This is important for correct placement in the z-order.
        this.Controls.Add(ms);
    }

    // This event handler is invoked when the "Change colors"
    // ToolStripItem is clicked. It assigns the Renderer
    // property for the ToolStrip control.
    void ChangeColors_Click(object sender, EventArgs e)
    {
        ToolStripManager.Renderer = 
            new ToolStripProfessionalRenderer(new CustomProfessionalColors());
    }
}

// This class defines the gradient colors for 
// the MenuStrip and the ToolStrip.
class CustomProfessionalColors : ProfessionalColorTable
{
    public override Color ToolStripGradientBegin
    { get { return Color.BlueViolet; } }

    public override Color ToolStripGradientMiddle
    { get { return Color.CadetBlue; } }

    public override Color ToolStripGradientEnd
    { get { return Color.CornflowerBlue; } }

    public override Color MenuStripGradientBegin
    { get { return Color.Salmon; } }

    public override Color MenuStripGradientEnd
    { get { return Color.OrangeRed; } }
}
}
