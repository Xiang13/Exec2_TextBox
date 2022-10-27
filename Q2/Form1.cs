using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Q2
{
	public partial class Form1 : Form
	{
		// Q2 輸入日期是否不大於今天

		public Form1()
		{
			InitializeComponent();
			dateLbl.Text = $"現在時間為 {DateTime.Now.ToString("yyyy 年 MM 月 dd 日")}";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string inputDate;
			DateTime date;
			DateTime today = DateTime.Now;
			Double resultDate;
			try
			{
				
				inputDate = dateTxtBox.Text;

				// 判斷格式是否正確
				date = GetDateTime(inputDate);

				// 輸出結果
				resultDate = GetDifferentDate(today, date);



				if (resultDate >= 0)
				{
					dateLbl.Text = date.ToString("輸入時間為 yyyy 年 MM 月 dd 日");
				}
				else
				{
					dateLbl.Text = $"{date.ToString("yyyy 年 MM 月 dd 日")} 大於今天";
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
	
		private DateTime GetDateTime(string inputDate)
		{
			int length = inputDate.Length;
			if (length == 10)
			{
				bool isDate = DateTime.TryParse(inputDate, out DateTime date);
				var result = isDate ? date : throw new Exception("必須符合日期的格式(yyyy/mm/dd)");
				return date;
			}
			else
			{
				throw new Exception("必須符合日期的格式(yyyy/mm/dd)");
			}
			
		}
		private Double GetDifferentDate(DateTime today, DateTime date)
		{
			TimeSpan dateResult = today - date;
			double resultDate = dateResult.TotalDays;
			return resultDate;
		}
	}
}
