using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace ConvertBaseNumber
{
    public partial class FormMain : Form
    {
        string check;
        int alphabet = 0;
        int op = 0;
        StringBuilder textResult = new StringBuilder();
        int text = 0;


        public FormMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (tbxInput.Text.Length < 10)
            {
                if (cmbMode.Text == "Base 2 --> Base 8")
                {
                    tbxResult.Text = FindBintoOct(2, int.Parse(tbxInput.Text)).ToString();
                }
                else if (cmbMode.Text == "Base 2 --> Base 10")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindBintoDec(2, int.Parse(tbxInput.Text)).ToString();
                }
                else if (cmbMode.Text == "Base 2 --> Base 16")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindBintoHex(2, int.Parse(tbxInput.Text)).ToString();
                }
                else if (cmbMode.Text == "Base 8 --> Base 2")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindOcttoBin(8, int.Parse(tbxInput.Text)).ToString();
                }
                else if (cmbMode.Text == "Base 8 --> Base 10")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindOcttoDec(8, int.Parse(tbxInput.Text)).ToString();
                }
                else if (cmbMode.Text == "Base 8 --> Base 16")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindOcttoHex(8, int.Parse(tbxInput.Text)).ToString();
                }
                else if (cmbMode.Text == "Base 10 --> Base 2")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindDectoBin(int.Parse(tbxInput.Text)).ToString();
                }
                else if (cmbMode.Text == "Base 10 --> Base 8")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindDectoOct(int.Parse(tbxInput.Text)).ToString();
                }
                else if (cmbMode.Text == "Base 10 --> Base 16")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindDectoHex(int.Parse(tbxInput.Text)).ToString();
                }
                else if (cmbMode.Text == "Base 16 --> Base 2")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindHextoBin(16, tbxInput.Text).ToString();
                }
                else if (cmbMode.Text == "Base 16 --> Base 8")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindHextoOct(16, tbxInput.Text.ToUpper()).ToString();
                }
                else if (cmbMode.Text == "Base 16 --> Base 10")
                {
                    if (tbxInput.Text.Length < 10)
                        tbxResult.Text = FindHextoDec(16, tbxInput.Text.ToUpper()).ToString();
                }
                else
                {
                }
            }
            else
                MessageBox.Show("Input Number Can't Entered More Than 9 Charactors");
            if (cmbMode.Text != "Base 2 --> Base 16")
            {
                if (cmbMode.Text != "Base 8 --> Base 16")
                {
                    if (cmbMode.Text != "Base 10 --> Base 16")
                    {
                        exchange ex = new exchange();
                        String textRe = ex.NumberToWords(int.Parse(tbxResult.Text));
                        SpeechSynthesizer read = new SpeechSynthesizer();
                        read.Dispose();
                        read = new SpeechSynthesizer();
                        read.SpeakAsync("The Result is    " + textRe);
                    }
                }
            }
        }

        private void cmbMode_TextChanged(object sender, EventArgs e)
        {
            text = 0;
            tbxInput.Text = "";
            tbxResult.Text = "";
            if ((tbxInput.Text != "") && (cmbMode.Text != "What Base You Need to Convert"))
            {
                btnConvert.Enabled = true;
            }
            else
            {
                btnConvert.Enabled = false;
            }
            label8.Focus();
        }

        private void tbxInput_TextChanged(object sender, EventArgs e)
        {
            if ((tbxInput.Text != "") && (cmbMode.Text != "What Base You Need to Convert"))
            {
                btnConvert.Enabled = true;
            }
            else
            {
                btnConvert.Enabled = false;
            }
        }

        private static string FindBintoOct(int inputBNum, int number)
        {
            string bintodec = FindDec(inputBNum, number);
            int dectobin = int.Parse(bintodec);
            string result = FindDectoOct(dectobin);
            return result;
        }

        private static string FindBintoDec(int inputBNum, int number)
        {
            string result = FindDec(inputBNum, number);
            return result;
        }

        private static string FindBintoHex(int inputBNum, int number)
        {
            string bintodec = FindDec(inputBNum, number);
            int dectohex = int.Parse(bintodec);
            string result = FindDectoHex(dectohex);
            return result;
        }

        private static string FindOcttoBin(int inputBNum, int number)
        {
            string octtodec = FindDec(inputBNum, number);
            int dectobin = int.Parse(octtodec);
            string result = FindDectoBin(dectobin);
            return result;
        }

        private static string FindOcttoDec(int inputBNum, int number)
        {
            string result = FindDec(inputBNum, number);
            return result;
        }

        private static string FindOcttoHex(int inputBNum, int number)
        {
            string octtodec = FindDec(inputBNum, number);
            int dectohex = int.Parse(octtodec);
            string result = FindDectoHex(dectohex);
            return result;
        }

        private static string FindDectoBin(int number)
        {
            int Numden = number;
            string result = "";
            do
            {
                if (Numden >= 2)
                    result = (Numden % 2) + result;
                else
                    result = Numden + result;
                Numden /= 2;
            } while (Numden > 0);
            return result;
        }

        private static string FindDectoOct(int number)
        {
            int Numden = number;
            string result = "";
            do
            {
                if (Numden >= 8)
                    result = (Numden % 8) + result;
                else
                    result = Numden + result;
                Numden /= 8;
            } while (Numden > 0);
            return result;
        }

        private static string FindDectoHex(int number)
        {
            int Numden = number;
            string result = "";
            do
            {
                if (Numden >= 16)
                {
                    if (Numden % 16 == 10)
                        result = "A" + result;
                    else if (Numden % 16 == 11)
                        result = "B" + result;
                    else if (Numden % 16 == 12)
                        result = "C" + result;
                    else if (Numden % 16 == 13)
                        result = "D" + result;
                    else if (Numden % 16 == 14)
                        result = "E" + result;
                    else if (Numden % 16 == 15)
                        result = "F" + result;
                    else
                        result = (Numden % 16) + result;
                }
                else
                    result = Numden + result;
                Numden /= 16;
            } while (Numden > 0);
            return result;
        }

        private static string FindHextoBin(int inputBNum, string numberhex)
        {
            string hextodec = FindHextoDec(inputBNum, numberhex);
            int dectobin = int.Parse(hextodec);
            string result = FindDectoBin(dectobin);
            return result;
        }

        private static string FindHextoOct(int inputBNum, string numberhex)
        {
            string hextodec = FindHextoDec(inputBNum, numberhex);
            int dectoOct = int.Parse(hextodec);
            string result = FindDectoOct(dectoOct);
            return result;
        }

        private static string FindHextoDec(int inputBNum, string numberhex)
        {
            string defnum = numberhex;
            int val = 0, j = 0;
            for (int i = (defnum.Length - 1); i >= 0; i--, j++)
            {
                if (defnum.Substring(i, 1) == "A" || defnum.Substring(i, 1) == "a")
                    val += 10 * Convert.ToInt32(Math.Pow(inputBNum, j));
                else if (defnum.Substring(i, 1) == "B" || defnum.Substring(i, 1) == "b")
                    val += 11 * Convert.ToInt32(Math.Pow(inputBNum, j));
                else if (defnum.Substring(i, 1) == "C" || defnum.Substring(i, 1) == "c")
                    val += 12 * Convert.ToInt32(Math.Pow(inputBNum, j));
                else if (defnum.Substring(i, 1) == "D" || defnum.Substring(i, 1) == "d")
                    val += 13 * Convert.ToInt32(Math.Pow(inputBNum, j));
                else if (defnum.Substring(i, 1) == "E" || defnum.Substring(i, 1) == "e")
                    val += 14 * Convert.ToInt32(Math.Pow(inputBNum, j));
                else if (defnum.Substring(i, 1) == "F" || defnum.Substring(i, 1) == "F")
                    val += 15 * Convert.ToInt32(Math.Pow(inputBNum, j));
                else
                    val += Convert.ToInt32(defnum.Substring(i, 1)) * Convert.ToInt32(Math.Pow(inputBNum, j));
            }
            string result = Convert.ToString(val);
            return result;
        }

        private static string FindDec(int inputBNum, int number)
        {
            string defnum = Convert.ToString(number);
            int val = 0, j = 0;
            for (int i = (defnum.Length - 1); i >= 0; i--, j++)
            {
                val += Convert.ToInt32(defnum.Substring(i, 1)) * Convert.ToInt32(Math.Pow(inputBNum, j));
            }
            string result = Convert.ToString(val);
            return result;
        }

        private void tbxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((cmbMode.Text == "Base 16 --> Base 2") || (cmbMode.Text == "Base 16 --> Base 8") || (cmbMode.Text == "Base 16 --> Base 10"))
            {
                if ( ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) 
                    || (int)e.KeyChar == 65
                    || (int)e.KeyChar == 97
                    || (int)e.KeyChar == 66
                    || (int)e.KeyChar == 98
                    || (int)e.KeyChar == 67
                    || (int)e.KeyChar == 99
                    || (int)e.KeyChar == 68
                    || (int)e.KeyChar == 100
                    || (int)e.KeyChar == 69
                    || (int)e.KeyChar == 101
                    || (int)e.KeyChar == 70
                    || (int)e.KeyChar == 102
                    || (int)e.KeyChar == 8
                    || (int)e.KeyChar ==13 )
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if ((cmbMode.Text == "Base 8 --> Base 2") || (cmbMode.Text == "Base 8 --> Base 10") || (cmbMode.Text == "Base 8 --> Base 16"))
            {
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 55)
                    || (int)e.KeyChar == 8
                    || (int)e.KeyChar == 13)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if ((cmbMode.Text == "Base 2 --> Base 8") || (cmbMode.Text == "Base 2 --> Base 10") || (cmbMode.Text == "Base 2 --> Base 16"))
            {
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 49)
                    || (int)e.KeyChar == 8
                    || (int)e.KeyChar == 13)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
                    || (int)e.KeyChar == 8
                    || (int)e.KeyChar == 13)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                if (e.KeyCode == Keys.Add && check != tbxCalculator.Text)
                {
                    if (op == 0 && tbxCalculator.Text != "")
                    {
                        btnPlus_Click(null, null);
                    }
                }
                else if (e.KeyCode == Keys.Subtract && check != tbxCalculator.Text)
                {
                    if (op == 0 && tbxCalculator.Text != "")
                    {
                        btnMinus_Click(null, null);
                    }
                }
                else if (e.KeyCode == Keys.Multiply && check != tbxCalculator.Text)
                {
                    if (op == 0 && tbxCalculator.Text != "")
                    {
                        btnMultiply_Click(null, null);
                    }
                }
                else if (e.KeyCode == Keys.Divide && check != tbxCalculator.Text)
                {
                    if (op == 0 && tbxCalculator.Text != "")
                    {
                        btnDivide_Click(null, null);
                    }
                }
                else if (e.KeyCode == Keys.Back && check != tbxCalculator.Text)
                {
                    if (tbxCalculator.Text != "")
                    {
                        string text = tbxCalculator.Text;
                        char ch = text[tbxCalculator.Text.Length - 1];
                        if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
                        {
                            op = 0;
                            alphabet = tbxCalculator.Text.Length - 1;
                        }
                        else
                        {
                            alphabet--;
                        }
                        tbxCalculator.Text = tbxCalculator.Text.Substring(0, (tbxCalculator.Text).Length - 1);
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (check == tbxCalculator.Text)
                    {
                        tbxCalculator.Text = "";
                    }
                    else
                    {
                        btnEnter_Click(null, null);
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    btnClear_Click(null, null);
                }
                else if (alphabet < 8 && check != tbxCalculator.Text)
                {
                    if (e.KeyCode == Keys.NumPad1)
                    {
                        btn1_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.NumPad2)
                    {
                        btn2_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.NumPad3)
                    {
                        btn3_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.NumPad4)
                    {
                        btn4_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.NumPad5)
                    {
                        btn5_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.NumPad6)
                    {
                        btn6_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.NumPad7)
                    {
                        btn7_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.NumPad8)
                    {
                        btn8_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.NumPad9)
                    {
                        btn9_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.NumPad0)
                    {
                        btn0_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.A)
                    {
                        btnA_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.B)
                    {
                        btnB_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.C)
                    {
                        btnC_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.D)
                    {
                        btnD_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.E)
                    {
                        btnE_Click(null, null);
                    }
                    else if (e.KeyCode == Keys.F)
                    {
                        btnF_Click(null, null);
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Back )
                {
                    if(tbxInput.Text!="")
                        tbxInput.Text = tbxInput.Text.Substring(0, (tbxInput.Text).Length - 1);
                    if(text>0)
                        text--;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (tbxInput.Text!="")
                    {
                        btnConvert_Click(null, null);
                        text = tbxInput.Text.Length;
                    }
                }
                else if (text < 8 )
                {
                    if (e.KeyCode == Keys.NumPad1)
                    {
                        tbxInput.Text += "1";
                        text++;
                    }
                    else if (e.KeyCode == Keys.NumPad2 && ( cmbMode.Text == "Base 8 --> Base 2" || cmbMode.Text == "Base 8 --> Base 10" || cmbMode.Text == "Base 8 --> Base 16"
                                || cmbMode.Text == "Base 10 --> Base 2" || cmbMode.Text == "Base 10 --> Base 8" || cmbMode.Text == "Base 10 --> Base 16"
                                || cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10") )
                    {
                        tbxInput.Text += "2";
                        text++;
                    }
                    else if (e.KeyCode == Keys.NumPad3 && (cmbMode.Text == "Base 8 --> Base 2" || cmbMode.Text == "Base 8 --> Base 10" || cmbMode.Text == "Base 8 --> Base 16"
                                || cmbMode.Text == "Base 10 --> Base 2" || cmbMode.Text == "Base 10 --> Base 8" || cmbMode.Text == "Base 10 --> Base 16"
                                || cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "3";
                        text++;
                    }
                    else if (e.KeyCode == Keys.NumPad4 && (cmbMode.Text == "Base 8 --> Base 2" || cmbMode.Text == "Base 8 --> Base 10" || cmbMode.Text == "Base 8 --> Base 16"
                                || cmbMode.Text == "Base 10 --> Base 2" || cmbMode.Text == "Base 10 --> Base 8" || cmbMode.Text == "Base 10 --> Base 16"
                                || cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "4";
                        text++;
                    }
                    else if (e.KeyCode == Keys.NumPad5 && (cmbMode.Text == "Base 8 --> Base 2" || cmbMode.Text == "Base 8 --> Base 10" || cmbMode.Text == "Base 8 --> Base 16"
                                || cmbMode.Text == "Base 10 --> Base 2" || cmbMode.Text == "Base 10 --> Base 8" || cmbMode.Text == "Base 10 --> Base 16"
                                || cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "5";
                        text++;
                    }
                    else if (e.KeyCode == Keys.NumPad6 && (cmbMode.Text == "Base 8 --> Base 2" || cmbMode.Text == "Base 8 --> Base 10" || cmbMode.Text == "Base 8 --> Base 16"
                                || cmbMode.Text == "Base 10 --> Base 2" || cmbMode.Text == "Base 10 --> Base 8" || cmbMode.Text == "Base 10 --> Base 16"
                                || cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "6";
                        text++;
                    }
                    else if (e.KeyCode == Keys.NumPad7 && (cmbMode.Text == "Base 8 --> Base 2" || cmbMode.Text == "Base 8 --> Base 10" || cmbMode.Text == "Base 8 --> Base 16"
                                || cmbMode.Text == "Base 10 --> Base 2" || cmbMode.Text == "Base 10 --> Base 8" || cmbMode.Text == "Base 10 --> Base 16"
                                || cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "7";
                        text++;
                    }
                    else if (e.KeyCode == Keys.NumPad8 && (cmbMode.Text == "Base 10 --> Base 2" || cmbMode.Text == "Base 10 --> Base 8" || cmbMode.Text == "Base 10 --> Base 16"
                                || cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "8";
                        text++;
                    }
                    else if (e.KeyCode == Keys.NumPad9 && (cmbMode.Text == "Base 10 --> Base 2" || cmbMode.Text == "Base 10 --> Base 8" || cmbMode.Text == "Base 10 --> Base 16"
                                || cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "9";
                        text++;
                    }
                    else if (e.KeyCode == Keys.NumPad0)
                    {
                        tbxInput.Text += "0";
                        text++;
                    }
                    else if (e.KeyCode == Keys.A && (cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "A";
                        text++;
                    }
                    else if (e.KeyCode == Keys.B && (cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "B";
                        text++;
                    }
                    else if (e.KeyCode == Keys.C && (cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "C";
                        text++;
                    }
                    else if (e.KeyCode == Keys.D && (cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "D";
                        text++;
                    }
                    else if (e.KeyCode == Keys.E && (cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "E";
                        text++;
                    }
                    else if (e.KeyCode == Keys.F && (cmbMode.Text == "Base 16 --> Base 2" || cmbMode.Text == "Base 16 --> Base 8" || cmbMode.Text == "Base 16 --> Base 10"))
                    {
                        tbxInput.Text += "F";
                        text++;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "0";
                alphabet++;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "1";
                alphabet++;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "2";
                alphabet++;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "3";
                alphabet++;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "4";
                alphabet++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "5";
                alphabet++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "6";
                alphabet++;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "7";
                alphabet++;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "8";
                alphabet++;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "9";
                alphabet++;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "A";
                alphabet++;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "B";
                alphabet++;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "C";
                alphabet++;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "D";
                alphabet++;
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "E";
                alphabet++;
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (alphabet < 8 && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "F";
                alphabet++;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (op == 0 && tbxCalculator.Text != ""&&check!=tbxCalculator.Text)
            {
                tbxCalculator.Text += "+";
                op = 1;
                alphabet = 0;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (op == 0 && tbxCalculator.Text != "" && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "-";
                op = 1;
                alphabet = 0;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (op == 0 && tbxCalculator.Text != "" && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "*";
                op = 1;
                alphabet = 0;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (op == 0 && tbxCalculator.Text != "" && check != tbxCalculator.Text)
            {
                tbxCalculator.Text += "/";
                op = 1;
                alphabet = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxCalculator.Text = "";
            op = 0;
            alphabet = 0;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (check == tbxCalculator.Text)
            {
                tbxCalculator.Text = "";
                return;
            }
            String text = tbxCalculator.Text;
            char[] delim = {'+' , '-' , '*' , '/'};
            String[] texts = text.Split(delim);
            int number=0;
            int round=1;
            char oper = ' ';
            int result = 0; ;
            for (int i = 0; i < text.Length;i++ )
            {
                if (text[i]=='+')
                {
                    oper = '+';
                }
                else if (text[i] == '-')
                {
                    oper = '-';
                }
                else if (text[i] == '*')
                {
                    oper = '*';
                }
                else if (text[i] == '+')
                {
                    oper = '/';
                }
            }


            if (text.Length >= 2)
            {
                Boolean isBin = false;
                Boolean isHex = false;
                for (int i = 0; i < texts.Length; i++)
                {
                    for (int j = 0; j < texts[i].Length;j++ )
                    {
                        if (((texts[i].Length==8) && (texts[i][j] == '1' || texts[i][j] == '0')))
                        {
                            isBin = true;
                            isHex = false;
                        }
                        else
                        {
                            isHex = true;
                            isBin = false;
                        }
                    }
                    if (isBin)
                    {
                        number = int.Parse(FindBintoDec(2,(int.Parse(texts[i]))));
                        if (round == 1)
                        {
                            result = number;
                        }
                        else
                        {
                            if (oper == '+')
                            {
                                result += number;
                            }
                            else if (oper == '-')
                            {
                                result -= number;
                            }
                            else if (oper == '*')
                            {
                                result *= number;
                            }
                            else if (oper == '/')
                            {
                                result /= number;
                            }
                        }
                        round++;
                    }
                    else if (isHex)
                    {
                        number= int.Parse(FindHextoDec(16, texts[i]));
                        if (round == 1)
                        {
                            result = number;
                        }
                        else
                        {
                            if (oper == '+')
                            {
                                result += number;
                            }
                            else if (oper == '-')
                            {
                                result -= number;
                            }
                            else if (oper == '*')
                            {
                                result *= number;
                            }
                            else if (oper == '/')
                            {
                                result /= number;
                            }
                        }
                        round++;
                    }
                }
                tbxCalculator.Text = result.ToString();
                check = tbxCalculator.Text;
                exchange ex = new exchange();
                String textResult = ex.NumberToWords(int.Parse(tbxCalculator.Text));
                SpeechSynthesizer reader = new SpeechSynthesizer();
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync("The Result is    "+textResult);
            }
            else
            {
                MessageBox.Show("กรุณากรอกรูปแบบของ Expression ให้ถูกต้อง");
            }
            alphabet = 0;
            op = 0;
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage3")
            {
                StringBuilder message = new StringBuilder();
                message.Append("\nฟังก์ชั่นงาน\n");
                message.Append("- บวก, ลบ, คูณ, หาร เลขฐาน2-ฐาน16 และแสดงผลลัพธ์เป็นเลขฐาน 10\n");
                message.Append("- สามารถตรวจสอบการแปลงค่าของเลขฐานทุกฐานได้\n\n");
                message.Append("เงื่อนไข\n");
                message.Append("- สามารถคำนวนผลลัพธ์จาชุดตัวเลขเพียง 2 ชุดเท่านั้น\n");
                message.Append("- ในการกรอกชุดตัวเลขฐาน 2 จำเป็นต้องกรอกให้ครบทั้งหมด 8 หลัก ตัวอย่าง 00010001 เป็นต้น");
                lblHelp.Text=message.ToString();
            }
        }

    }
}
