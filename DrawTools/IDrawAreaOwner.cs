/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 11:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
namespace DrawTools
{
	/// <summary>
	/// Description of IDrawAreaOwner.
	/// </summary>
	public interface IDrawAreaOwner
	{
		void SetStateOfControls();
		ToolStripMenuItem ContextParent{ get; }
		Form getForm();
	}
}
