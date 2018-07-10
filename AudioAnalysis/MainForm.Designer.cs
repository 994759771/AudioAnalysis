/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2018/7/3
 * Time: 10:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AudioAnalysis
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.TextBox tbOutPath;
		private System.Windows.Forms.Button btnOutPath;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.RichTextBox rtbLog;
		private System.Windows.Forms.Label lbLog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.RichTextBox rtbVideoList;
		private System.Windows.Forms.Label lbVideoList;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.tbOutPath = new System.Windows.Forms.TextBox();
			this.btnOutPath = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.rtbLog = new System.Windows.Forms.RichTextBox();
			this.lbLog = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.rtbVideoList = new System.Windows.Forms.RichTextBox();
			this.lbVideoList = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
			this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 0;
			this.btnOpenFile.Text = "打开文件夹";
			this.btnOpenFile.UseVisualStyleBackColor = false;
			this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFileClick);
			// 
			// tbOutPath
			// 
			this.tbOutPath.Location = new System.Drawing.Point(111, 14);
			this.tbOutPath.Name = "tbOutPath";
			this.tbOutPath.Size = new System.Drawing.Size(246, 21);
			this.tbOutPath.TabIndex = 1;
			// 
			// btnOutPath
			// 
			this.btnOutPath.Location = new System.Drawing.Point(382, 14);
			this.btnOutPath.Name = "btnOutPath";
			this.btnOutPath.Size = new System.Drawing.Size(75, 23);
			this.btnOutPath.TabIndex = 2;
			this.btnOutPath.Text = "输出位置";
			this.btnOutPath.UseVisualStyleBackColor = true;
			this.btnOutPath.Click += new System.EventHandler(this.BtnOutPathClick);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(486, 14);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "开始合并";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// rtbLog
			// 
			this.rtbLog.Location = new System.Drawing.Point(12, 74);
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.Size = new System.Drawing.Size(549, 323);
			this.rtbLog.TabIndex = 4;
			this.rtbLog.Text = "";
			// 
			// lbLog
			// 
			this.lbLog.Location = new System.Drawing.Point(12, 48);
			this.lbLog.Name = "lbLog";
			this.lbLog.Size = new System.Drawing.Size(100, 23);
			this.lbLog.TabIndex = 5;
			this.lbLog.Text = "日志";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.SelectedPath = "D:\\";
			// 
			// rtbVideoList
			// 
			this.rtbVideoList.Location = new System.Drawing.Point(580, 74);
			this.rtbVideoList.Name = "rtbVideoList";
			this.rtbVideoList.Size = new System.Drawing.Size(259, 323);
			this.rtbVideoList.TabIndex = 6;
			this.rtbVideoList.Text = "";
			// 
			// lbVideoList
			// 
			this.lbVideoList.Location = new System.Drawing.Point(580, 48);
			this.lbVideoList.Name = "lbVideoList";
			this.lbVideoList.Size = new System.Drawing.Size(100, 23);
			this.lbVideoList.TabIndex = 7;
			this.lbVideoList.Text = "视频列表";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.ClientSize = new System.Drawing.Size(851, 409);
			this.Controls.Add(this.lbVideoList);
			this.Controls.Add(this.rtbVideoList);
			this.Controls.Add(this.lbLog);
			this.Controls.Add(this.rtbLog);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.btnOutPath);
			this.Controls.Add(this.tbOutPath);
			this.Controls.Add(this.btnOpenFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(595, 342);
			this.Name = "MainForm";
			this.Text = "bilibili视频合并";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
