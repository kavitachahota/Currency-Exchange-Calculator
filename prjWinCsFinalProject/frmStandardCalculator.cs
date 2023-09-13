﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prjWinCsFinalProject
{
        public partial class frmStandardCalculator : Form
        {
            public frmStandardCalculator()
            {
           
                InitializeComponent();
            }

            Single num1;
            string operation_name;
            //int percentage;
            int total;
            int complete;
            //string sign;

 


            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                int index = lblDisplayfirst.Text.Length;
                index--;
                lblDisplayfirst.Text = lblDisplayfirst.Text.Remove(index);
                if (lblDisplayfirst.Text == "")
                {
                    lblDisplayfirst.Text = "0";
                }
                else
                {
                    lblDisplaySecond.Text = "0";
                }

            }

            private void frmStandardCalculator_Load(object sender, EventArgs e)
            {

            }

            private void lblDisplayfirst_Click(object sender, EventArgs e)
            {

            }

            private void btnMemoryClear_Click(object sender, EventArgs e)
            {
                btnMemoryRecall.Enabled = true;
                btnMemoryStore.Enabled = true;

            }

            private void btnMemoryAdd_Click(object sender, EventArgs e)
            {
                btnMemoryRecall.Enabled = true;
                btnMemoryClear.Enabled = true;
            }

            private void btnMemorySubtract_Click(object sender, EventArgs e)
            {
                btnMemoryRecall.Enabled = true;
                btnMemoryStore.Enabled = true;
            }

            private void btnPercentage_Click(object sender, EventArgs e)
            {
       
                int percentage = (int)Math.Round((double)(100 * complete) / total);
            }

            private void btnCE_Click(object sender, EventArgs e)
            {
                lblDisplayfirst.Text = "0";
                lblDisplaySecond.Visible = false;

            }

            private void btnC_Click(object sender, EventArgs e)
            {
                lblDisplaySecond.Text = "";
                lblDisplayfirst.Text = "0";
            }

            private void btnOne_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "1";

                }
                else
                {
                    lblDisplayfirst.Text += "1";
                }

            }

            private void btnTwo_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "2";
                }
                else
                {
                    lblDisplayfirst.Text += "2";
                }
            }

            private void btnThree_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "3";
                }
                else
                {
                    lblDisplayfirst.Text += "3";
                }
            }

            private void btnFour_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "4";

                }
                else
                {
                    lblDisplayfirst.Text += "4";
                }
            }

            private void btnFive_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "5";

                }
                else
                {
                    lblDisplayfirst.Text += "5";
                }


            }

            private void btnSix_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "6";

                }
                else
                {
                    lblDisplayfirst.Text += "6";
                }
            }

            private void btnSeven_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "7";

                }
                else
                {
                    lblDisplayfirst.Text += "7";
                }
            }

            private void btnEight_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "8";

                }
                else
                {
                    lblDisplayfirst.Text += "8";
                }
            }

            private void btnNine_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "9";

                }
                else
                {
                    lblDisplayfirst.Text += "9";
                }
            }

            private void btnZero_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "0";

                }
                else
                {
                    lblDisplayfirst.Text += "0";
                }
            }

            private void btnMemoryStore_Click(object sender, EventArgs e)
            {
                btnMemoryRecall.Enabled = true;
                btnMemoryClear.Enabled = true;
            }

            private void btnDecimal_Click(object sender, EventArgs e)
            {
                if (!(lblDisplayfirst.Text.Contains(".")))
                {
                    lblDisplayfirst.Text += ".";
                }
            }

            private void btnEqual_Click(object sender, EventArgs e)
            {
                Single num2 = Convert.ToSingle(lblDisplayfirst.Text);

                if (operation_name == "+")
                {
                    Single result = num1 + num2;
                    lblDisplayfirst.Text = Convert.ToString(result);
                    num2 = 0;
                }
                else if (operation_name == "-")
                {
                    Single result = num1 - num2;
                    lblDisplayfirst.Text = Convert.ToString(result);
                    num2 = 0;
                }
                else if (operation_name == "*")
                {
                    Single result = num1 * num2;
                    lblDisplayfirst.Text = Convert.ToString(result);
                    num2 = 0;
                }
                if (operation_name == "/")
                {
                    if (num2 == 0)
                    {
                        lblDisplayfirst.Text = "Cannot divide by 0";
                    }
                    else
                    {
                        Single result = num1 / num2;
                        lblDisplayfirst.Text = Convert.ToString(result);
                        num2 = 0;
                    }
                }
            }


            private void btnAdditionOrSubtraction_Click(object sender, EventArgs e)
            {
                num1 = Convert.ToSingle(lblDisplayfirst.Text);

                if (num1 < 0)
                {
                    lblDisplayfirst.Text = Convert.ToString(Math.Abs(num1));
                }
                else if (num1 > 0)
                {
                    lblDisplayfirst.Text = "-" + num1;
                }
            }

            private void btnAddition_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplaySecond.Text = "0";
                }
                else
                {
                    lblDisplaySecond.Visible = true;
                    num1 = Convert.ToSingle(lblDisplayfirst.Text);
                    operation_name = "+";
                    lblDisplaySecond.Text += lblDisplayfirst.Text + " + ";
                    lblDisplayfirst.Text = "0";
                }
            }

            private void btnSubtraction_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "0";
                }
                else
                {
                    lblDisplaySecond.Visible = true;
                    num1 = Convert.ToSingle(lblDisplayfirst.Text);
                    operation_name = "-";
                    lblDisplaySecond.Text += lblDisplayfirst.Text + " - ";
                    lblDisplayfirst.Text = "0";
                }
            }

            private void btnDivision_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "0";
                }
                else
                {
                    lblDisplaySecond.Visible = true;
                    num1 = Convert.ToSingle(lblDisplayfirst.Text);
                    operation_name = "/";
                    lblDisplaySecond.Text += lblDisplayfirst.Text + " ÷ ";
                    lblDisplayfirst.Text = "0";
                }

            }

            private void btnMultiplication_Click(object sender, EventArgs e)
            {
                if (lblDisplayfirst.Text == "0")
                {
                    lblDisplayfirst.Text = "0";
                }
                else
                {
                    lblDisplaySecond.Visible = true;
                    num1 = Convert.ToSingle(lblDisplayfirst.Text);
                    operation_name = "*";
                    lblDisplaySecond.Text += lblDisplayfirst.Text + " * ";
                    lblDisplayfirst.Text = "0";
                }
            }

            private void btnSquare_Click(object sender, EventArgs e)
            {
                lblDisplaySecond.Visible = true;
                num1 = Convert.ToSingle(lblDisplayfirst.Text);
                Single result = num1 * num1;
                lblDisplayfirst.Text = Convert.ToString(result);
                lblDisplaySecond.Text = "sqr( " + num1 + " )";

            }

            private void btnMemoryRecall_Click(object sender, EventArgs e)
            {
                lblDisplayfirst.Text = btnMemoryRecall.ToString();
            }

            private void btnSquareRoot_Click(object sender, EventArgs e)
            {
                lblDisplaySecond.Visible = true;
                num1 = Convert.ToSingle(lblDisplayfirst.Text);
                Single result = Convert.ToSingle(Math.Sqrt(num1));
                lblDisplayfirst.Text = Convert.ToString(result);
                lblDisplaySecond.Text = "√(" + num1 + ")";
            }

            private void btnFraction_Click(object sender, EventArgs e)
            {
                num1 = Convert.ToSingle(lblDisplayfirst.Text);

                if (num1 == 0)
                {
                    lblDisplayfirst.Text = "Not divisible by 0";
                }
                else
                {
                    lblDisplaySecond.Visible = true;
                    lblDisplayfirst.Text = Convert.ToString(1 / num1);
                }
                lblDisplaySecond.Text = "1/(" + num1 + ")";
            }
        }
        }


