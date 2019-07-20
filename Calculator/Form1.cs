using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display.Text = "Hello";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            append(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            append(1);
        }
        void append(object i)
        {
            Display.Text += i.ToString();

        }

        private void two_Click(object sender, EventArgs e)
        {
            append(2);
        }

        private void three_Click(object sender, EventArgs e)
        {
            append(3);
        }

        private void four_Click(object sender, EventArgs e)
        {
            append(4);
        }

        private void six_Click(object sender, EventArgs e)
        {
            append(6);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            append(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            append(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            append(9);
        }

        private void zero_Click(object sender, EventArgs e)
        {
            append(0);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            append('+');
        }

        private void minus_Click(object sender, EventArgs e)
        {
            append('-');
        }

        private void mult_Click(object sender, EventArgs e)
        {
            append('*');
        }

        private void div_Click(object sender, EventArgs e)
        {
            append('/');
        }

        private void point_Click(object sender, EventArgs e)
        {
            append('.');
        }

        private void equal_Click(object sender, EventArgs e)
        {
            string s = Display.Text.ToString();
            List<char> inp_char = new List<char>();
            char[] symbols = new char[4];
            symbols[0] = '+'; symbols[1] = '-'; symbols[2] = '*'; symbols[3] = '/';
            string[] value = s.Split(symbols);
            char[] k = s.ToCharArray();
            int n = s.Length;
            int i = 0;
            for (i = 0; i < n; i++)
            {
                if ((k[i] == '+') || (k[i] == '-') || (k[i] == '*') || (k[i] == '/'))
                {
                    inp_char.Add(k[i]);
                }
             }
            int dummy = 0;
            int pass = 1;         
            for (i = 0; i < n; i++)
            {
                if ((k[i] == 'H') || (k[i] == 'e') || (k[i] == 'l') || (k[i] == 'o'))
                {
                    MessageBox.Show("Enter Valid Computation","Start the Calculator!");
                    pass = 0;
                    dummy = 1;
                    break;
                }
            }
            int l = 0;
            if (n == 0)
            {
                MessageBox.Show("Enter the number", "Alert");
                dummy = 1;
                 l = 1;
                pass = 3;
            }
            int  w = k.Length;
            if (l != 1)
            {
                if ((k[w - 1] == '+') || (k[w - 1] == '-') || (k[w - 1] == '*') || (k[w - 1] == '/'))
                {
                    MessageBox.Show("Enter Valid Computation");
                    pass = 0;
                    dummy = 1;
                }
            }
            int m = inp_char.Count;
            if (dummy != 1)
            {
                for (i = 0; i < n; i++)
                {
                    if (((k[i] == '+') || (k[i] == '-') || (k[i] == '*') || (k[i] == '/')) && ((k[i + 1] == '+') || (k[i + 1] == '-') || (k[i + 1] == '*') || (k[i + 1] == '/')))
                    {
                        MessageBox.Show("Enter valid computation");
                        pass = 0;
                        break;
                    }
                }

                if (k[0] == '+')
                {
                    for (i = 0; i < m; i++)
                    {
                        value[i] = value[i + 1];
                    }
                    pass = 2;
                 for (i = 0; i < m - 1; i++)
                    {
                        if (inp_char[i + 1] == '+')
                            value[i + 1] = ((float.Parse(value[i])) + float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '-')
                            value[i + 1] = ((float.Parse(value[i])) - float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '*')
                            value[i + 1] = ((float.Parse(value[i])) * float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '/')
                            value[i + 1] = ((float.Parse(value[i])) / float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == ' ')
                            answer.Text = s;
                    }
                    answer.Text = float.Parse(value[m - 1]).ToString();
                }
                if (k[0] == '-')
                {
                    for (i = 0; i < m; i++)
                    {
                        value[i] = value[i + 1];
                    }
                    value[0] = '-' + value[0];
                    pass = 2;

                    for (i = 0; i < m - 1; i++)
                    {
                        if (inp_char[i + 1] == '+')
                            value[i + 1] = ((float.Parse(value[i])) + float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '-')
                            value[i + 1] = ((float.Parse(value[i])) - float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '*')
                            value[i + 1] = ((float.Parse(value[i])) * float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '/')
                            value[i + 1] = ((float.Parse(value[i])) / float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == ' ')
                            answer.Text = s;
                    }
                    answer.Text = float.Parse(value[m - 1]).ToString();
                }
            }
            if (l != 1)
            {
                if ((k[0] == '*') || (k[0] == '/'))
                {
                    MessageBox.Show("Enter Valid Computation");
                    pass = 0;
                }
            }
            if (pass == 1)
            {
                for (i = 0; i < m; i++)
                {
                    if (inp_char[i] == '+')
                        value[i+1] = ((float.Parse(value[i])) + float.Parse(value[i + 1])).ToString();
                    if (inp_char[i] == '-')
                        value[i+1] = ((float.Parse(value[i])) - float.Parse(value[i + 1])).ToString();
                    if (inp_char[i] == '*')
                        value[i+1] = ((float.Parse(value[i])) * float.Parse(value[i + 1])).ToString();
                    if (inp_char[i] == '/')
                        value[i+1] = ((float.Parse(value[i])) / float.Parse(value[i + 1])).ToString();
                    if (inp_char[i] == ' ')
                        answer.Text = s;
                }
                answer.Text = float.Parse(value[m]).ToString();
            }
        }
        void clickcount (int num)
        {
            string s = Display.Text.ToString();
            List<char> inp_char = new List<char>();
            char[] symbols = new char[4];
            symbols[0] = '+'; symbols[1] = '-'; symbols[2] = '*'; symbols[3] = '/';
            string[] value = s.Split(symbols);
            char[] k = s.ToCharArray();
            int n = s.Length;
            int i = 0;
            for (i = 0; i < n; i++)
            {
                if ((k[i] == '+') || (k[i] == '-') || (k[i] == '*') || (k[i] == '/'))
                {
                    inp_char.Add(k[i]);
                }
            }
            int dummy = 0;
            int pass = 1;
            for (i = 0; i < n; i++)
            {
                if ((k[i] == 'H') || (k[i] == 'e') || (k[i] == 'l') || (k[i] == 'o'))
                {
                    MessageBox.Show("Enter Valid Computation", "Start the Calculator!");
                    pass = 0;
                    dummy = 1;
                    break;
                }
            }
            int l = 0;
            if (n == 0)
            {
                MessageBox.Show("Enter the number", "Alert");
                dummy = 1;
                l = 1;
                pass = 3;
            }
            int w = k.Length;
            if (l != 1)
            {
                if ((k[w - 1] == '+') || (k[w - 1] == '-') || (k[w - 1] == '*') || (k[w - 1] == '/'))
                {
                    MessageBox.Show("Enter Valid Computation");
                    pass = 0;
                    dummy = 1;
                }
            }
            int m = inp_char.Count;
            if (dummy != 1)
            {
                for (i = 0; i < n; i++)
                {
                    if (((k[i] == '+') || (k[i] == '-') || (k[i] == '*') || (k[i] == '/')) && ((k[i + 1] == '+') || (k[i + 1] == '-') || (k[i + 1] == '*') || (k[i + 1] == '/')))
                    {
                        MessageBox.Show("Enter valid computation");
                        pass = 0;
                        break;
                    }
                }

                if (k[0] == '+')
                {
                    for (i = 0; i < m; i++)
                    {
                        value[i] = value[i + 1];
                    }
                    pass = 2;
                    for (i = 0; i < m - 1; i++)
                    {
                        if (inp_char[i + 1] == '+')
                            value[i + 1] = ((float.Parse(value[i])) + float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '-')
                            value[i + 1] = ((float.Parse(value[i])) - float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '*')
                            value[i + 1] = ((float.Parse(value[i])) * float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '/')
                            value[i + 1] = ((float.Parse(value[i])) / float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == ' ')
                            answer.Text = s;
                    }
                    answer.Text = float.Parse(value[m - 1]).ToString();
                }
                if (k[0] == '-')
                {
                    for (i = 0; i < m; i++)
                    {
                        value[i] = value[i + 1];
                    }
                    value[0] = '-' + value[0];
                    pass = 2;

                    for (i = 0; i < m - 1; i++)
                    {
                        if (inp_char[i + 1] == '+')
                            value[i + 1] = ((float.Parse(value[i])) + float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '-')
                            value[i + 1] = ((float.Parse(value[i])) - float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '*')
                            value[i + 1] = ((float.Parse(value[i])) * float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == '/')
                            value[i + 1] = ((float.Parse(value[i])) / float.Parse(value[i + 1])).ToString();
                        if (inp_char[i + 1] == ' ')
                            answer.Text = s;
                    }
                    answer.Text = float.Parse(value[m - 1]).ToString();
                }
            }
            if (l != 1)
            {
                if ((k[0] == '*') || (k[0] == '/'))
                {
                    MessageBox.Show("Enter Valid Computation");
                    pass = 0;
                }
            }
            if (pass == 1)
            {
                for (i = 0; i < m; i++)
                {
                    if (inp_char[i] == '+')
                        value[i + 1] = ((float.Parse(value[i])) + float.Parse(value[i + 1])).ToString();
                    if (inp_char[i] == '-')
                        value[i + 1] = ((float.Parse(value[i])) - float.Parse(value[i + 1])).ToString();
                    if (inp_char[i] == '*')
                        value[i + 1] = ((float.Parse(value[i])) * float.Parse(value[i + 1])).ToString();
                    if (inp_char[i] == '/')
                        value[i + 1] = ((float.Parse(value[i])) / float.Parse(value[i + 1])).ToString();
                    if (inp_char[i] == ' ')
                        answer.Text = s;
                }
                answer.Text = float.Parse(value[m]).ToString();
            }
           if (num == 1)
            {
                string S = answer.Text;
                float rec;
                 rec = float.Parse(S);
                answer.Text = (1 / rec).ToString();
            }
            if (num == 2)
            {
                string ans = answer.Text;
                float rec = float.Parse(ans);
                if (rec >0)
                answer.Text = Math.Sqrt(rec).ToString(); 
                if (rec<0)
                {
                    char[] f = ans.ToCharArray();
                    int p = ans.Length;
                    List<char> non_neg_inp_char = new List<char>();
                    for (i=1; i<p; i++)
                    {
                        non_neg_inp_char.Add(f[i]);
                    }
                    string new_value = "";
                    for (i = 0; i < p - 1; i++)
                    {
                       new_value += non_neg_inp_char[i];
                    }
                    float img = float.Parse(new_value);
                    answer.Text = (Math.Sqrt(img).ToString()) + "i";
                    }
            }
        }
  
        private void receprocal_Click(object sender, EventArgs e)
        {
            string s = Display.Text.ToString();
            char[] k = s.ToCharArray();
            int i, count = 0, dot = 0, n = s.Length;
            float ans;
            for (i = 0; i < n; i++)
            {
                if ((k[i] == '+') || (k[i] == '-') || (k[i] == '*') || (k[i] == '/'))
                {
                    count += 1;
                }
            }
            if (count == 0)
            {
                for (i = 0; i < n; i++)
                {
                    if ((k[i] == '.'))
                        dot += 1;
                }
                if ((dot == 0) || (dot == 1))
                {
                    ans = float.Parse(s);
                    answer.Text = (1 / ans).ToString();
                }
            }
            if ((dot >= 2))
            {
                answer.Text = "Use valid number";
            }
            if ((count >= 1) && (dot <2))
            {
                clickcount(1);
            }
        }

        private void sqroot_Click(object sender, EventArgs e)
        {
            string s = Display.Text.ToString();
            char[] k = s.ToCharArray();
            int i, count = 0, dot = 0, n = s.Length;
            float ans;
            for (i = 0; i < n; i++)
            {
                if ((k[i] == '+') || (k[i] == '-') || (k[i] == '*') || (k[i] == '/'))
                {
                    count += 1;
                }
            }
            if (count == 0)
            {
                for (i = 0; i < n; i++)
                {
                    if ((k[i] == '.'))
                        dot += 1;
                }
                if ((dot == 0) || (dot == 1))
                {
                    ans = float.Parse(s);
                    answer.Text = Math.Sqrt(ans).ToString();
                }
            }
            if ((dot >= 2))
            {
                answer.Text = "Use valid number";
            }
            if ((count >= 1) && (dot < 2))
            {
                clickcount(2);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string s = answer.Text.ToString();
            Memory.Text = s;
        }

        private void reload_Click(object sender, EventArgs e)
        {
            string s = Memory.Text.ToString();
            Display.Text += s;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            string s = Display.Text.ToString();
            int n = s.Length;
            if (n == 0)
                {
                    MessageBox.Show("No Numbers to clear");
                }          
            
            else
            {
                string str = Display.Text.Remove(Display.Text.Length - 1);
                Display.Text = str;
            }
        }

        private void A2D_Click(object sender, EventArgs e)
        {
            Display.Text = String.Empty;
            Display.Text = answer.Text;
            answer.Text = String.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Display.Text == "Hello")
            {
                
                Display.Text = String.Empty;
            }
            Reset.Image = Image.FromFile("D:/Programming/C#/Calculator/images'/2.png");
            Display.Text = String.Empty;
            answer.Text = String.Empty;
            Memory.Text = string.Empty;
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.NumPad1)
                one.PerformClick();
            if (e.KeyCode == Keys.NumPad2)
                two.PerformClick();
            if (e.KeyCode == Keys.NumPad3)
                three.PerformClick();
            if (e.KeyCode == Keys.NumPad4)
                four.PerformClick();
            if (e.KeyCode == Keys.NumPad5)
                five.PerformClick();
            if (e.KeyCode == Keys.NumPad6)
                six.PerformClick();
            if (e.KeyCode == Keys.NumPad7)
                seven.PerformClick();
            if (e.KeyCode == Keys.NumPad8)
                eight.PerformClick();
            if (e.KeyCode == Keys.NumPad9)
                nine.PerformClick();
            if (e.KeyCode == Keys.NumPad0)
                zero.PerformClick();
            if (e.KeyCode == Keys.Add)
                plus.PerformClick();
            if (e.KeyCode == Keys.Subtract)
                minus.PerformClick();
            if (e.KeyCode == Keys.Multiply)
                mult.PerformClick();
            if (e.KeyCode == Keys.Divide)
                div.PerformClick();
            if (e.KeyCode == Keys.ShiftKey)
                equal.PerformClick();
            if (e.KeyCode == Keys.Decimal)
                point.PerformClick();
            if (e.KeyCode == Keys.F1)
                button24.PerformClick();
            if (e.KeyCode == Keys.F2)
                reload.PerformClick();
            if (e.KeyCode == Keys.Back)
                clear.PerformClick();
            if (e.KeyCode == Keys.ControlKey)
                A2D.PerformClick();

        }
    }
}
