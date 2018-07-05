/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/7/3
 * Time: 11:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Collections.Generic;
namespace AudioAnalysis
{
	/// <summary>
	/// Description of Analysis.
	/// </summary>
	public class Analysis
	{
		
	
		
		public void Run(List<VideoInfo> info ,string svaePath){
			/*Process p=new Process();
			p.StartInfo.FileName="ffmpeg.exe";
			string strCmd="ffmpeg -f concat -i "+info.videoPath+"\\List.txt"+" -c copy "+svaePath+"\\"+info.videoName;
			p.StartInfo.Arguments=strCmd;
			p.StartInfo.UseShellExecute=false;
			p.StartInfo.RedirectStandardError=true;
			p.StartInfo.CreateNoWindow=true;
			p.ErrorDataReceived+= new DataReceivedEventHandler(Output);
			p.Start();
			p.BeginErrorReadLine();
			p.WaitForExit();
			p.Close();
			*/
		}
		 private void Output(object sendProcess, DataReceivedEventArgs output){
            if (!String.IsNullOrEmpty(output.Data))
            {
            	
            	
            }
        }
	}
}
