namespace Perceptron_RedBull_Application
{
    partial class PredictionResultPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictionResultPage));
            this.finishBtn = new System.Windows.Forms.Button();
            this.resultRglImgBox = new System.Windows.Forms.PictureBox();
            this.resultSfImgBox = new System.Windows.Forms.PictureBox();
            this.unidentifyImgBox = new System.Windows.Forms.PictureBox();
            this.manualAddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unidentifyCountBtnTxt = new System.Windows.Forms.Button();
            this.rglCountBtnTxt = new System.Windows.Forms.Button();
            this.sfCountBtnTxt = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.accuracyLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultRglImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultSfImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidentifyImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // finishBtn
            // 
            this.finishBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Result_display_page_background_image;
            this.finishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishBtn.ForeColor = System.Drawing.Color.SandyBrown;
            this.finishBtn.Location = new System.Drawing.Point(573, 394);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(119, 35);
            this.finishBtn.TabIndex = 5;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // resultRglImgBox
            // 
            this.resultRglImgBox.Image = global::Perceptron_RedBull_Application.Properties.Resources.red;
            this.resultRglImgBox.Location = new System.Drawing.Point(13, 67);
            this.resultRglImgBox.Name = "resultRglImgBox";
            this.resultRglImgBox.Size = new System.Drawing.Size(128, 154);
            this.resultRglImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultRglImgBox.TabIndex = 7;
            this.resultRglImgBox.TabStop = false;
            // 
            // resultSfImgBox
            // 
            this.resultSfImgBox.Image = global::Perceptron_RedBull_Application.Properties.Resources.RedBullSugarFree__1_;
            this.resultSfImgBox.Location = new System.Drawing.Point(292, 67);
            this.resultSfImgBox.Name = "resultSfImgBox";
            this.resultSfImgBox.Size = new System.Drawing.Size(128, 154);
            this.resultSfImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultSfImgBox.TabIndex = 8;
            this.resultSfImgBox.TabStop = false;
            // 
            // unidentifyImgBox
            // 
            this.unidentifyImgBox.Image = global::Perceptron_RedBull_Application.Properties.Resources.download__2_;
            this.unidentifyImgBox.Location = new System.Drawing.Point(564, 67);
            this.unidentifyImgBox.Name = "unidentifyImgBox";
            this.unidentifyImgBox.Size = new System.Drawing.Size(128, 154);
            this.unidentifyImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unidentifyImgBox.TabIndex = 9;
            this.unidentifyImgBox.TabStop = false;
            // 
            // manualAddBtn
            // 
            this.manualAddBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Result_display_page_background_image;
            this.manualAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualAddBtn.ForeColor = System.Drawing.Color.BurlyWood;
            this.manualAddBtn.Location = new System.Drawing.Point(564, 266);
            this.manualAddBtn.Name = "manualAddBtn";
            this.manualAddBtn.Size = new System.Drawing.Size(128, 29);
            this.manualAddBtn.TabIndex = 12;
            this.manualAddBtn.Text = "Add";
            this.manualAddBtn.UseVisualStyleBackColor = true;
            this.manualAddBtn.Click += new System.EventHandler(this.manualAddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Regular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(314, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sugar Free";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(573, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Unidentifiable";
            // 
            // unidentifyCountBtnTxt
            // 
            this.unidentifyCountBtnTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.unidentifyCountBtnTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unidentifyCountBtnTxt.BackgroundImage")));
            this.unidentifyCountBtnTxt.Enabled = false;
            this.unidentifyCountBtnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unidentifyCountBtnTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidentifyCountBtnTxt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.unidentifyCountBtnTxt.Location = new System.Drawing.Point(564, 227);
            this.unidentifyCountBtnTxt.Name = "unidentifyCountBtnTxt";
            this.unidentifyCountBtnTxt.Size = new System.Drawing.Size(128, 29);
            this.unidentifyCountBtnTxt.TabIndex = 18;
            this.unidentifyCountBtnTxt.Text = "0";
            this.unidentifyCountBtnTxt.UseVisualStyleBackColor = false;
            // 
            // rglCountBtnTxt
            // 
            this.rglCountBtnTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rglCountBtnTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rglCountBtnTxt.BackgroundImage")));
            this.rglCountBtnTxt.Enabled = false;
            this.rglCountBtnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rglCountBtnTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rglCountBtnTxt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rglCountBtnTxt.Location = new System.Drawing.Point(13, 227);
            this.rglCountBtnTxt.Name = "rglCountBtnTxt";
            this.rglCountBtnTxt.Size = new System.Drawing.Size(128, 29);
            this.rglCountBtnTxt.TabIndex = 17;
            this.rglCountBtnTxt.Text = "0";
            this.rglCountBtnTxt.UseVisualStyleBackColor = false;
            // 
            // sfCountBtnTxt
            // 
            this.sfCountBtnTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sfCountBtnTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sfCountBtnTxt.BackgroundImage")));
            this.sfCountBtnTxt.Enabled = false;
            this.sfCountBtnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sfCountBtnTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfCountBtnTxt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sfCountBtnTxt.Location = new System.Drawing.Point(292, 227);
            this.sfCountBtnTxt.Name = "sfCountBtnTxt";
            this.sfCountBtnTxt.Size = new System.Drawing.Size(128, 29);
            this.sfCountBtnTxt.TabIndex = 16;
            this.sfCountBtnTxt.Text = "0";
            this.sfCountBtnTxt.UseVisualStyleBackColor = false;
            // 
            // reportBtn
            // 
            this.reportBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Result_display_page_background_image;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.LightGreen;
            this.reportBtn.Location = new System.Drawing.Point(394, 394);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(146, 35);
            this.reportBtn.TabIndex = 19;
            this.reportBtn.Text = "Out to Excel";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // accuracyLbl
            // 
            this.accuracyLbl.AutoSize = true;
            this.accuracyLbl.BackColor = System.Drawing.Color.DarkGray;
            this.accuracyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyLbl.Location = new System.Drawing.Point(13, 416);
            this.accuracyLbl.Name = "accuracyLbl";
            this.accuracyLbl.Size = new System.Drawing.Size(99, 16);
            this.accuracyLbl.TabIndex = 20;
            this.accuracyLbl.Text = "Accuracy : 84%";
            // 
            // PredictionResultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Result_display_page_background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.accuracyLbl);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.unidentifyCountBtnTxt);
            this.Controls.Add(this.rglCountBtnTxt);
            this.Controls.Add(this.sfCountBtnTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manualAddBtn);
            this.Controls.Add(this.unidentifyImgBox);
            this.Controls.Add(this.resultSfImgBox);
            this.Controls.Add(this.resultRglImgBox);
            this.Controls.Add(this.finishBtn);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "PredictionResultPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prediction Result";
            this.Load += new System.EventHandler(this.PredictionResultPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultRglImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultSfImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidentifyImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.PictureBox resultRglImgBox;
        private System.Windows.Forms.PictureBox resultSfImgBox;
        private System.Windows.Forms.PictureBox unidentifyImgBox;
        private System.Windows.Forms.Button manualAddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button unidentifyCountBtnTxt;
        private System.Windows.Forms.Button rglCountBtnTxt;
        private System.Windows.Forms.Button sfCountBtnTxt;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Label accuracyLbl;
    }
}