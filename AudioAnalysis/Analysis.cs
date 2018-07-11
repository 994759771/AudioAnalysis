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
		
	
	    
		public string OutLOgTXT="";
		public void Run(List<VideoInfo> info ,string svaePath){
			
			for (int i = 0; i < info.Count; i++) {
		    Process p=new Process();
			p.StartInfo.FileName="ffmpeg.exe";
			string a=info[i].videoName;
			a+=".flv";
			a=a.Replace(" ","");
			string strCmd="ffmpeg  -f  concat -safe 0 -i  "+info[i].videoPath+"\\List.txt"+"  -c:v h264 -c:a mp3 films.flv";
			strCmd=strCmd.TrimEnd();
			p.StartInfo.Arguments=strCmd;
			p.StartInfo.UseShellExecute=false;
			p.StartInfo.RedirectStandardError=true;
			p.StartInfo.CreateNoWindow=true;
			p.ErrorDataReceived+= new DataReceivedEventHandler(Output);
			p.Start();
			p.BeginErrorReadLine();
			 
			p.WaitForExit();
			p.Close();
			
			}
			
			
			
		}
		 private void Output(object sendProcess, DataReceivedEventArgs output){
            if (!String.IsNullOrEmpty(output.Data))
            {
            	
            	OutLOgTXT+=output.Data.ToString();
            	//bb(output.Data.ToString());
            	//MainForm.rtb.AppendText(output.Data.ToString());
            }
        }
	}
}
