﻿
namespace MajorHW
{
    partial class BuildData
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
            this.btnM1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.uploadIMG = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnR = new System.Windows.Forms.Button();
            this.btnProductprev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnM1
            // 
            this.btnM1.Location = new System.Drawing.Point(953, 123);
            this.btnM1.Name = "btnM1";
            this.btnM1.Size = new System.Drawing.Size(167, 63);
            this.btnM1.TabIndex = 0;
            this.btnM1.Text = "buildMem1";
            this.btnM1.UseVisualStyleBackColor = true;
            this.btnM1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Location = new System.Drawing.Point(993, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(127, 114);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // uploadIMG
            // 
            this.uploadIMG.Location = new System.Drawing.Point(893, 12);
            this.uploadIMG.Name = "uploadIMG";
            this.uploadIMG.Size = new System.Drawing.Size(85, 39);
            this.uploadIMG.TabIndex = 2;
            this.uploadIMG.Text = "Browse...";
            this.uploadIMG.UseVisualStyleBackColor = true;
            this.uploadIMG.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(12, 12);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(167, 63);
            this.btnR.TabIndex = 4;
            this.btnR.Text = "bdRg1.2";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnProductprev
            // 
            this.btnProductprev.Location = new System.Drawing.Point(12, 94);
            this.btnProductprev.Name = "btnProductprev";
            this.btnProductprev.Size = new System.Drawing.Size(167, 63);
            this.btnProductprev.TabIndex = 5;
            this.btnProductprev.Text = "Productprev";
            this.btnProductprev.UseVisualStyleBackColor = true;
            this.btnProductprev.Click += new System.EventHandler(this.btnProductprev_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "show_mem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "show_product";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 63);
            this.button3.TabIndex = 8;
            this.button3.Text = "Productprev";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BuildData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 551);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProductprev);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uploadIMG);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnM1);
            this.Name = "BuildData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuildData";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnM1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button uploadIMG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnProductprev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}