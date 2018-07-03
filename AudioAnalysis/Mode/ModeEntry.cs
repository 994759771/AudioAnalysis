/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/7/3
 * Time: 16:04
 * entry.json文件模型
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AudioAnalysis.Mode
{
	/// <summary>
	/// Description of ModeEntry.
	/// </summary>
	public class ModeEntry
	{
		public bool is_completed;
		public int total_bytes;
		public int downloade_bytes;
		public string title;
		public string type_tag;
		public string cover;
		public int prefered_video_quality;
		public int guessed_total_bytes;
		public int total_time_milli;
		public int danmaku_count;
		public int time_update_stamp;
		public int time_create_stamp;
		public int avid;
		public int spid;
		public int seasion_id;
		public ModePage_data page_data;
	}
}
