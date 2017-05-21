namespace eBay_Thumbnails
{
    partial class eBayThumbnails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eBayThumbnails));
            this.btStart = new System.Windows.Forms.Button();
            this.tbFirstSetStart = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tbFirstSetEnd = new System.Windows.Forms.TextBox();
            this.tbSecondSetStart = new System.Windows.Forms.TextBox();
            this.tbSecondSetEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSecondSetCheck = new System.Windows.Forms.CheckBox();
            this.rbUpperJPG = new System.Windows.Forms.RadioButton();
            this.rbLowerJPG = new System.Windows.Forms.RadioButton();
            this.Title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MainPicture = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Measurement = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Translation = new System.Windows.Forms.TextBox();
            this.ImageLocalPath = new System.Windows.Forms.TextBox();
            this.ClearAll = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.imageDirectory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btStart.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(12, 359);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 11;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFirstSetStart
            // 
            this.tbFirstSetStart.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstSetStart.Location = new System.Drawing.Point(217, 14);
            this.tbFirstSetStart.Name = "tbFirstSetStart";
            this.tbFirstSetStart.Size = new System.Drawing.Size(56, 22);
            this.tbFirstSetStart.TabIndex = 4;
            this.tbFirstSetStart.Text = "0";
            this.tbFirstSetStart.TextChanged += new System.EventHandler(this.tbFirstSetStart_TextChanged);
            this.tbFirstSetStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStart_KeyPress);
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.Location = new System.Drawing.Point(12, 280);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbOutput.Size = new System.Drawing.Size(621, 73);
            this.tbOutput.TabIndex = 600;
            this.tbOutput.TabStop = false;
            this.tbOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbOutput_MouseClick);
            this.tbOutput.TextChanged += new System.EventHandler(this.tbOutput_TextChanged);
            // 
            // tbFirstSetEnd
            // 
            this.tbFirstSetEnd.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstSetEnd.Location = new System.Drawing.Point(330, 15);
            this.tbFirstSetEnd.Name = "tbFirstSetEnd";
            this.tbFirstSetEnd.Size = new System.Drawing.Size(63, 22);
            this.tbFirstSetEnd.TabIndex = 5;
            this.tbFirstSetEnd.Text = "0";
            this.tbFirstSetEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEnd_KeyPress);
            // 
            // tbSecondSetStart
            // 
            this.tbSecondSetStart.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecondSetStart.Location = new System.Drawing.Point(217, 41);
            this.tbSecondSetStart.Name = "tbSecondSetStart";
            this.tbSecondSetStart.Size = new System.Drawing.Size(56, 22);
            this.tbSecondSetStart.TabIndex = 6;
            this.tbSecondSetStart.Text = "0";
            this.tbSecondSetStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStartSecond_KeyPress);
            // 
            // tbSecondSetEnd
            // 
            this.tbSecondSetEnd.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecondSetEnd.Location = new System.Drawing.Point(330, 41);
            this.tbSecondSetEnd.Name = "tbSecondSetEnd";
            this.tbSecondSetEnd.Size = new System.Drawing.Size(63, 22);
            this.tbSecondSetEnd.TabIndex = 7;
            this.tbSecondSetEnd.Text = "0";
            this.tbSecondSetEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEndSecond_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 600;
            this.label1.Text = "start:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 600;
            this.label2.Text = "end:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 800;
            this.label3.Text = "Main Pic URL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "end:";
            // 
            // cbSecondSetCheck
            // 
            this.cbSecondSetCheck.AutoSize = true;
            this.cbSecondSetCheck.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSecondSetCheck.Location = new System.Drawing.Point(399, 43);
            this.cbSecondSetCheck.Name = "cbSecondSetCheck";
            this.cbSecondSetCheck.Size = new System.Drawing.Size(61, 17);
            this.cbSecondSetCheck.TabIndex = 8;
            this.cbSecondSetCheck.Text = "enable";
            this.cbSecondSetCheck.UseVisualStyleBackColor = true;
            // 
            // rbUpperJPG
            // 
            this.rbUpperJPG.AutoSize = true;
            this.rbUpperJPG.Checked = true;
            this.rbUpperJPG.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpperJPG.Location = new System.Drawing.Point(466, 11);
            this.rbUpperJPG.Name = "rbUpperJPG";
            this.rbUpperJPG.Size = new System.Drawing.Size(43, 17);
            this.rbUpperJPG.TabIndex = 11;
            this.rbUpperJPG.TabStop = true;
            this.rbUpperJPG.Text = "JPG";
            this.rbUpperJPG.UseVisualStyleBackColor = true;
            this.rbUpperJPG.CheckedChanged += new System.EventHandler(this.rbUpperJPG_CheckedChanged);
            // 
            // rbLowerJPG
            // 
            this.rbLowerJPG.AutoSize = true;
            this.rbLowerJPG.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLowerJPG.Location = new System.Drawing.Point(466, 34);
            this.rbLowerJPG.Name = "rbLowerJPG";
            this.rbLowerJPG.Size = new System.Drawing.Size(42, 17);
            this.rbLowerJPG.TabIndex = 12;
            this.rbLowerJPG.Text = "jpg";
            this.rbLowerJPG.UseVisualStyleBackColor = true;
            this.rbLowerJPG.CheckedChanged += new System.EventHandler(this.rbLowerJPG_CheckedChanged);
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(64, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 22);
            this.Title.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "title:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "subtitle:";
            // 
            // Subtitle
            // 
            this.Subtitle.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitle.Location = new System.Drawing.Point(64, 37);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(100, 22);
            this.Subtitle.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "main pic";
            // 
            // MainPicture
            // 
            this.MainPicture.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPicture.Location = new System.Drawing.Point(64, 66);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(100, 22);
            this.MainPicture.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "description";
            // 
            // Description
            // 
            this.Description.AcceptsReturn = true;
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.Location = new System.Drawing.Point(12, 148);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description.Size = new System.Drawing.Size(297, 126);
            this.Description.TabIndex = 9;
            this.Description.Text = "Used but in great condition";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "mesasurements";
            // 
            // Measurement
            // 
            this.Measurement.AcceptsReturn = true;
            this.Measurement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Measurement.Location = new System.Drawing.Point(315, 147);
            this.Measurement.Multiline = true;
            this.Measurement.Name = "Measurement";
            this.Measurement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Measurement.Size = new System.Drawing.Size(318, 127);
            this.Measurement.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(517, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "translated description";
            // 
            // Translation
            // 
            this.Translation.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Translation.Location = new System.Drawing.Point(524, 33);
            this.Translation.Name = "Translation";
            this.Translation.Size = new System.Drawing.Size(100, 22);
            this.Translation.TabIndex = 24;
            this.Translation.TabStop = false;
            // 
            // ImageLocalPath
            // 
            this.ImageLocalPath.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLocalPath.Location = new System.Drawing.Point(260, 66);
            this.ImageLocalPath.Name = "ImageLocalPath";
            this.ImageLocalPath.ReadOnly = true;
            this.ImageLocalPath.Size = new System.Drawing.Size(373, 22);
            this.ImageLocalPath.TabIndex = 25;
            this.ImageLocalPath.TabStop = false;
            this.ImageLocalPath.Click += new System.EventHandler(this.ImageLocalPath_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearAll.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.Location = new System.Drawing.Point(93, 359);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(75, 23);
            this.ClearAll.TabIndex = 12;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(284, 364);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(44, 13);
            this.lblUpdate.TabIndex = 27;
            this.lblUpdate.Text = "update";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 801;
            this.label12.Text = "img dir:";
            // 
            // imageDirectory
            // 
            this.imageDirectory.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageDirectory.Location = new System.Drawing.Point(64, 94);
            this.imageDirectory.Name = "imageDirectory";
            this.imageDirectory.Size = new System.Drawing.Size(100, 22);
            this.imageDirectory.TabIndex = 802;
            this.imageDirectory.Text = "img/000";
            this.imageDirectory.TextChanged += new System.EventHandler(this.imageDirectory_TextChanged);
            // 
            // eBayThumbnails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 394);
            this.Controls.Add(this.imageDirectory);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.ImageLocalPath);
            this.Controls.Add(this.Translation);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Measurement);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MainPicture);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Subtitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.rbLowerJPG);
            this.Controls.Add(this.rbUpperJPG);
            this.Controls.Add(this.cbSecondSetCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSecondSetEnd);
            this.Controls.Add(this.tbSecondSetStart);
            this.Controls.Add(this.tbFirstSetEnd);
            this.Controls.Add(this.tbFirstSetStart);
            this.Controls.Add(this.btStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eBayThumbnails";
            this.Text = "eBay Thumbnails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbFirstSetStart;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.TextBox tbFirstSetEnd;
        private System.Windows.Forms.TextBox tbSecondSetStart;
        private System.Windows.Forms.TextBox tbSecondSetEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSecondSetCheck;
        private System.Windows.Forms.RadioButton rbUpperJPG;
        private System.Windows.Forms.RadioButton rbLowerJPG;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Subtitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MainPicture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Measurement;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Translation;
        private System.Windows.Forms.TextBox ImageLocalPath;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox imageDirectory;
    }
}

