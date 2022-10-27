using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		/*
		 * Q4 計算入場費用
		 * 入場費用計算規則:每一個團體要進入園區時,可以用比較便宜的團體,限制是只能採取以下兩種裡的一種, 不能拆分成兩個團體
		 * 按車輛計費: 每部車收 200 元, 不管裡面坐多少乘客
		 * 按人頭計費: 每人收 60 元, 無論多少部車 
		 */
		public Form1()
		{
			InitializeComponent();
		}

		private void calcBtn_Click(object sender, EventArgs e)
		{
			try
			{
				// 得到人數
				int people = GetPeople();

				// 得到車數
				int car = GetCar();

				// 相加
				int vaule = GetAdd(people, car);

				// 輸出結果
				string msg = vaule.ToString();
				resultLbl.Text = $"{msg} 元";
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int GetAdd(int people, int car)
		{
			int peoplePrice = 60;
			int carPrice = 200;
			int result;
			result = people * peoplePrice + car * carPrice;
			return result;
		}

		private int GetCar()
		{
			TextBox txt = carTxtBox;
			string value = txt.Text;
			bool isInt = int.TryParse(value, out int number);
			number = isInt ? number : throw new Exception($"必須填寫數值");
			int isNum = number > 0 ? number : throw new Exception($"必須大於零");

			return isNum;
		}

		private int GetPeople()
		{
			TextBox txt = peopleTxtBox;
			string value = txt.Text;
			bool isInt = int.TryParse(value, out int number);
			number = isInt ? number : throw new Exception($"必須填寫數值");
			int isNum = number > 0 ? number : throw new Exception($"必須大於零");
			return isNum;
		}
	}
}
