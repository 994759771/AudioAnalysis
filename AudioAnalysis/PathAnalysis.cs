/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/7/3
 * Time: 11:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace AudioAnalysis
{
	/// <summary>
	/// 路径解析类
	/// </summary>
	public   class PathAnalysis
	{
		public   string videoRootPath{get;set;}
		public   string videoSavePath{get;set;}
	   	
		FolderBrowserDialog FBD=new FolderBrowserDialog();
		
		public  void GetPath(){
			
			if (FBD.ShowDialog()==DialogResult.OK) {
				videoRootPath=FBD.SelectedPath;
			}
			
			
		}
		
		
		public   void SetSavePath(){
			if (FBD.ShowDialog()==DialogResult.OK) {
				videoSavePath=FBD.SelectedPath;
			}
			
		}
		
		public PathAnalysis(){
			FBD.Description="请选择文件夹路径";
			FBD.ShowNewFolderButton=false;
		
			
		}
	}
}
