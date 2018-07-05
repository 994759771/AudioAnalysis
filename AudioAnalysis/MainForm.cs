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
using System.Collections;
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
		List<VideoInfo> v;
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
			
			CA.log+= new Action<List<VideoInfo>>(ReFresh1);
			v= CA.GetVideoInfo(pa.videoRootPath);
		}
		void BtnStartClick(object sender, EventArgs e)
		{
			
			
			CA.WriteList(v);
			MessageBox.Show("解析成功");
		}
		public void ReFresh1(List<VideoInfo> info){
		 for (int i = 0; i < info.Count; i++) {
				this.rtbVideoList.AppendText(info[i].videoName+"\n");
		 }
		
		}
	}
}
