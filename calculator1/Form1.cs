using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;
            
            if (String.IsNullOrWhiteSpace(num1.Text))
            {
                MessageBox.Show(" 첫번째 칸에 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
                return;
            }
            else if(int.TryParse(num1.Text,out number1) == false)
            {
                MessageBox.Show(" 첫번째 칸에 문자가 들어갔습니다. 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
            }
            
            if(String.IsNullOrWhiteSpace(num2.Text))
            {
                MessageBox.Show(" 두번째 칸에 숫자를 넣어주세요");
                num2.Focus();
                num2.SelectAll();
                return;
            }
            else if (int.TryParse(num2.Text, out number2) == false)
            {
                MessageBox.Show(" 두번째 칸에 문자가 들어갔습니다. 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
            }

           number1 = Convert.ToInt32(num1.Text);
           number2 = Convert.ToInt32(num2.Text);
            int sum=SumResult(number1, number2);

            result.Text = sum.ToString();
        }

        public int SumResult(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;

            if (String.IsNullOrWhiteSpace(num1.Text))
            {
                MessageBox.Show(" 첫번째 칸에 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
                return;
            }
            else if (int.TryParse(num1.Text, out number1) == false)
            {
                MessageBox.Show(" 첫번째 칸에 문자가 들어갔습니다. 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
            }

            if (String.IsNullOrWhiteSpace(num2.Text))
            {
                MessageBox.Show(" 두번째 칸에 숫자를 넣어주세요");
                num2.Focus();
                num2.SelectAll();
                return;
            }
            else if (int.TryParse(num2.Text, out number2) == false)
            {
                MessageBox.Show(" 두번째 칸에 문자가 들어갔습니다. 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
            }


            number1 = Convert.ToInt32(num1.Text);
            number2 = Convert.ToInt32(num2.Text);
            int minus = MinusResult(number1, number2);

            result.Text = minus.ToString();
        }
        public int MinusResult(int number1, int number2)
        {
            int minus = number1 - number2;
            return minus;
        }

        private void Cross_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            int number2 = 0;

            

            if (String.IsNullOrWhiteSpace(num1.Text))
            {
                MessageBox.Show(" 첫번째 칸에 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
                return;
            }
            else if (int.TryParse(num1.Text, out number1) == false)
            {
                MessageBox.Show(" 첫번째 칸에 문자가 들어갔습니다. 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
            }

            if (String.IsNullOrWhiteSpace(num2.Text))
            {
                MessageBox.Show(" 두번째 칸에 숫자를 넣어주세요");
                num2.Focus();
                num2.SelectAll();
                return;
            }
            else if (int.TryParse(num2.Text, out number2) == false)
            {
                MessageBox.Show(" 두번째 칸에 문자가 들어갔습니다. 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
            }


            number1 = Convert.ToInt32(num1.Text);
            number2 = Convert.ToInt32(num2.Text);
            int cross = CrossResult(number1, number2);

            result.Text = cross.ToString();
        }
        public int CrossResult(int number1, int number2)
        {
            int Cross = number1 * number2;
            return Cross;
        }

        private void Division_Click(object sender, EventArgs e)
        {

            int number1 = 0;
            int number2 = 0;

            if (String.IsNullOrWhiteSpace(num1.Text))
            {
                MessageBox.Show(" 첫번째 칸에 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
                return;
            }
            else if (int.TryParse(num1.Text, out number1) == false)
            {
                MessageBox.Show(" 첫번째 칸에 문자가 들어갔습니다. 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
            }

            if (String.IsNullOrWhiteSpace(num2.Text))
            {
                MessageBox.Show(" 두번째 칸에 숫자를 넣어주세요");
                num2.Focus();
                num2.SelectAll();
                return;
            }
            else if (int.TryParse(num2.Text, out number2) == false)
            {
                MessageBox.Show(" 두번째 칸에 문자가 들어갔습니다. 숫자를 넣어주세요");
                num1.Focus();
                num1.SelectAll();
            }

            number1 = Convert.ToInt32(num1.Text);
            number2 = Convert.ToInt32(num2.Text);
            int division =DivisionResult(number1, number2);

            result.Text = division.ToString();
        }

        public int DivisionResult(int number1, int number2)
        {
            int Division = number1 / number2;
            return Division;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
