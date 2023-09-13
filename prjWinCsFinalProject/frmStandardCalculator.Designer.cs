namespace prjWinCsFinalProject
{
    partial class frmStandardCalculator
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
            this.lblDisplaySecond = new System.Windows.Forms.Label();
            this.lblDisplayfirst = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMemoryStore = new System.Windows.Forms.Button();
            this.btnMemorySubtract = new System.Windows.Forms.Button();
            this.btnMemoryAdd = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.btnMemoryClear = new System.Windows.Forms.Button();
            this.btnAdditionOrSubtraction = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnFraction = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard";
            // 
            // lblDisplaySecond
            // 
            this.lblDisplaySecond.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplaySecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplaySecond.Location = new System.Drawing.Point(20, 82);
            this.lblDisplaySecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplaySecond.Name = "lblDisplaySecond";
            this.lblDisplaySecond.Size = new System.Drawing.Size(520, 36);
            this.lblDisplaySecond.TabIndex = 1;
            this.lblDisplaySecond.Text = "0";
            this.lblDisplaySecond.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDisplayfirst
            // 
            this.lblDisplayfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayfirst.Location = new System.Drawing.Point(28, 135);
            this.lblDisplayfirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayfirst.Name = "lblDisplayfirst";
            this.lblDisplayfirst.Size = new System.Drawing.Size(512, 36);
            this.lblDisplayfirst.TabIndex = 2;
            this.lblDisplayfirst.Text = "0";
            this.lblDisplayfirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplayfirst.Click += new System.EventHandler(this.lblDisplayfirst_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMemoryStore);
            this.panel1.Controls.Add(this.btnMemorySubtract);
            this.panel1.Controls.Add(this.btnMemoryAdd);
            this.panel1.Controls.Add(this.btnSquareRoot);
            this.panel1.Controls.Add(this.btnMemoryRecall);
            this.panel1.Controls.Add(this.btnMemoryClear);
            this.panel1.Controls.Add(this.btnAdditionOrSubtraction);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnDecimal);
            this.panel1.Controls.Add(this.btnEqual);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnThree);
            this.panel1.Controls.Add(this.btnAddition);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnSix);
            this.panel1.Controls.Add(this.btnSubtraction);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.btnMultiplication);
            this.panel1.Controls.Add(this.btnNine);
            this.panel1.Controls.Add(this.btnEight);
            this.panel1.Controls.Add(this.btnSeven);
            this.panel1.Controls.Add(this.btnDivision);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnFraction);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btnCE);
            this.panel1.Controls.Add(this.btnPercentage);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 194);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 422);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMemoryStore
            // 
            this.btnMemoryStore.Location = new System.Drawing.Point(347, 49);
            this.btnMemoryStore.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemoryStore.Name = "btnMemoryStore";
            this.btnMemoryStore.Size = new System.Drawing.Size(75, 36);
            this.btnMemoryStore.TabIndex = 28;
            this.btnMemoryStore.Text = "MS";
            this.btnMemoryStore.UseVisualStyleBackColor = true;
            this.btnMemoryStore.Click += new System.EventHandler(this.btnMemoryStore_Click);
            // 
            // btnMemorySubtract
            // 
            this.btnMemorySubtract.Location = new System.Drawing.Point(264, 49);
            this.btnMemorySubtract.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemorySubtract.Name = "btnMemorySubtract";
            this.btnMemorySubtract.Size = new System.Drawing.Size(75, 36);
            this.btnMemorySubtract.TabIndex = 27;
            this.btnMemorySubtract.Text = "M-";
            this.btnMemorySubtract.UseVisualStyleBackColor = true;
            this.btnMemorySubtract.Click += new System.EventHandler(this.btnMemorySubtract_Click);
            // 
            // btnMemoryAdd
            // 
            this.btnMemoryAdd.Location = new System.Drawing.Point(181, 49);
            this.btnMemoryAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemoryAdd.Name = "btnMemoryAdd";
            this.btnMemoryAdd.Size = new System.Drawing.Size(75, 36);
            this.btnMemoryAdd.TabIndex = 26;
            this.btnMemoryAdd.Text = "M+";
            this.btnMemoryAdd.UseVisualStyleBackColor = true;
            this.btnMemoryAdd.Click += new System.EventHandler(this.btnMemoryAdd_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSquareRoot.Location = new System.Drawing.Point(268, 144);
            this.btnSquareRoot.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(117, 42);
            this.btnSquareRoot.TabIndex = 6;
            this.btnSquareRoot.Text = "²√𝑥";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.Location = new System.Drawing.Point(99, 49);
            this.btnMemoryRecall.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(75, 36);
            this.btnMemoryRecall.TabIndex = 25;
            this.btnMemoryRecall.Text = "MR";
            this.btnMemoryRecall.UseVisualStyleBackColor = true;
            this.btnMemoryRecall.Click += new System.EventHandler(this.btnMemoryRecall_Click);
            // 
            // btnMemoryClear
            // 
            this.btnMemoryClear.Location = new System.Drawing.Point(16, 49);
            this.btnMemoryClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemoryClear.Name = "btnMemoryClear";
            this.btnMemoryClear.Size = new System.Drawing.Size(75, 36);
            this.btnMemoryClear.TabIndex = 24;
            this.btnMemoryClear.Text = "MC";
            this.btnMemoryClear.UseVisualStyleBackColor = true;
            this.btnMemoryClear.Click += new System.EventHandler(this.btnMemoryClear_Click);
            // 
            // btnAdditionOrSubtraction
            // 
            this.btnAdditionOrSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdditionOrSubtraction.Location = new System.Drawing.Point(17, 338);
            this.btnAdditionOrSubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdditionOrSubtraction.Name = "btnAdditionOrSubtraction";
            this.btnAdditionOrSubtraction.Size = new System.Drawing.Size(117, 42);
            this.btnAdditionOrSubtraction.TabIndex = 23;
            this.btnAdditionOrSubtraction.Text = "+/-";
            this.btnAdditionOrSubtraction.UseVisualStyleBackColor = false;
            this.btnAdditionOrSubtraction.Click += new System.EventHandler(this.btnAdditionOrSubtraction_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnZero.Location = new System.Drawing.Point(143, 338);
            this.btnZero.Margin = new System.Windows.Forms.Padding(4);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(117, 42);
            this.btnZero.TabIndex = 22;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDecimal.Location = new System.Drawing.Point(268, 338);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(117, 42);
            this.btnDecimal.TabIndex = 21;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEqual.Location = new System.Drawing.Point(393, 338);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(117, 42);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOne.Location = new System.Drawing.Point(17, 289);
            this.btnOne.Margin = new System.Windows.Forms.Padding(4);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(117, 42);
            this.btnOne.TabIndex = 19;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTwo.Location = new System.Drawing.Point(143, 289);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(117, 42);
            this.btnTwo.TabIndex = 18;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThree.Location = new System.Drawing.Point(268, 289);
            this.btnThree.Margin = new System.Windows.Forms.Padding(4);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(117, 42);
            this.btnThree.TabIndex = 17;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddition.Location = new System.Drawing.Point(393, 289);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(117, 42);
            this.btnAddition.TabIndex = 16;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFive.Location = new System.Drawing.Point(143, 240);
            this.btnFive.Margin = new System.Windows.Forms.Padding(4);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(117, 42);
            this.btnFive.TabIndex = 15;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSix.Location = new System.Drawing.Point(268, 240);
            this.btnSix.Margin = new System.Windows.Forms.Padding(4);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(117, 42);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSubtraction.Location = new System.Drawing.Point(393, 240);
            this.btnSubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(117, 42);
            this.btnSubtraction.TabIndex = 13;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFour.Location = new System.Drawing.Point(16, 240);
            this.btnFour.Margin = new System.Windows.Forms.Padding(4);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(117, 42);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMultiplication.Location = new System.Drawing.Point(393, 191);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(117, 42);
            this.btnMultiplication.TabIndex = 11;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNine.Location = new System.Drawing.Point(268, 191);
            this.btnNine.Margin = new System.Windows.Forms.Padding(4);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(117, 42);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEight.Location = new System.Drawing.Point(143, 191);
            this.btnEight.Margin = new System.Windows.Forms.Padding(4);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(117, 42);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSeven.Location = new System.Drawing.Point(16, 191);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(117, 42);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDivision.Location = new System.Drawing.Point(393, 144);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(117, 42);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSquare.Location = new System.Drawing.Point(143, 142);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(117, 42);
            this.btnSquare.TabIndex = 5;
            this.btnSquare.Text = "𝑥²";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnFraction
            // 
            this.btnFraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFraction.Location = new System.Drawing.Point(16, 142);
            this.btnFraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnFraction.Name = "btnFraction";
            this.btnFraction.Size = new System.Drawing.Size(117, 42);
            this.btnFraction.TabIndex = 4;
            this.btnFraction.Text = "1/𝑥";
            this.btnFraction.UseVisualStyleBackColor = false;
            this.btnFraction.Click += new System.EventHandler(this.btnFraction_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Location = new System.Drawing.Point(393, 95);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnC.Location = new System.Drawing.Point(268, 95);
            this.btnC.Margin = new System.Windows.Forms.Padding(4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(117, 42);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCE.Location = new System.Drawing.Point(143, 95);
            this.btnCE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(117, 42);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPercentage.Location = new System.Drawing.Point(17, 92);
            this.btnPercentage.Margin = new System.Windows.Forms.Padding(4);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(117, 42);
            this.btnPercentage.TabIndex = 0;
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // frmStandardCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(543, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDisplayfirst);
            this.Controls.Add(this.lblDisplaySecond);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStandardCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmStandardCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplaySecond;
        private System.Windows.Forms.Label lblDisplayfirst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdditionOrSubtraction;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnFraction;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnMemoryClear;
        private System.Windows.Forms.Button btnMemoryStore;
        private System.Windows.Forms.Button btnMemorySubtract;
        private System.Windows.Forms.Button btnMemoryAdd;
        private System.Windows.Forms.Button btnMemoryRecall;
    }
}