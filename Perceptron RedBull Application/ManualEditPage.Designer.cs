namespace Perceptron_RedBull_Application
{
    partial class ManualEditPage
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
            this.components = new System.ComponentModel.Container();
            this.manualEditDoneBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.predictedImgBox = new System.Windows.Forms.PictureBox();
            this.predictingImgNameLbl = new System.Windows.Forms.Label();
            this.errorProviderRglCountTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.manualCountRglTxt = new System.Windows.Forms.NumericUpDown();
            this.manualCountSfTxt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.predictedImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRglCountTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualCountRglTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualCountSfTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // manualEditDoneBtn
            // 
            this.manualEditDoneBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Product_trainnig_page_background_image;
            this.manualEditDoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualEditDoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualEditDoneBtn.ForeColor = System.Drawing.Color.SandyBrown;
            this.manualEditDoneBtn.Location = new System.Drawing.Point(12, 394);
            this.manualEditDoneBtn.Name = "manualEditDoneBtn";
            this.manualEditDoneBtn.Size = new System.Drawing.Size(119, 35);
            this.manualEditDoneBtn.TabIndex = 3;
            this.manualEditDoneBtn.Text = "Done";
            this.manualEditDoneBtn.UseVisualStyleBackColor = true;
            this.manualEditDoneBtn.Click += new System.EventHandler(this.manualEditDoneBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Regular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(8, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sugar Free";
            // 
            // predictedImgBox
            // 
            this.predictedImgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.predictedImgBox.Image = global::Perceptron_RedBull_Application.Properties.Resources.redbullvarietyeditionscoverphoto8_4;
            this.predictedImgBox.Location = new System.Drawing.Point(210, 44);
            this.predictedImgBox.Name = "predictedImgBox";
            this.predictedImgBox.Size = new System.Drawing.Size(482, 385);
            this.predictedImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.predictedImgBox.TabIndex = 18;
            this.predictedImgBox.TabStop = false;
            // 
            // predictingImgNameLbl
            // 
            this.predictingImgNameLbl.AutoSize = true;
            this.predictingImgNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.predictingImgNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictingImgNameLbl.ForeColor = System.Drawing.Color.Bisque;
            this.predictingImgNameLbl.Location = new System.Drawing.Point(207, 25);
            this.predictingImgNameLbl.Name = "predictingImgNameLbl";
            this.predictingImgNameLbl.Size = new System.Drawing.Size(0, 16);
            this.predictingImgNameLbl.TabIndex = 19;
            // 
            // errorProviderRglCountTxt
            // 
            this.errorProviderRglCountTxt.ContainerControl = this;
            // 
            // manualCountRglTxt
            // 
            this.manualCountRglTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualCountRglTxt.Location = new System.Drawing.Point(12, 102);
            this.manualCountRglTxt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.manualCountRglTxt.Name = "manualCountRglTxt";
            this.manualCountRglTxt.Size = new System.Drawing.Size(119, 22);
            this.manualCountRglTxt.TabIndex = 20;
            // 
            // manualCountSfTxt
            // 
            this.manualCountSfTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualCountSfTxt.Location = new System.Drawing.Point(12, 172);
            this.manualCountSfTxt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.manualCountSfTxt.Name = "manualCountSfTxt";
            this.manualCountSfTxt.Size = new System.Drawing.Size(119, 22);
            this.manualCountSfTxt.TabIndex = 21;
            // 
            // ManualEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Product_trainnig_page_background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.manualCountSfTxt);
            this.Controls.Add(this.manualCountRglTxt);
            this.Controls.Add(this.predictingImgNameLbl);
            this.Controls.Add(this.predictedImgBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manualEditDoneBtn);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "ManualEditPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manually Edit Predictions";
            this.Load += new System.EventHandler(this.ManualEditPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.predictedImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRglCountTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualCountRglTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualCountSfTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manualEditDoneBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox predictedImgBox;
        private System.Windows.Forms.Label predictingImgNameLbl;
        private System.Windows.Forms.ErrorProvider errorProviderRglCountTxt;
        private System.Windows.Forms.NumericUpDown manualCountSfTxt;
        private System.Windows.Forms.NumericUpDown manualCountRglTxt;
    }
}