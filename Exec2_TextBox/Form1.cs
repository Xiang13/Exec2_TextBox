using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox
{
	public partial class Form1 : Form
	{

		// Q1 輸入數值是否在[1,99]
		public Form1()
		{
			InitializeComponent();
			resultLbl.Text = string.Empty;
			this.MaximizeBox = false;
		}

		private void confirmBtn_Click(object sender, EventArgs e)
		{

			int num;
			string value = numTxtBox.Text;
			string result;
			try
			{
				// 判斷是否為數值
				num = GetNumber(value);

				// 得到結果
				result = Getresult(num);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			//try
			//{
			//	var result = isInt ? number : throw new Exception($"{input}必須填寫數值");

			//	if (number > 0 && number < 100)
			//	{
			//		resultLbl.Text = $"數字 {number} 在 0 ~ 99 範圍內";
			//	}
			//	else
			//	{
			//		resultLbl.Text = $"數字 {number} 不在 0 ~ 99 範圍內";
			//	}
			//}
			//catch(Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//	return;
			//}
		}

		private int GetNumber(string value)
		{
			bool isInt = int.TryParse(value, out int number);
			return isInt ? number : throw new Exception($"{value} 不是數值");
		}

		private string Getresult(int number)
		{
			if (number > 0 && number < 100)
			{
				resultLbl.Text = $"數值 {number} 在 0 ~ 99 範圍內";
			}
			else
			{
				resultLbl.Text = $"數值 {number} 不在 0 ~ 99 範圍內";
			}
			return resultLbl.Text;
		}
	}
}

