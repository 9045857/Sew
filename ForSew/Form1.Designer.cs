namespace ForSew
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
            this.parsing = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.currentInstrument = new System.Windows.Forms.TextBox();
            this.currentStrategy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // parsing
            // 
            this.parsing.Location = new System.Drawing.Point(0, 111);
            this.parsing.Name = "parsing";
            this.parsing.Size = new System.Drawing.Size(94, 36);
            this.parsing.TabIndex = 0;
            this.parsing.Text = "Парсить";
            this.parsing.UseVisualStyleBackColor = true;
            this.parsing.Click += new System.EventHandler(this.parsing_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(676, 327);
            this.textBox1.TabIndex = 1;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileName.Location = new System.Drawing.Point(12, 9);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(45, 17);
            this.fileName.TabIndex = 2;
            this.fileName.Text = "Файл";
            this.fileName.Click += new System.EventHandler(this.fileName_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // currentInstrument
            // 
            this.currentInstrument.Location = new System.Drawing.Point(12, 45);
            this.currentInstrument.Name = "currentInstrument";
            this.currentInstrument.Size = new System.Drawing.Size(776, 22);
            this.currentInstrument.TabIndex = 5;
            // 
            // currentStrategy
            // 
            this.currentStrategy.Location = new System.Drawing.Point(12, 73);
            this.currentStrategy.Name = "currentStrategy";
            this.currentStrategy.Size = new System.Drawing.Size(776, 22);
            this.currentStrategy.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentStrategy);
            this.Controls.Add(this.currentInstrument);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.parsing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parsing;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox currentInstrument;
        private System.Windows.Forms.TextBox currentStrategy;
    }
}

