namespace RandomUniqueNumberGenerator
{
    partial class Form1
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
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonGenerateUnique = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.buttonCopyAll = new System.Windows.Forms.Button();
            this.textBoxHowMany = new System.Windows.Forms.TextBox();
            this.labelHowMany = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(94, 21);
            this.textBoxFrom.MaxLength = 6;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(148, 20);
            this.textBoxFrom.TabIndex = 0;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(94, 47);
            this.textBoxTo.MaxLength = 6;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(148, 20);
            this.textBoxTo.TabIndex = 1;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // listBoxResult
            // 
            this.listBoxResult.AllowDrop = true;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(31, 155);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxResult.Size = new System.Drawing.Size(223, 108);
            this.listBoxResult.TabIndex = 4;
            // 
            // buttonGenerateUnique
            // 
            this.buttonGenerateUnique.Location = new System.Drawing.Point(31, 116);
            this.buttonGenerateUnique.Name = "buttonGenerateUnique";
            this.buttonGenerateUnique.Size = new System.Drawing.Size(223, 24);
            this.buttonGenerateUnique.TabIndex = 3;
            this.buttonGenerateUnique.Text = "Generate Unique IDs";
            this.buttonGenerateUnique.UseVisualStyleBackColor = true;
            this.buttonGenerateUnique.Click += new System.EventHandler(this.buttonGenerateUnique_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(31, 298);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(223, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset All";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // buttonCopyAll
            // 
            this.buttonCopyAll.Location = new System.Drawing.Point(31, 269);
            this.buttonCopyAll.Name = "buttonCopyAll";
            this.buttonCopyAll.Size = new System.Drawing.Size(223, 23);
            this.buttonCopyAll.TabIndex = 5;
            this.buttonCopyAll.Text = "Copy All";
            this.buttonCopyAll.UseVisualStyleBackColor = true;
            this.buttonCopyAll.Click += new System.EventHandler(this.buttonCopyAll_Click);
            // 
            // textBoxHowMany
            // 
            this.textBoxHowMany.Location = new System.Drawing.Point(94, 73);
            this.textBoxHowMany.MaxLength = 4;
            this.textBoxHowMany.Name = "textBoxHowMany";
            this.textBoxHowMany.Size = new System.Drawing.Size(148, 20);
            this.textBoxHowMany.TabIndex = 2;
            // 
            // labelHowMany
            // 
            this.labelHowMany.AutoSize = true;
            this.labelHowMany.Location = new System.Drawing.Point(28, 73);
            this.labelHowMany.Name = "labelHowMany";
            this.labelHowMany.Size = new System.Drawing.Size(64, 13);
            this.labelHowMany.TabIndex = 12;
            this.labelHowMany.Text = "How Many?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "(Optional)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHowMany);
            this.Controls.Add(this.textBoxHowMany);
            this.Controls.Add(this.buttonCopyAll);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.buttonGenerateUnique);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Name = "Form1";
            this.Text = "ID Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonGenerateUnique;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button buttonCopyAll;
        private System.Windows.Forms.TextBox textBoxHowMany;
        private System.Windows.Forms.Label labelHowMany;
        private System.Windows.Forms.Label label3;
    }
}

