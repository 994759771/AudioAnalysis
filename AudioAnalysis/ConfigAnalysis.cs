/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/7/3
 * Time: 11:19
 * 配置文件解析
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using AudioAnalysis.Mode;
using System.Text;

namespace AudioAnalysis
{
	/// <summary>
	/// Description of ConfigAnalysis.
	/// </summary>
	public class ConfigAnalysis
	{
		public List<VideoInfo> GetVideoInfo(string VideoRootPath){
			
			List<VideoInfo> VideoInfoList=new List<VideoInfo>();
			JsonAnalysis jal=new JsonAnalysis();
			ModeEntry me=null;
			
			if (VideoRootPath!=null) {
				string[] path=Directory.GetDirectories(VideoRootPath);			   
			    for (int i = 0; i < path.Length; i++) {
				VideoInfo temp=new VideoInfo();
				temp.videoPath=path[i]+@"\lua.flv.bili2api.80";
				me=jal.GetJsonConfig(path[i]);
				temp.videoName=me.page_data.part;
				VideoInfoList.Add(temp);
			    }
			  
			
			}else{
				MessageBox.Show("视频路径为空，请先选择","提示");
			}
		
			return VideoInfoList;
		}
		public void WriteList(List<VideoInfo> videoInfo){
		     try {
				String sb="";
				StreamWriter sw=null;
				for (int i = 0; i < videoInfo.Count; i++) {
					sw=new StreamWriter(videoInfo[i].videoPath+@"\List.txt",true);
					string[] temp=Directory.GetFiles(videoInfo[i].videoPath,"*.blv");
					for (int j = 0; j < temp.Length; j++) {
						sb="file '"+temp[j].ToString()+" '\n";
					    sw.WriteLine(sb);
					}
				
					sw.Close();
					
				}
				
				
		     } 
			catch (Exception ex) {
		     	
				MessageBox.Show(ex.Message);
		     }
		
		}
	
	}
}
