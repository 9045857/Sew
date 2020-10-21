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
            this.fileName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // parsing
            // 
            this.parsing.Location = new System.Drawing.Point(15, 252);
            this.parsing.Name = "parsing";
            this.parsing.Size = new System.Drawing.Size(123, 36);
            this.parsing.TabIndex = 0;
            this.parsing.Text = "Парсить";
            this.parsing.UseVisualStyleBackColor = true;
            this.parsing.Click += new System.EventHandler(this.parsing_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileName.Location = new System.Drawing.Point(12, 38);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(54, 17);
            this.fileName.TabIndex = 2;
            this.fileName.Text = "Файл:";
            this.fileName.Click += new System.EventHandler(this.fileName_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileLabel
            // 
            this.saveFileLabel.AutoSize = true;
            this.saveFileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileLabel.Location = new System.Drawing.Point(12, 198);
            this.saveFileLabel.Name = "saveFileLabel";
            this.saveFileLabel.Size = new System.Drawing.Size(54, 17);
            this.saveFileLabel.TabIndex = 3;
            this.saveFileLabel.Text = "Файл:";
            this.saveFileLabel.Click += new System.EventHandler(this.saveFileLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveFileLabel);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.parsing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parsing;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label saveFileLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

