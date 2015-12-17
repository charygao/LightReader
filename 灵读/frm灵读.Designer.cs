using System;
using System.Windows.Forms;

namespace 灵读
{
    partial class frm灵读
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtb文本框 = new System.Windows.Forms.RichTextBox();
            this.pan容器 = new System.Windows.Forms.Panel();
            this.lab阅读时长 = new System.Windows.Forms.Label();
            this.lab时间 = new System.Windows.Forms.Label();
            this.lkl全屏否 = new System.Windows.Forms.LinkLabel();
            this.tim计时器 = new System.Windows.Forms.Timer(this.components);
            this.pan容器.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb文本框
            // 
            this.rtb文本框.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb文本框.BackColor = System.Drawing.Color.Black;
            this.rtb文本框.EnableAutoDragDrop = true;
            this.rtb文本框.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb文本框.ForeColor = System.Drawing.Color.White;
            this.rtb文本框.Location = new System.Drawing.Point(0, 36);
            this.rtb文本框.Name = "rtb文本框";
            this.rtb文本框.Size = new System.Drawing.Size(800, 600);
            this.rtb文本框.TabIndex = 0;
            this.rtb文本框.Text = "直接拖入文本即可\n可以做编辑器使用,但不建议\n的\n有\n是";
            // 
            // pan容器
            // 
            this.pan容器.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan容器.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan容器.Controls.Add(this.lab阅读时长);
            this.pan容器.Controls.Add(this.lab时间);
            this.pan容器.Controls.Add(this.lkl全屏否);
            this.pan容器.Location = new System.Drawing.Point(0, 0);
            this.pan容器.Name = "pan容器";
            this.pan容器.Size = new System.Drawing.Size(802, 30);
            this.pan容器.TabIndex = 1;
            // 
            // lab阅读时长
            // 
            this.lab阅读时长.AutoSize = true;
            this.lab阅读时长.Location = new System.Drawing.Point(584, 7);
            this.lab阅读时长.Name = "lab阅读时长";
            this.lab阅读时长.Size = new System.Drawing.Size(59, 12);
            this.lab阅读时长.TabIndex = 5;
            this.lab阅读时长.Text = "阅读时长:";
            // 
            // lab时间
            // 
            this.lab时间.AutoSize = true;
            this.lab时间.Location = new System.Drawing.Point(10, 7);
            this.lab时间.Name = "lab时间";
            this.lab时间.Size = new System.Drawing.Size(59, 12);
            this.lab时间.TabIndex = 4;
            this.lab时间.Text = "当前时间:";
            // 
            // lkl全屏否
            // 
            this.lkl全屏否.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lkl全屏否.AutoSize = true;
            this.lkl全屏否.Location = new System.Drawing.Point(742, 7);
            this.lkl全屏否.Name = "lkl全屏否";
            this.lkl全屏否.Size = new System.Drawing.Size(53, 12);
            this.lkl全屏否.TabIndex = 3;
            this.lkl全屏否.TabStop = true;
            this.lkl全屏否.Text = "开始阅读";
            this.lkl全屏否.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl全屏否_LinkClicked);
            // 
            // tim计时器
            // 
            this.tim计时器.Enabled = true;
            this.tim计时器.Interval = 1000;
            this.tim计时器.Tick += new System.EventHandler(this.tim计时器_Tick);
            // 
            // frm灵读
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 616);
            this.Controls.Add(this.pan容器);
            this.Controls.Add(this.rtb文本框);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm灵读";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "灵读";
            this.pan容器.ResumeLayout(false);
            this.pan容器.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.RichTextBox rtb文本框;
        private System.Windows.Forms.Panel pan容器;
        private System.Windows.Forms.Label lab阅读时长;
        private System.Windows.Forms.Label lab时间;
        private System.Windows.Forms.LinkLabel lkl全屏否;
        private System.Windows.Forms.Timer tim计时器;

    }
}

