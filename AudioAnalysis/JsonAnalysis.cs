/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/7/3
 * Time: 16:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AudioAnalysis.Mode;
using LitJson;
using System.IO;
using System.Windows.Forms;

namespace AudioAnalysis
{
	/// <summary>
	///Json解析
	/// </summary>
	public class JsonAnalysis
	{
		public ModeEntry GetJsonConfig(string videoPath){
			ModeEntry me=new ModeEntry();
			try {
				string entryPath=videoPath+@"\entry.json";
			    string js=File.ReadAllText(entryPath);
			    me=JsonMapper.ToObject<ModeEntry>(js);
			} catch (Exception ex) {
				
				MessageBox.Show(ex.Message);
			}
			
			
		
			return me;
		}
		
	}
}
