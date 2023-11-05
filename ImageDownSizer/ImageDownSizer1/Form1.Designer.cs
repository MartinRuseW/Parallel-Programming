namespace ImageDownSizer1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.downScallingFactor = new System.Windows.Forms.TextBox();
            this.pictureBoxDownscaled = new System.Windows.Forms.PictureBox();
            this.DownSize = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.currentSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DownscaleThreads = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownscaled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose image";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BrowseBtn.Location = new System.Drawing.Point(152, 39);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(171, 38);
            this.BrowseBtn.TabIndex = 2;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(551, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter down-scalling factor";
            // 
            // downScallingFactor
            // 
            this.downScallingFactor.Location = new System.Drawing.Point(816, 45);
            this.downScallingFactor.Name = "downScallingFactor";
            this.downScallingFactor.Size = new System.Drawing.Size(60, 22);
            this.downScallingFactor.TabIndex = 4;
            // 
            // pictureBoxDownscaled
            // 
            this.pictureBoxDownscaled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDownscaled.Location = new System.Drawing.Point(555, 83);
            this.pictureBoxDownscaled.Name = "pictureBoxDownscaled";
            this.pictureBoxDownscaled.Size = new System.Drawing.Size(321, 308);
            this.pictureBoxDownscaled.TabIndex = 5;
            this.pictureBoxDownscaled.TabStop = false;
            // 
            // DownSize
            // 
            this.DownSize.Location = new System.Drawing.Point(388, 150);
            this.DownSize.Name = "DownSize";
            this.DownSize.Size = new System.Drawing.Size(116, 44);
            this.DownSize.TabIndex = 6;
            this.DownSize.Text = "Down Size";
            this.DownSize.UseVisualStyleBackColor = true;
            this.DownSize.Click += new System.EventHandler(this.DownSize_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Old Size:";
            // 
            // currentSize
            // 
            this.currentSize.AutoSize = true;
            this.currentSize.Location = new System.Drawing.Point(102, 425);
            this.currentSize.Name = "currentSize";
            this.currentSize.Size = new System.Drawing.Size(0, 16);
            this.currentSize.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "New Size: ";
            // 
            // newSize
            // 
            this.newSize.AutoSize = true;
            this.newSize.Location = new System.Drawing.Point(571, 425);
            this.newSize.Name = "newSize";
            this.newSize.Size = new System.Drawing.Size(0, 16);
            this.newSize.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Consequential";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DownscaleThreads
            // 
            this.DownscaleThreads.Location = new System.Drawing.Point(388, 278);
            this.DownscaleThreads.Name = "DownscaleThreads";
            this.DownscaleThreads.Size = new System.Drawing.Size(116, 44);
            this.DownscaleThreads.TabIndex = 13;
            this.DownscaleThreads.Text = "Down Size";
            this.DownscaleThreads.UseVisualStyleBackColor = true;
            this.DownscaleThreads.Click += new System.EventHandler(this.DownscaleThreads_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Parallel";
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(15, 83);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(321, 308);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 459);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DownscaleThreads);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currentSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DownSize);
            this.Controls.Add(this.pictureBoxDownscaled);
            this.Controls.Add(this.downScallingFactor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "Form1";
            this.Text = "Image Down Sizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownscaled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox downScallingFactor;
        private System.Windows.Forms.PictureBox pictureBoxDownscaled;
        private System.Windows.Forms.Button DownSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label currentSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label newSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DownscaleThreads;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
    }
}

