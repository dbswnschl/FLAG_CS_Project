using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 계산기모형
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 전역변수 선언
        double plus, minus, multi, divide;
        double current;
        double result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (Text_main.Text == "0") // Text_main의 Text내용이 "0" 일때
            {
                Text_main.Text = "1"; // Text_main의 Text내용을 "1"로 변경
            }
            else // Text_main의 Text의 내용이 "0"이 아닐 때
            {
                Text_main.Text = Text_main.Text + "1"; // 기존 Text 뒤에 1을 붙임
            }
            
        }
        private void Btn_2_Click(object sender, EventArgs e) // 버튼2부터 9까지는 내용이 같음
        {

            if (Text_main.Text == "0")
            {
                Text_main.Text = "2";
            }
            else
            {
                Text_main.Text = Text_main.Text + "2";
            }
        }
        private void Btn_3_Click(object sender, EventArgs e)
        {

            if (Text_main.Text == "0")
            {
                Text_main.Text = "3";
            }
            else
            {
                Text_main.Text = Text_main.Text + "3";
            }
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {

            if (Text_main.Text == "0")
            {
                Text_main.Text = "4";
            }
            else
            {
                Text_main.Text = Text_main.Text + "4";
            }
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {

            if (Text_main.Text == "0")
            {
                Text_main.Text = "5";
            }
            else
            {
                Text_main.Text = Text_main.Text + "5";
            }
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {

            if (Text_main.Text == "0")
            {
                Text_main.Text = "6";
            }
            else
            {
                Text_main.Text = Text_main.Text + "6";
            }
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {

            if (Text_main.Text == "0")
            {
                Text_main.Text = "7";
            }
            else
            {
                Text_main.Text = Text_main.Text + "7";
            }
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {

            if (Text_main.Text == "0")
            {
                Text_main.Text = "8";
            }
            else
            {
                Text_main.Text = Text_main.Text + "8";
            }
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {

            if (Text_main.Text == "0")
            {
                Text_main.Text = "9";
            }
            else
            {
                Text_main.Text = Text_main.Text + "9";
            }
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {

            if (Text_main.Text != "0") // Text_main의 Text가 0이 아닐떄 
            {
                Text_main.Text = Text_main.Text + "0"; // Text의 뒤에 0을 붙인다
            }
        }

        private void Btn_plus_Click(object sender, EventArgs e) // 더하기
        {
            if (plus == 0 && minus == 0 && multi == 0 && divide == 0)
            {
                current = double.Parse(Text_main.Text);
            }
            if (plus != 0)
            {
                current = plus + double.Parse(Text_main.Text);
                plus = 0;
            }
            if (minus != 0)
            {
                current = minus - double.Parse(Text_main.Text);
                minus = 0;
            }
            if (multi != 0)
            {
                current = multi * double.Parse(Text_main.Text);
            }
            if (divide != 0)
            {
                current = divide / double.Parse(Text_main.Text);
            }
            plus += current;

            Text_main.Text = "0";
        }
        private void Btn_minus_Click(object sender, EventArgs e)
        {
            if (plus == 0 && minus == 0 && multi == 0 && divide == 0)
            {
                current = double.Parse(Text_main.Text);
            }
            if (plus != 0)
            {
                current = plus + double.Parse(Text_main.Text);
                plus = 0;
            }
            if (minus != 0)
            {
                current = minus - double.Parse(Text_main.Text);
                minus = 0;
            }
            if (multi != 0)
            {
                current = multi * double.Parse(Text_main.Text);
            }
            if (divide != 0)
            {
                current = divide / double.Parse(Text_main.Text);
            }

            minus += current;

            Text_main.Text = "0";
        }
        private void Btn_multi_Click(object sender, EventArgs e)
        {
            if (plus == 0 && minus == 0 && multi == 0 && divide == 0)
            {
                current = double.Parse(Text_main.Text);
            }
            if (plus != 0)
            {
                current = plus + double.Parse(Text_main.Text);
                plus = 0;
            }
            if (minus != 0)
            {
                current = minus - double.Parse(Text_main.Text);
                minus = 0;
            }
            if (multi != 0)
            {
                current = multi * double.Parse(Text_main.Text);
            }
            if (divide != 0)
            {
                current = divide / double.Parse(Text_main.Text);
            }

            multi += current;

            Text_main.Text = "0";
        }
        private void Btn_divide_Click(object sender, EventArgs e)
        {
            if (plus == 0 && minus == 0 && multi == 0 && divide == 0)
            {
                current = double.Parse(Text_main.Text);
            }
            if (plus != 0)
            {
                current = plus + double.Parse(Text_main.Text);
                plus = 0;
            }
            if (minus != 0)
            {
                current = minus - double.Parse(Text_main.Text);
                minus = 0;
            }
            if (multi != 0)
            {
                current = multi * double.Parse(Text_main.Text);
            }
            if (divide != 0)
            {
                current = divide / double.Parse(Text_main.Text);
            }


            divide += current;

            Text_main.Text = "0";
        }
        private void Btn_result_Click(object sender, EventArgs e)
        {
            if (plus != 0)
            {
                result = double.Parse(Text_main.Text) + plus;
                plus = 0;
            } 
             if (minus != 0)
            {
                result = minus - double.Parse(Text_main.Text) ;
                minus = 0;
            }
             if (multi != 0)
             {
                 result = multi * double.Parse(Text_main.Text);
                 multi = 0;
             }
            if (divide != 0)
             {
                 result = divide / double.Parse(Text_main.Text);
                 divide = 0;
             }

            Text_main.Text = result.ToString();
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            current = 0;
            plus = 0;
            minus = 0;
            multi = 0;
            divide = 0;
            result = 0;
            Text_main.Text = "0";

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Text_main.Text= Text_main.Text.Substring(0,Text_main.Text.Length-1);
            if (Text_main.Text == "")
            {
                Text_main.Text = "0";
            }
        }

        private void Btn_dot_Click(object sender, EventArgs e)
        {
            if(Text_main.Text.IndexOf(".") == -1)
            Text_main.Text += ".";
        }







    }
}
