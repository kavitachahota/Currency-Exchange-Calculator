using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsFinalProject
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }
        struct struct_Currency
        {
            public string country;
            public string currency;
            public string currency_value;
            public string currency_usa;
        }

        struct_Currency[] arr_currency = new struct_Currency[20];

        private void frmChange_Load(object sender, EventArgs e)
        {
            StreamReader myFile = new StreamReader("Rates.txt");
            Int16 i = 0;
            while (myFile.EndOfStream == false)
            {
                //adding data into array from file
                arr_currency[i].country = myFile.ReadLine();
                arr_currency[i].currency = myFile.ReadLine();
                arr_currency[i].currency_value = myFile.ReadLine();
                arr_currency[i].currency_usa = myFile.ReadLine();

                //adding country names into combo box
                cboCountries.Items.Add(arr_currency[i].country);

                // index increase
                i++;

                cboCountries.SelectedIndex = 0;
            }
            myFile.Close();
        }

        private void cboCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int16 selected_country = Convert.ToInt16(cboCountries.SelectedIndex);

            // rad btns

            radUStoFranc.Text = "From US Dollars to" + arr_currency[selected_country].currency;
            radFranctoUS.Text = arr_currency[selected_country].currency + "to US Dollars";

            // adding conversions values to labels

            lblConversion1.Text = "1 US Dollar = " + arr_currency[selected_country].currency_value + "" + arr_currency[selected_country].currency;

            lblConversion2.Text = "1" + arr_currency[selected_country].currency + " = " + arr_currency[selected_country].currency_usa + " US Dollar";

            //when index of combo box changed then disable the rad btns

            radFranctoUS.Checked = radUStoFranc.Checked = false;

        }

        private void radUStoFranc_CheckedChanged(object sender, EventArgs e)
        {
            lblValue.Text = "US Dollars";
            txtAmount.Text = lblResult.Text = "";
        }

        private void radFranctoUS_CheckedChanged(object sender, EventArgs e)
        {
            Int16 selected_counrty = Convert.ToInt16(cboCountries.SelectedIndex);
            lblValue.Text = arr_currency[selected_counrty].currency;
            txtAmount.Text = lblResult.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            radFranctoUS.Checked = radUStoFranc.Checked = false;
            txtAmount.Text = lblValue.Text = lblResult.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!(radUStoFranc.Checked || radFranctoUS.Checked))
            {
                MessageBox.Show("Please Choose conversion type !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAmount.Text == "")
            {
                MessageBox.Show("Please Enter Amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
            }
            else
            {



                Single amount = Convert.ToSingle(txtAmount.Text);
                Int16 selected_country = Convert.ToInt16(cboCountries.SelectedIndex);
                Single result = 0;



                // calculating converted values
                if (radUStoFranc.Checked)
                {
                    result = amount * Convert.ToSingle(arr_currency[selected_country].currency_value);
                }
                else if (radFranctoUS.Checked)
                {
                    result = amount * Convert.ToSingle(arr_currency[selected_country].currency_usa);
                }



                lblResult.Text = result.ToString() + " " + arr_currency[selected_country].currency;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit this program ?", "Closing Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
      





        