using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string str = null, action = null;
        private double Add1, Add2, Resultat = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            str = str + "0";
            textBox1.Text = str;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            str = str + "1";
            textBox1.Text = str;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            str = str + "2";
            textBox1.Text = str;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            str = str + "3";
            textBox1.Text = str;

        }

        private void button7_Click(object sender, EventArgs e)
        {

            str = str + "4";
            textBox1.Text = str;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            str = str + "5";
            textBox1.Text = str;

        }

        private void button8_Click(object sender, EventArgs e)
        {

            str = str + "6";
            textBox1.Text = str;

        }

        private void button10_Click(object sender, EventArgs e)
        {

            str = str + "7";
            textBox1.Text = str;

        }

        private void button11_Click(object sender, EventArgs e)
        {

            str = str + "8";
            textBox1.Text = str;

        }

        private void button9_Click(object sender, EventArgs e)
        {


            str = str + "9";
            textBox1.Text = str;


        }

        private void button15_Click(object sender, EventArgs e)
        {
            Solve("+");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Solve("*");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Solve("/");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Solve("-");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Solve(null);
        } 

        private void button20_Click(object sender, EventArgs e)
        {
            if (str != null)
            {
                double t;
                double.TryParse(str, out t);
                t = t * (-1);
                if(t<0)
                {
                    str = t.ToString();
                    double t2 = t * (-1);
                    string tstr = t2.ToString();
                    textBox1.Text = tstr.Insert(tstr.Length, "-");
                    return;
                }
                str = t.ToString();
                textBox1.Text = str;
            }
            else
            {
                Resultat = Resultat * (-1);
                if (Resultat < 0)
                    negativ();
                else
                    textBox1.Text = Resultat.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(str!=null)
                if (str.IndexOf(',') == -1)
                {
                    str = str + ',';
                    textBox1.Text = str;
                }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (str != null)
            {
                if(action.CompareTo("*")==0)
                {
                    double.TryParse(str, out Add2);
                    Resultat = Resultat / 100;
                    Resultat = Resultat * Add2;
                    if (Resultat < 0)
                    {
                        negativ();
                        str = null;
                        action = null;
                        return;
                    }
                    textBox1.Text = Resultat.ToString();
                    str = null;
                    action = null;
                    return;
                }
            
            }
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            str = null;
            textBox1.Text = "0";
            Resultat = 0;
            action = null;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Solve("^");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Koren();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(str!=null)
            {
                if(str.Length == 1)
                {
                    textBox1.Text = "";
                    str = null;
                }
                else
                {
                    double temp;
                    string temp_str;
                    str = str.Remove(str.Length - 1);
                    double.TryParse(str, out temp);
                    if(temp<0)
                    {
                        temp = temp * (-1);
                        temp_str = temp.ToString();
                        temp_str = temp_str.Insert(temp_str.Length, "-");
                        textBox1.Text = temp_str;
                        return;

                    }
                    textBox1.Text = str;
                    return;
                }
            }
            else
                if(Resultat!=0)
            {
                if(Resultat<0)
                {
                    string buffer = Resultat.ToString();
                    if(buffer.Length==2)
                    {
                        Resultat = 0;
                        textBox1.Text = Resultat.ToString();
                    }
                    else
                    {
                        buffer = buffer.Remove(buffer.Length - 1);
                        double.TryParse(buffer, out Resultat);
                        negativ();
                    }
                }
                else
                    if(Resultat>0)
                {
                    string buffer = Resultat.ToString();
                    if (buffer.Length == 1)
                    {
                        Resultat = 0;
                        textBox1.Text = Resultat.ToString();
                    }
                    else
                    {
                        buffer = buffer.Remove(buffer.Length - 1);
                        double.TryParse(buffer, out Resultat);
                        textBox1.Text = Resultat.ToString();
                    }

                }
               
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Trig("sin");
        }

        private void negativ()
        {
            double NegResult = Resultat * (-1);
            string temp = NegResult.ToString();
            temp = temp.Insert(temp.Length, "-");
            textBox1.Text = temp;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Trig("cos");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Trig("tan");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Trig("ctg");
        }

        private void Solve(string sign)
        {
            if (str != null)
            {
                if (action != null)
                {
                    if (action.CompareTo("*") == 0)
                    {
                        double.TryParse(str, out Add2);
                        Resultat = Resultat * Add2;
                        if (Resultat < 0)
                        {
                            negativ();
                            str = null;
                            action = sign;
                            return;
                        }
                        textBox1.Text = Resultat.ToString();
                        str = null;
                        action = sign;
                        return;
                    }
                    else
                        if (action.CompareTo("+") == 0)
                    {
                        double.TryParse(str, out Add2);
                        Resultat = Resultat + Add2;
                        if (Resultat < 0)
                        {
                            negativ();
                            str = null;
                            action = sign;
                            return;
                        }
                        textBox1.Text = Resultat.ToString();
                        str = null;
                        action = sign;
                        return;
                    }
                    else
                        if (action.CompareTo("/") == 0)
                    {
                        double.TryParse(str, out Add2);
                        if (Add2 == 0)
                        {
                            MessageBox.Show("На ноль делить нельзя! Пожалуйста, введите другое число");
                            if (Resultat < 0)
                            {
                                negativ();
                                str = null;
                                action = sign;
                                return;
                            }
                            else
                            {
                                textBox1.Text = Resultat.ToString();
                                str = null;
                                action = sign;
                                return;
                            }
                        }
                        Resultat = Resultat / Add2;
                        if (Resultat < 0)
                        {
                            negativ();
                            str = null;
                            action = sign;
                            return;
                        }
                        textBox1.Text = Resultat.ToString();
                        str = null;
                        action = sign;
                        return;
                    }
                    else
                        if (action.CompareTo("-") == 0)
                    {
                        double.TryParse(str, out Add2);
                        Resultat = Resultat - Add2;
                        if (Resultat < 0)
                        {
                            negativ();
                            str = null;
                            action = sign;
                            return;
                        }
                        textBox1.Text = Resultat.ToString();
                        str = null;
                        action = sign;
                        return;
                    }
                    else
                        if (action.CompareTo("^") == 0)
                    {
                        double.TryParse(str, out Add2);
                        if (Add2<1 && Resultat<0)
                        {

                            MessageBox.Show("Нельзя извлекать корень из отрицательного числа! Пожалуйста, введите другое число");
                            str = null;
                            action = sign;
                            return;
                        }
                        Resultat = Math.Pow(Resultat, Add2);
                        if (Resultat < 0)
                        {
                            negativ();
                            str = null;
                            action = sign;
                            return;
                        }
                        textBox1.Text = Resultat.ToString();
                        str = null;
                        action = sign;
                        return;
                    }
                    

                }

                double.TryParse(str, out Resultat);
                if (Resultat < 0)
                {
                    negativ();
                    str = null;
                    action = sign;
                    return;
                }
                textBox1.Text = Resultat.ToString();
                action = sign;
                str = null;
            }
            action = sign;
        }

        private void Koren()
        {
            if (str != null)
            {
                double.TryParse(str, out Resultat);
                if (Resultat < 0)
                {
                    MessageBox.Show("Нельзя извлекать корень из отрицательного числа! Пожалуйста, введите другое число");
                    return;
                }
                Resultat = Math.Sqrt(Resultat);
                str = Resultat.ToString();
                textBox1.Text = Resultat.ToString();
            }
            else
            {
                if (Resultat < 0)
                {
                    MessageBox.Show("Нельзя извлекать корень из отрицательного числа! Пожалуйста, введите другое число");
                    return;
                }
                Resultat = Math.Sqrt(Resultat);
                textBox1.Text = Resultat.ToString();
            }         
        }
        private void Trig(string function)
        {
            if (str != null)
            {
                if(function.CompareTo("sin")==0)
                {
                    double degree = 0;
                    double.TryParse(str, out degree);
                    Resultat = Math.PI * degree / 180;
                    Resultat = Math.Sin(Resultat);
                    if (double.IsNaN(Resultat))
                    {
                        Resultat = 0;
                        MessageBox.Show("Результат операции не число.");
                        textBox1.Text = Resultat.ToString();
                        str = Resultat.ToString();
                        return;
                    }
                    str = Resultat.ToString();
                    if (Resultat < 0)
                    {
                        negativ();
                        return;
                    }
                    textBox1.Text = Resultat.ToString();
                }
                else
                    if (function.CompareTo("cos") == 0)
                {
                    double degree = 0;
                    double.TryParse(str, out degree);
                    Resultat = Math.PI * degree / 180;
                    Resultat = Math.Cos(Resultat);
                    if (double.IsNaN(Resultat))
                    {
                        Resultat = 0;
                        MessageBox.Show("Результат операции не число.");
                        textBox1.Text = Resultat.ToString();
                        str = Resultat.ToString();
                        return;
                    }
                    str = Resultat.ToString();
                    if (Resultat < 0)
                    {
                        negativ();
                        return;
                    }
                    textBox1.Text = Resultat.ToString();
                }
                if (function.CompareTo("tan") == 0)
                {
                    double degree = 0;
                    double.TryParse(str, out degree);
                    Resultat = Math.PI * degree / 180;
                    Resultat = Math.Tan(Resultat);
                    if (double.IsNaN(Resultat))
                    {
                        Resultat = 0;
                        MessageBox.Show("Результат операции не число.");
                        textBox1.Text = Resultat.ToString();
                        str = Resultat.ToString();
                        return;
                    }
                    str = Resultat.ToString();
                    if (Resultat < 0)
                    {
                        negativ();
                        return;
                    }
                    textBox1.Text = Resultat.ToString();
                }
                else
                    if (function.CompareTo("ctg") == 0)
                {
                    double degree = 0;
                    double.TryParse(str, out degree);
                    Resultat = Math.PI * degree / 180;
                    Resultat = 1/Math.Tan(Resultat);
                    if (double.IsNaN(Resultat))
                    {
                        Resultat = 0;
                        MessageBox.Show("Результат операции не число.");
                        textBox1.Text = Resultat.ToString();
                        str = Resultat.ToString();
                        return;
                    }
                    str = Resultat.ToString();
                    if (Resultat < 0)
                    {
                        negativ();
                        return;
                    }
                    textBox1.Text = Resultat.ToString();
                }

            }
            else
            {
                if (function.CompareTo("sin") == 0)
                {
                    Resultat = Math.PI * Resultat / 180;
                    Resultat = Math.Sin(Resultat);
                    if (double.IsNaN(Resultat))
                    {
                        Resultat = 0;
                        MessageBox.Show("Результат операции не число.");
                        textBox1.Text = Resultat.ToString();
                        str = Resultat.ToString();
                        return;
                    }
                    if (Resultat < 0)
                    {
                        negativ();
                        return;
                    }
                    textBox1.Text = Resultat.ToString();
                }
                else
                    if (function.CompareTo("cos") == 0)
                {
                    
                    Resultat = Math.PI * Resultat / 180;
                    Resultat = Math.Cos(Resultat);
                    if (double.IsNaN(Resultat))
                    {
                        Resultat = 0;
                        MessageBox.Show("Результат операции не число.");
                        textBox1.Text = Resultat.ToString();
                        str= Resultat.ToString();
                        return;
                    }
                    str = Resultat.ToString();
                    if (Resultat < 0)
                    {
                        negativ();
                        return;
                    }
                    textBox1.Text = Resultat.ToString();
                }
                else
                    if (function.CompareTo("tan") == 0)
                {                   
                    Resultat = Math.PI * Resultat / 180;
                    Resultat = Math.Tan(Resultat);
                    if (double.IsNaN(Resultat))
                    {
                        Resultat = 0;
                        MessageBox.Show("Результат операции не число.");
                        textBox1.Text = Resultat.ToString();
                        str = Resultat.ToString();
                        return;
                    }
                    str = Resultat.ToString();
                    if (Resultat < 0)
                    {
                        negativ();
                        return;
                    }
                    textBox1.Text = Resultat.ToString();
                }
                else
                    if (function.CompareTo("ctg") == 0)
                {                    
                    Resultat = Math.PI * Resultat / 180;
                    Resultat = 1/Math.Tan(Resultat);
                    if (double.IsNaN(Resultat))
                    {
                        Resultat = 0;
                        MessageBox.Show("Результат операции не число.");
                        textBox1.Text = Resultat.ToString();
                        str = Resultat.ToString();
                        return;
                    }
                    str = Resultat.ToString();
                    if (Resultat < 0)
                    {
                        negativ();
                        return;
                    }
                    textBox1.Text = Resultat.ToString();
                }

            }
        }
    }
}
