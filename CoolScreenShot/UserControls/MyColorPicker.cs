/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/7
 * Time: 22:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoolScreenShot.UserControls
{
	/// <summary>
	/// Description of MyColorPicker.
	/// </summary>
	public partial class MyColorPicker : UserControl
	{
		public delegate void PropertyValueChangeHandler(object sender, PropertyChangedEventArgs e);
		public event PropertyValueChangeHandler PropertyChanged;
		public Color? selectedColor = Color.Red;
		public int? selectedWidth = 1;
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyColorPicker));
		
		public MyColorPicker()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Color? SelectedColor { get{return this.selectedColor;} set{this.selectedColor = value;} }
		public int? PenWidth { get{return this.selectedWidth;} set{this.selectedWidth = value;} }
		
		
		void MyColorPickerLoad(object sender, EventArgs e)
		{
			Color[] colors = new Color[]{
				Color.FromArgb(0,0,0),
				Color.FromArgb(128,0,0),
				Color.FromArgb(128,128,128),
				Color.FromArgb(128,128,0),
				Color.FromArgb(128,0,128),
				Color.FromArgb(0,128,0),
				Color.FromArgb(0,0,128),
				Color.FromArgb(0,128,128),
				
				Color.FromArgb(255,255,255),
				Color.FromArgb(192,192,192),
				Color.FromArgb(255,0,0),
				Color.FromArgb(255,255,0),
				Color.FromArgb(255,0,255),
				Color.FromArgb(0,255,0),
				Color.FromArgb(0,0,255),
				Color.FromArgb(0,255,255)
			};
			
			foreach (Color c in colors) {
				this.flowLayoutPanel1.Controls.Add(createColorItemButtonByColor(c));
			}
			
			this.btn1.BackgroundImage = this.GetImage("1h");
			this.btn2.BackgroundImage = this.GetImage("2");
			this.btn3.BackgroundImage = this.GetImage("3");
		}
		
		ColorItemButton createColorItemButtonByColor(Color color){
			ColorItemButton btn = new ColorItemButton();
			btn.BackColor = color;
			btn.Click += ColorItemButtonClick;
			
			return btn;
		}
		
		void ColorItemButtonClick(object sender, EventArgs e){
			ColorItemButton btn = sender as ColorItemButton;
			if (sender != null) {
				if (this.selectedColor != btn.BackColor) {
					bigColorButton.BackColor = btn.BackColor;
					this.selectedColor = btn.BackColor;
					PropertyChangedEventArgs ee = new PropertyChangedEventArgs(this.selectedColor, this.selectedWidth);
					if (PropertyChanged != null) {
						PropertyChanged(btn, ee);
					}
				}
			}
		}
		
		
		
		void MouseHover(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (btn != null) {
				string index = btn.Name.Replace("btn", "");
				btn.BackgroundImage = this.GetImage(index+"h");
			}
			
		}
		
		void MouseLeave(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (btn != null) {
				string index = btn.Name.Replace("btn", "");
				if (int.Parse(index) != this.selectedWidth) {
					btn.BackgroundImage = this.GetImage(index);
				}
			}
		}
		
		void MouseClick(object sender, EventArgs e){
			Button btn = sender as Button;
			if (btn != null) {
				string index = btn.Name.Replace("btn", "");
				int w = int.Parse(index);
				if (w != this.selectedWidth) {
					this.selectedWidth = w;
					SwitchButton(this.selectedWidth);
					
					if (PropertyChanged != null) {
						PropertyChangedEventArgs ee = new PropertyChangedEventArgs(bigColorButton.BackColor, this.selectedWidth);
						PropertyChanged(this, ee);
					}
				}
			}
		}
		
		private void SwitchButton(int? selectIndex){
			this.btn1.BackgroundImage = this.GetImage(selectIndex == 1 ? "1h" : "1");
			this.btn2.BackgroundImage = this.GetImage(selectIndex == 2 ? "2h" : "2");
			this.btn3.BackgroundImage = this.GetImage(selectIndex == 3 ? "3h" : "3");
		}
		
		private Image GetImage(string key){
			return (Image)(resources.GetObject(key));
		}
		
	}
	
	public class PropertyChangedEventArgs: EventArgs{
		private Color? color;
		public Color? Color { 
			get{return this.color;} 
			set{this.color = value;}
		}
		
		private int? width;
		public int? Width { 
			get{return this.width;} 
			set{this.width = value;}
		}
		
		public PropertyChangedEventArgs(Color? color, int? width){
			this.color = color;
			this.width = width;
		}
	}
}
