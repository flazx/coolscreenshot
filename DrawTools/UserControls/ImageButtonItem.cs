/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/7
 * Time: 21:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using ImageButton1 = OOGroup.Windows.Forms.ImageButton;

namespace Demo
{
	public class ImageButtonItem: ToolStripControlHost
	{
	    private ImageButton1 imgButton;
	
	    public ImageButtonItem()
	        : base(new ImageButton1())
	    {
	        this.imgButton = this.Control as ImageButton1;
	    }
	
	    // Add properties, events etc. you want to expose...
	}
}
