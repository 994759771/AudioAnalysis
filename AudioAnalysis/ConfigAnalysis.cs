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

namespace AudioAnalysis
{
	/// <summary>
	/// Description of ConfigAnalysis.
	/// </summary>
	public class ConfigAnalysis
	{
		public List<VideoInfo> GetVideoInfo(string VideoRootPath){
			string[] path=Directory.GetDirectories(VideoRootPath);
			List<VideoInfo> VideoInfoList=new List<VideoInfo>();
			for (int i = 0; i < path.Length; i++) {
				VideoInfo temp=new VideoInfo();
				temp.videoPath=path[i]+@"\lua.flv.bili2api.80";
				VideoInfoList.Add(temp);
			}
		
			return VideoInfoList;
		}
		void WriteList(){
		
		}
		
	}
}
