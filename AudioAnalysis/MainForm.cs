/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/7/3
 * Time: 10:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AudioAnalysis
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		PathAnalysis pa=new PathAnalysis();
		ConfigAnalysis CA=new ConfigAnalysis();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	

			void BtnOutPathClick(object sender, EventArgs e)
		{
			pa.SetSavePath();
			this.tbOutPath.Text=pa.videoSavePath;
		}
		void BtnOpenFileClick(object sender, EventArgs e)
		{
			pa.GetPath();
		}
		void BtnStartClick(object sender, EventArgs e)
		{
			List<VideoInfo> v= CA.GetVideoInfo(pa.videoRootPath);
		}
		
	}
}
