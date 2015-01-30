namespace ConvertBaseNumber
{
    partial class FormMain
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
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.tbxCalculator = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mode";
            // 
            // cmbMode
            // 
            this.cmbMode.BackColor = System.Drawing.SystemColors.Info;
            this.cmbMode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "Base 2 --> Base 8",
            "Base 2 --> Base 10",
            "Base 2 --> Base 16",
            "Base 8 --> Base 2",
            "Base 8 --> Base 10",
            "Base 8 --> Base 16",
            "Base 10 --> Base 2",
            "Base 10 --> Base 8",
            "Base 10 --> Base 16",
            "Base 16 --> Base 2",
            "Base 16 --> Base 8",
            "Base 16 --> Base 10"});
            this.cmbMode.Location = new System.Drawing.Point(135, 53);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(187, 21);
            this.cmbMode.TabIndex = 1;
            this.cmbMode.TabStop = false;
            this.cmbMode.Text = "What Base You Need to Convert";
            this.cmbMode.TextChanged += new System.EventHandler(this.cmbMode_TextChanged);
            // 
            // tbxInput
            // 
            this.tbxInput.BackColor = System.Drawing.SystemColors.Info;
            this.tbxInput.Enabled = false;
            this.tbxInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxInput.Location = new System.Drawing.Point(135, 107);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(187, 30);
            this.tbxInput.TabIndex = 2;
            this.tbxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            this.tbxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // tbxResult
            // 
            this.tbxResult.BackColor = System.Drawing.SystemColors.Info;
            this.tbxResult.Enabled = false;
            this.tbxResult.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxResult.Location = new System.Drawing.Point(24, 286);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(298, 48);
            this.tbxResult.TabIndex = 3;
            this.tbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConvert.Enabled = false;
            this.btnConvert.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.Info;
            this.btnConvert.Location = new System.Drawing.Point(24, 173);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(298, 42);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(21, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result Number";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 448);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Controls.Add(this.btnMinus);
            this.tabPage1.Controls.Add(this.btnDivide);
            this.tabPage1.Controls.Add(this.btnMultiply);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnEnter);
            this.tabPage1.Controls.Add(this.btn0);
            this.tabPage1.Controls.Add(this.btnF);
            this.tabPage1.Controls.Add(this.btnE);
            this.tabPage1.Controls.Add(this.btnD);
            this.tabPage1.Controls.Add(this.btnC);
            this.tabPage1.Controls.Add(this.btnB);
            this.tabPage1.Controls.Add(this.btnA);
            this.tabPage1.Controls.Add(this.btn3);
            this.tabPage1.Controls.Add(this.btn2);
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.btn6);
            this.tabPage1.Controls.Add(this.btn5);
            this.tabPage1.Controls.Add(this.btn4);
            this.tabPage1.Controls.Add(this.btn9);
            this.tabPage1.Controls.Add(this.btn8);
            this.tabPage1.Controls.Add(this.btn7);
            this.tabPage1.Controls.Add(this.tbxCalculator);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(348, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculator";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.DimGray;
            this.btnPlus.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPlus.Location = new System.Drawing.Point(26, 78);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(69, 63);
            this.btnPlus.TabIndex = 22;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.DimGray;
            this.btnMinus.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMinus.Location = new System.Drawing.Point(26, 147);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(69, 63);
            this.btnMinus.TabIndex = 21;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.DimGray;
            this.btnDivide.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDivide.Location = new System.Drawing.Point(26, 285);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(69, 63);
            this.btnDivide.TabIndex = 20;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.DimGray;
            this.btnMultiply.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMultiply.Location = new System.Drawing.Point(26, 216);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(69, 63);
            this.btnMultiply.TabIndex = 19;
            this.btnMultiply.Text = "X";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Info;
            this.btnClear.Location = new System.Drawing.Point(176, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 63);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DimGray;
            this.btnEnter.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEnter.Location = new System.Drawing.Point(251, 285);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(69, 63);
            this.btnEnter.TabIndex = 17;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DimGray;
            this.btn0.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.Info;
            this.btn0.Location = new System.Drawing.Point(101, 285);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(69, 63);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.DimGray;
            this.btnF.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.ForeColor = System.Drawing.SystemColors.Info;
            this.btnF.Location = new System.Drawing.Point(266, 362);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(39, 42);
            this.btnF.TabIndex = 15;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.DimGray;
            this.btnE.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.SystemColors.Info;
            this.btnE.Location = new System.Drawing.Point(221, 362);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(39, 42);
            this.btnE.TabIndex = 14;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.DimGray;
            this.btnD.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.SystemColors.Info;
            this.btnD.Location = new System.Drawing.Point(176, 362);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(39, 42);
            this.btnD.TabIndex = 13;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.DimGray;
            this.btnC.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.SystemColors.Info;
            this.btnC.Location = new System.Drawing.Point(131, 362);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(39, 42);
            this.btnC.TabIndex = 12;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.DimGray;
            this.btnB.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.SystemColors.Info;
            this.btnB.Location = new System.Drawing.Point(86, 362);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(39, 42);
            this.btnB.TabIndex = 11;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.DimGray;
            this.btnA.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.SystemColors.Info;
            this.btnA.Location = new System.Drawing.Point(41, 362);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(39, 42);
            this.btnA.TabIndex = 10;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DimGray;
            this.btn3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.Info;
            this.btn3.Location = new System.Drawing.Point(251, 216);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(69, 63);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DimGray;
            this.btn2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Info;
            this.btn2.Location = new System.Drawing.Point(176, 216);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(69, 63);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DimGray;
            this.btn1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.Info;
            this.btn1.Location = new System.Drawing.Point(101, 216);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(69, 63);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DimGray;
            this.btn6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.Info;
            this.btn6.Location = new System.Drawing.Point(251, 147);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(69, 63);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DimGray;
            this.btn5.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.Info;
            this.btn5.Location = new System.Drawing.Point(176, 147);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(69, 63);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DimGray;
            this.btn4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.Info;
            this.btn4.Location = new System.Drawing.Point(101, 147);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(69, 63);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DimGray;
            this.btn9.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.Info;
            this.btn9.Location = new System.Drawing.Point(251, 78);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(69, 63);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DimGray;
            this.btn8.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.Info;
            this.btn8.Location = new System.Drawing.Point(176, 78);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(69, 63);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DimGray;
            this.btn7.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.Info;
            this.btn7.Location = new System.Drawing.Point(101, 78);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(69, 63);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // tbxCalculator
            // 
            this.tbxCalculator.BackColor = System.Drawing.SystemColors.Info;
            this.tbxCalculator.Enabled = false;
            this.tbxCalculator.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCalculator.Location = new System.Drawing.Point(20, 23);
            this.tbxCalculator.Multiline = true;
            this.tbxCalculator.Name = "tbxCalculator";
            this.tbxCalculator.Size = new System.Drawing.Size(307, 38);
            this.tbxCalculator.TabIndex = 0;
            this.tbxCalculator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnConvert);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbxInput);
            this.tabPage2.Controls.Add(this.cmbMode);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbxResult);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(348, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblHelp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(348, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(12, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 37);
            this.label7.TabIndex = 4;
            this.label7.Text = "โปรเจ็ควิชา Compiler-Constructor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(12, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 37);
            this.label6.TabIndex = 3;
            this.label6.Text = "นายวิศรุต   ภูวนันตานนท์ รหัสนักศึกษา 1530702057";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "จัดทำโดย";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(5, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Base 2 - Base 16 Calculator";
            // 
            // lblHelp
            // 
            this.lblHelp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHelp.Location = new System.Drawing.Point(9, 46);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(333, 356);
            this.lblHelp.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 449);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator 2-16";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox tbxCalculator;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

