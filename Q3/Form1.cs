using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Q3
{
	public partial class Form1 : Form
	{
		// Q3 經由輸入生日判斷是否已滿 13 歲
		public Form1()
		{
			InitializeComponent();
		}

		private void checkBtn_Click(object sender, EventArgs e)
		{
			DateTime today = DateTime.Now;


			try
			{
				// 判斷格式是否正確
				DateTime date = GetDateTime(dateTxtBox);
				DateTime dt = GetFuture(today, date);

				// 輸出結果
				dateLbl.Text = GetDateCondition(today, date);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
		private DateTime GetDateTime(TextBox control)
		{
			string value = control.Text;
			if (value.Length == 10)
			{
				bool isDateTime = DateTime.TryParse(value, out DateTime date);
				return isDateTime ? date : throw new Exception("必須符合格式(yyyy/mm/dd)");
			}
			else
			{
				throw new Exception("必須符合格式(yyyy/mm/dd)");
			}

		}
		private string GetDateCondition(DateTime today, DateTime date)
		{
			int year = today.Year;
			int inputYear = date.Year;

			string msg = string.Empty;

			if (year - inputYear >= 13)
			{
				msg = "已滿 13 歲";
				return msg;
			}
			else
			{
				msg = "未滿 13 歲";
				return msg;
			}
		}

		private DateTime GetFuture(DateTime today, DateTime date)
		{
			
			TimeSpan dateResult = today - date;
			double resultDate = dateResult.TotalDays;
			if(resultDate < 0)
			{
				throw new Exception("不可大於今天");
			}
			return date;
		}
	}
}
