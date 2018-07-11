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
using System.Collections;
using AudioAnalysis;

namespace AudioAnalysis
{
	/// <summary>
	/// Description of ConfigAnalysis.
	/// </summary>
	/// 
	public class ReverseComparer :IComparer{
	        int IComparer.Compare( Object x, Object y )
       {
           if(x==null||y==null)
              throw new ArgumentException("Parameters can't be null");
           string fileA = x as string;
           string fileB = y as string;
           char[] arr1   =   fileA.ToCharArray();
           char[] arr2 = fileB.ToCharArray();
           int i = 0, j =0;
           while( i < arr1.Length && j < arr2.Length)
           {
              if ( char.IsDigit( arr1[i]) && char.IsDigit( arr2[j] ) )
              {
                  string s1 = "",s2 = "";
                  while ( i < arr1.Length && char.IsDigit( arr1[i]) )
                  {
                     s1 += arr1[i];
                     i++;
                  }
                  while (j < arr2.Length && char.IsDigit( arr2[j] ))
                  {
                     s2 += arr2[j];
                     j++;
                  }
                  if ( int.Parse( s1 ) > int.Parse( s2) )
                  {
                     return 1;
                  }
                  if ( int.Parse( s1 ) < int.Parse( s2) )
                  {
                     return -1;
                  }
              }
              else
              {
                  if ( arr1[i] > arr2[j] )
                  {
                     return 1;
                  }
                  if ( arr1[i] < arr2[j] )
                  {
                     return -1;
                  }
                  i++;
                  j++;
              }
           }
           if ( arr1.Length == arr2.Length )
           {
              return 0;
           }
           else
           {
              return arr1.Length > arr2.Length? 1: -1;
           }
           //            return string.Compare( fileA, fileB );
           //            return( (new CaseInsensitiveComparer()).Compare( y, x ) );
       }
	
	}
	public class ConfigAnalysis
	{
		public   event Action<List<VideoInfo>> log;
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
		    log(VideoInfoList);
			return VideoInfoList;
		}
		public void WriteList(List<VideoInfo> videoInfo){
		     try {
				String sb="";
				StreamWriter sw=null;
				for (int i = 0; i < videoInfo.Count; i++) {
					sw=new StreamWriter(videoInfo[i].videoPath+@"\List.txt");
					string[] temp=Directory.GetFiles(videoInfo[i].videoPath,"*.flv");
					IComparer revComparer = new ReverseComparer();
					Array.Sort(temp,revComparer);
					for (int j = 0; j < temp.Length; j++) {
						sb="file '"+temp[j].ToString()+"'\n";
					    sw.WriteLine(sb);
					}
				
					sw.Close();
					sw.Dispose();
					
				}
				
				
		     } 
			catch (Exception ex) {
		     	
				MessageBox.Show(ex.Message);
		     }
		
		}
	
	}
}
