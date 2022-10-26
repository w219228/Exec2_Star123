using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			string stars = GenerateStar(rows);
			DisplayStars(stars);

		}
		private void generateRightButton_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string stars = GenerateRightStar(rows);
			DisplayStars(stars);
		}

		private void isoscelesButton_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string stars = GenerateisoscelesStar(rows);
			DisplayStars(stars);
		}

		private void DisplayStars(string stars)
		{
			resultTextBox.Text = stars;
		}

		private string GenerateStar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}

		private string GenerateRightStar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', (rows -i)*2) + new string('*',  i)+"\r\n";
			}
			return result;
		}

		private string GenerateisoscelesStar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', rows - i ) + new string('*', i) + new string(' ', rows - i)+"\r\n";
			}
			return result;
		}

		private int GetRows()
		{
			string input = rowsTextBox.Text;
			bool isInt = int.TryParse(input, out int rows);
			if (isInt == false)
			{
				throw new Exception("請輸入列數");
			}
			if (rows <= 0)
			{
				throw new Exception("列數不得小於0");
			}
			return rows;
		}
	}
}