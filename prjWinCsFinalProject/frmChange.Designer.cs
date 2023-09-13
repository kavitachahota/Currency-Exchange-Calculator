namespace prjWinCsFinalProject
{
    partial class frmChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radFranctoUS = new System.Windows.Forms.RadioButton();
            this.radUStoFranc = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblConversion1 = new System.Windows.Forms.Label();
            this.lblConversion2 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXCHANGE - OFFICE";
            // 
            // cboCountries
            // 
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Location = new System.Drawing.Point(16, 95);
            this.cboCountries.Margin = new System.Windows.Forms.Padding(4);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(215, 24);
            this.cboCountries.TabIndex = 1;
            this.cboCountries.Text = "Select Country";
            this.cboCountries.SelectedIndexChanged += new System.EventHandler(this.cboCountries_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radFranctoUS);
            this.groupBox1.Controls.Add(this.radUStoFranc);
            this.groupBox1.Location = new System.Drawing.Point(19, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(283, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "type of conversion";
            // 
            // radFranctoUS
            // 
            this.radFranctoUS.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radFranctoUS.AutoSize = true;
            this.radFranctoUS.Location = new System.Drawing.Point(8, 50);
            this.radFranctoUS.Margin = new System.Windows.Forms.Padding(4);
            this.radFranctoUS.Name = "radFranctoUS";
            this.radFranctoUS.Size = new System.Drawing.Size(141, 20);
            this.radFranctoUS.TabIndex = 1;
            this.radFranctoUS.TabStop = true;
            this.radFranctoUS.Text = "Franc to USDollars";
            this.radFranctoUS.UseVisualStyleBackColor = true;
            this.radFranctoUS.CheckedChanged += new System.EventHandler(this.radFranctoUS_CheckedChanged);
            // 
            // radUStoFranc
            // 
            this.radUStoFranc.AutoSize = true;
            this.radUStoFranc.Location = new System.Drawing.Point(8, 23);
            this.radUStoFranc.Margin = new System.Windows.Forms.Padding(4);
            this.radUStoFranc.Name = "radUStoFranc";
            this.radUStoFranc.Size = new System.Drawing.Size(170, 20);
            this.radUStoFranc.TabIndex = 0;
            this.radUStoFranc.TabStop = true;
            this.radUStoFranc.Text = "from USDollars to Franc";
            this.radUStoFranc.UseVisualStyleBackColor = true;
            this.radUStoFranc.CheckedChanged += new System.EventHandler(this.radUStoFranc_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(21, 345);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(209, 33);
            this.lblResult.TabIndex = 3;
            // 
            // lblConversion1
            // 
            this.lblConversion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConversion1.Location = new System.Drawing.Point(288, 110);
            this.lblConversion1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConversion1.Name = "lblConversion1";
            this.lblConversion1.Size = new System.Drawing.Size(290, 34);
            this.lblConversion1.TabIndex = 4;
            this.lblConversion1.Text = "\r\n\r\n";
            // 
            // lblConversion2
            // 
            this.lblConversion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConversion2.Location = new System.Drawing.Point(288, 156);
            this.lblConversion2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConversion2.Name = "lblConversion2";
            this.lblConversion2.Size = new System.Drawing.Size(290, 34);
            this.lblConversion2.TabIndex = 5;
            // 
            // lblValue
            // 
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValue.Location = new System.Drawing.Point(324, 233);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(109, 25);
            this.lblValue.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(325, 267);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(105, 22);
            this.txtAmount.TabIndex = 7;
//            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // btnConvert
            // 
            this.btnConvert.ForeColor = System.Drawing.Color.Black;
            this.btnConvert.Location = new System.Drawing.Point(509, 236);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 31);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(509, 274);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Wipe off";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(509, 310);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(623, 416);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblConversion2);
            this.Controls.Add(this.lblConversion1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboCountries);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChange";
            this.Text = "$ International exchange office";
            this.Load += new System.EventHandler(this.frmChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCountries;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radFranctoUS;
        private System.Windows.Forms.RadioButton radUStoFranc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblConversion1;
        private System.Windows.Forms.Label lblConversion2;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}