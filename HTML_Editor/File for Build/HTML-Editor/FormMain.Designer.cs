namespace HTML_Editor
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
            this.tbxEditor = new System.Windows.Forms.TextBox();
            this.webPage = new System.Windows.Forms.WebBrowser();
            this.btnRun = new System.Windows.Forms.Button();
            this.cmbExampleCode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxEditor
            // 
            this.tbxEditor.Location = new System.Drawing.Point(12, 12);
            this.tbxEditor.Multiline = true;
            this.tbxEditor.Name = "tbxEditor";
            this.tbxEditor.Size = new System.Drawing.Size(300, 400);
            this.tbxEditor.TabIndex = 0;
            this.tbxEditor.Click += new System.EventHandler(this.tbxEditor_Click);
            // 
            // webPage
            // 
            this.webPage.Location = new System.Drawing.Point(318, 12);
            this.webPage.MinimumSize = new System.Drawing.Size(20, 20);
            this.webPage.Name = "webPage";
            this.webPage.Size = new System.Drawing.Size(300, 400);
            this.webPage.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(230, 422);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(388, 34);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cmbExampleCode
            // 
            this.cmbExampleCode.FormattingEnabled = true;
            this.cmbExampleCode.Items.AddRange(new object[] {
            "Try Some Code",
            "Example-Button_Alert",
            "Example-Text_and_Table",
            "Example-Css_BackgroundColor"});
            this.cmbExampleCode.Location = new System.Drawing.Point(12, 428);
            this.cmbExampleCode.Name = "cmbExampleCode";
            this.cmbExampleCode.Size = new System.Drawing.Size(212, 21);
            this.cmbExampleCode.TabIndex = 3;
            this.cmbExampleCode.Text = "Choose Example HTML Code";
            this.cmbExampleCode.TextChanged += new System.EventHandler(this.cmbExampleCode_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(631, 464);
            this.Controls.Add(this.cmbExampleCode);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.webPage);
            this.Controls.Add(this.tbxEditor);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML-Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxEditor;
        private System.Windows.Forms.WebBrowser webPage;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cmbExampleCode;
    }
}

