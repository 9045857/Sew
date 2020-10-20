namespace CreateLoadRepFile
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
            this.COINFilesLabel = new System.Windows.Forms.Label();
            this.saveFileLabel = new System.Windows.Forms.Label();
            this.setFileButton = new System.Windows.Forms.Button();
            this.ETHUSDFilesLabel = new System.Windows.Forms.Label();
            this.textBoxCOIN = new System.Windows.Forms.TextBox();
            this.textBoxETHUSD = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.COINClearButton = new System.Windows.Forms.Button();
            this.ETHUSDClearButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.COINFolderAdd = new System.Windows.Forms.Button();
            this.ETHUSDFolderAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // COINFilesLabel
            // 
            this.COINFilesLabel.AutoSize = true;
            this.COINFilesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.COINFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.COINFilesLabel.Location = new System.Drawing.Point(12, 23);
            this.COINFilesLabel.Name = "COINFilesLabel";
            this.COINFilesLabel.Size = new System.Drawing.Size(45, 17);
            this.COINFilesLabel.TabIndex = 0;
            this.COINFilesLabel.Text = "COIN";
            this.COINFilesLabel.Click += new System.EventHandler(this.COINFilesLabel_Click);
            // 
            // saveFileLabel
            // 
            this.saveFileLabel.AutoSize = true;
            this.saveFileLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileLabel.Location = new System.Drawing.Point(3, 335);
            this.saveFileLabel.Name = "saveFileLabel";
            this.saveFileLabel.Size = new System.Drawing.Size(49, 17);
            this.saveFileLabel.TabIndex = 1;
            this.saveFileLabel.Text = "Файл";
            this.saveFileLabel.Click += new System.EventHandler(this.saveFileLabel_Click);
            // 
            // setFileButton
            // 
            this.setFileButton.Location = new System.Drawing.Point(6, 365);
            this.setFileButton.Name = "setFileButton";
            this.setFileButton.Size = new System.Drawing.Size(215, 31);
            this.setFileButton.TabIndex = 2;
            this.setFileButton.Text = "Сделать файл";
            this.setFileButton.UseVisualStyleBackColor = true;
            this.setFileButton.Click += new System.EventHandler(this.setFileButton_Click);
            // 
            // ETHUSDFilesLabel
            // 
            this.ETHUSDFilesLabel.AutoSize = true;
            this.ETHUSDFilesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ETHUSDFilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ETHUSDFilesLabel.Location = new System.Drawing.Point(467, 23);
            this.ETHUSDFilesLabel.Name = "ETHUSDFilesLabel";
            this.ETHUSDFilesLabel.Size = new System.Drawing.Size(71, 17);
            this.ETHUSDFilesLabel.TabIndex = 3;
            this.ETHUSDFilesLabel.Text = "ETHUSD";
            this.ETHUSDFilesLabel.Click += new System.EventHandler(this.ETHUSDFilesLabel_Click);
            // 
            // textBoxCOIN
            // 
            this.textBoxCOIN.Location = new System.Drawing.Point(6, 103);
            this.textBoxCOIN.Multiline = true;
            this.textBoxCOIN.Name = "textBoxCOIN";
            this.textBoxCOIN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCOIN.Size = new System.Drawing.Size(449, 214);
            this.textBoxCOIN.TabIndex = 4;
            this.textBoxCOIN.TextChanged += new System.EventHandler(this.textBoxCOIN_TextChanged);
            // 
            // textBoxETHUSD
            // 
            this.textBoxETHUSD.Location = new System.Drawing.Point(461, 103);
            this.textBoxETHUSD.Multiline = true;
            this.textBoxETHUSD.Name = "textBoxETHUSD";
            this.textBoxETHUSD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxETHUSD.Size = new System.Drawing.Size(434, 214);
            this.textBoxETHUSD.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // COINClearButton
            // 
            this.COINClearButton.Location = new System.Drawing.Point(306, 33);
            this.COINClearButton.Name = "COINClearButton";
            this.COINClearButton.Size = new System.Drawing.Size(35, 23);
            this.COINClearButton.TabIndex = 6;
            this.COINClearButton.Text = "Чистить";
            this.COINClearButton.UseVisualStyleBackColor = true;
            // 
            // ETHUSDClearButton
            // 
            this.ETHUSDClearButton.Location = new System.Drawing.Point(777, 33);
            this.ETHUSDClearButton.Name = "ETHUSDClearButton";
            this.ETHUSDClearButton.Size = new System.Drawing.Size(36, 23);
            this.ETHUSDClearButton.TabIndex = 7;
            this.ETHUSDClearButton.Text = "Чистить";
            this.ETHUSDClearButton.UseVisualStyleBackColor = true;
            // 
            // COINFolderAdd
            // 
            this.COINFolderAdd.Location = new System.Drawing.Point(8, 56);
            this.COINFolderAdd.Name = "COINFolderAdd";
            this.COINFolderAdd.Size = new System.Drawing.Size(104, 35);
            this.COINFolderAdd.TabIndex = 8;
            this.COINFolderAdd.Text = "+папку";
            this.COINFolderAdd.UseVisualStyleBackColor = true;
            this.COINFolderAdd.Click += new System.EventHandler(this.COINFolderAdd_Click);
            // 
            // ETHUSDFolderAdd
            // 
            this.ETHUSDFolderAdd.Location = new System.Drawing.Point(461, 56);
            this.ETHUSDFolderAdd.Name = "ETHUSDFolderAdd";
            this.ETHUSDFolderAdd.Size = new System.Drawing.Size(96, 35);
            this.ETHUSDFolderAdd.TabIndex = 9;
            this.ETHUSDFolderAdd.Text = "+папку";
            this.ETHUSDFolderAdd.UseVisualStyleBackColor = true;
            this.ETHUSDFolderAdd.Click += new System.EventHandler(this.ETHUSDFolderAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 419);
            this.Controls.Add(this.ETHUSDFolderAdd);
            this.Controls.Add(this.COINFolderAdd);
            this.Controls.Add(this.ETHUSDClearButton);
            this.Controls.Add(this.COINClearButton);
            this.Controls.Add(this.textBoxETHUSD);
            this.Controls.Add(this.textBoxCOIN);
            this.Controls.Add(this.ETHUSDFilesLabel);
            this.Controls.Add(this.setFileButton);
            this.Controls.Add(this.saveFileLabel);
            this.Controls.Add(this.COINFilesLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label COINFilesLabel;
        private System.Windows.Forms.Label saveFileLabel;
        private System.Windows.Forms.Button setFileButton;
        private System.Windows.Forms.Label ETHUSDFilesLabel;
        private System.Windows.Forms.TextBox textBoxCOIN;
        private System.Windows.Forms.TextBox textBoxETHUSD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button COINClearButton;
        private System.Windows.Forms.Button ETHUSDClearButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button COINFolderAdd;
        private System.Windows.Forms.Button ETHUSDFolderAdd;
    }
}

