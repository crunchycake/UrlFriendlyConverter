namespace UrlFriendlyConverter
{
    partial class UrlFriendlyConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtInput = new TextBox();
            label2 = new Label();
            txtOutput = new TextBox();
            btnConvert = new Button();
            btnCopy = new Button();
            chkAutoConvert = new CheckBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 35);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Tekst do konwersji";
            label1.Click += label1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(42, 67);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(407, 23);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 111);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "Tekst po konwersji";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(42, 143);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(407, 23);
            txtOutput.TabIndex = 3;
            txtOutput.TextChanged += textBox2_TextChanged;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(42, 216);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Konwertuj";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += button1_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(125, 216);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 5;
            btnCopy.Text = "Kopiuj do schowka";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += button2_Click;
            // 
            // chkAutoConvert
            // 
            chkAutoConvert.AutoSize = true;
            chkAutoConvert.Location = new Point(42, 259);
            chkAutoConvert.Name = "chkAutoConvert";
            chkAutoConvert.Size = new Size(161, 19);
            chkAutoConvert.TabIndex = 6;
            chkAutoConvert.Text = "Konwertuj automatycznie";
            chkAutoConvert.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(206, 216);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 335);
            Controls.Add(btnClear);
            Controls.Add(chkAutoConvert);
            Controls.Add(btnCopy);
            Controls.Add(btnConvert);
            Controls.Add(txtOutput);
            Controls.Add(label2);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private Label label2;
        private TextBox txtOutput;
        private Button btnConvert;
        private Button btnCopy;
        private CheckBox chkAutoConvert;
        private Button btnClear;
    }
}
