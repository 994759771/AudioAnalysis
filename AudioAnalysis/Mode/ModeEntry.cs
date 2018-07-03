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
		public long total_bytes;
		public long downloade_bytes;
		public string title;
		public string type_tag;
		public string cover;
		public long prefered_video_quality;
		public long guessed_total_bytes;
		public long total_time_milli;
		public long danmaku_count;
		public long time_update_stamp;
		public long time_create_stamp;
		public long avid;
		public long spid;
		public long seasion_id;
		public ModePage_data page_data;
	}
}
