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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mode";
            // 
            // cmbMode
            // 
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
            this.cmbMode.Location = new System.Drawing.Point(63, 20);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(187, 21);
            this.cmbMode.TabIndex = 1;
            this.cmbMode.Text = "What Base You Need to Convert";
            this.cmbMode.TextChanged += new System.EventHandler(this.cmbMode_TextChanged);
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(26, 80);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(224, 20);
            this.tbxInput.TabIndex = 2;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            this.tbxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInput_KeyPress);
            // 
            // tbxResult
            // 
            this.tbxResult.Enabled = false;
            this.tbxResult.Location = new System.Drawing.Point(26, 191);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.Size = new System.Drawing.Size(224, 20);
            this.tbxResult.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(26, 117);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(224, 32);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result Number";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 236);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.cmbMode);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert-Base-Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.TextBox tbxResult;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

