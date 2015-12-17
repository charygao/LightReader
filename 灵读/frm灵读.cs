using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 灵读
{
    public partial class frm灵读 : Form
    {
       private TimeSpan tms启动时间 = new TimeSpan(0);
        private TimeSpan tms一秒 = new TimeSpan(10000000);
       public frm灵读()
        {
            InitializeComponent();
            tim计时器.Start();
            lab时间.Text = "当前时间:" + string.Format("{0:T}", DateTime.Now) + "," + DateTime.Now.GetDateTimeFormats('D')[1] + ",第" + GetWeekOfYear() + "周" + ",第" + DateTime.Today.DayOfYear + "天";
            lab阅读时长.Text = "阅读时长:" + tms启动时间;
            rtb文本框.DragEnter += new DragEventHandler(rtb文本框_DragEnter);
            rtb文本框.DragDrop += new DragEventHandler(rtb文本框_DragDrop);
        }

        private void rtb文本框_DragDrop(object sender, DragEventArgs e)
        {
            Array arrayFileName = (Array)e.Data.GetData(DataFormats.FileDrop);

            string strFileName = arrayFileName.GetValue(0).ToString();
            
            StreamReader sr = new StreamReader(strFileName, TxtFileEncoder.GetEncoding(strFileName));
            rtb文本框.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void rtb文本框_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private static int GetWeekOfYear()
        {
            int firstWeekend = 7 - Convert.ToInt32(DateTime.Parse(DateTime.Today.Year + "-1-1").DayOfWeek);//一.找到第一周的最后一天（先获取1月1日是星期几，从而得知第一周周末是几）
            int currentDay = DateTime.Today.DayOfYear;//二.获取今天是一年当中的第几天
            return Convert.ToInt32(Math.Ceiling((currentDay - firstWeekend) / 7.0)) + 1;//三.（今天 减去 第一周周末）/7 等于 距第一周有多少周 再加上第一周的1 就是今天是今年的第几周了刚好考虑了惟一的特殊情况就是，今天刚好在第一周内，那么距第一周就是0 再加上第一周的1 最后还是1
        }
        private void 全屏化()
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            HighLightText();
        }
        private void 小窗口化()
        {
            this.TopMost = false;
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
        private void lkl全屏否_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (this.FormBorderStyle)
            {
                case FormBorderStyle.None:
                    小窗口化(); break;
                case FormBorderStyle.FixedSingle:
                    全屏化(); break;
                case FormBorderStyle.Fixed3D:
                    全屏化(); break;
                case FormBorderStyle.FixedDialog:
                    全屏化(); break;
                case FormBorderStyle.Sizable:
                    全屏化(); break;
                case FormBorderStyle.FixedToolWindow:
                    全屏化(); break;
                case FormBorderStyle.SizableToolWindow:
                    全屏化(); break;
                default:
                    全屏化(); break;
            }
        }

        private void tim计时器_Tick(object sender, EventArgs e)
        {
            lab时间.Text = "当前时间:" + string.Format("{0:T}", DateTime.Now) + "," + DateTime.Now.GetDateTimeFormats('D')[1] + ",第" + GetWeekOfYear() + "周"+",第"+ DateTime.Today.DayOfYear + "天";
            tms启动时间 = tms启动时间 + tms一秒;
            lab阅读时长.Text = "阅读时长:" + tms启动时间;
        }
        private void HighLightText()
        {	
			string[] 动词 = { "有", "是", "你", "的", "我", "by", "group", "null" };
            string[] 名词 = { "isnull", "count", "sum" };
            string[] 标点 = { @"'((.|\n)*?)'" };
			
            string[] keywords = { "有", "是", "你", "的", "我", "by", "group", "null" };
            string[] functions = { "isnull", "count", "sum" };
            string[] strings = { @"'((.|\n)*?)'" };
            string[] whiteSpace = { "\t", "\n", "   " };

            rtb文本框.SelectAll();
            rtb文本框.SelectionColor = Color.White;
            HighLightText(keywords, Color.Red);//FromArgb(100,100,0));//Magenta
            HighLightText(functions, Color.Red);
            HighLightText(strings, Color.Gray);
            HighLightText(whiteSpace, Color.Black);
        }
        private void HighLightText(string[] wordList, Color color)
        {
            foreach (string word in wordList)
            {
                Regex r = new Regex(word, RegexOptions.IgnoreCase);

                foreach (Match m in r.Matches(rtb文本框.Text))
                {
                    rtb文本框.Select(m.Index, m.Length);
                    rtb文本框.SelectionColor = color;
                }
            }
        }
    }
}
