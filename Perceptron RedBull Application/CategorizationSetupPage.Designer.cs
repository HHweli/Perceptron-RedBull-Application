namespace Perceptron_RedBull_Application
{
    partial class CategorizationSetupPage
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
            this.categorizeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.catSetupBackBtn = new System.Windows.Forms.Button();
            this.predictingImgNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // categorizeBtn
            // 
            this.categorizeBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Prediction_setup_page_background_image;
            this.categorizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorizeBtn.ForeColor = System.Drawing.Color.BurlyWood;
            this.categorizeBtn.Location = new System.Drawing.Point(12, 353);
            this.categorizeBtn.Name = "categorizeBtn";
            this.categorizeBtn.Size = new System.Drawing.Size(143, 35);
            this.categorizeBtn.TabIndex = 1;
            this.categorizeBtn.Text = "Categorize";
            this.categorizeBtn.UseVisualStyleBackColor = true;
            this.categorizeBtn.Click += new System.EventHandler(this.categorizeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Perceptron_RedBull_Application.Properties.Resources.redbullvarietyeditionscoverphoto8_4;
            this.pictureBox1.Location = new System.Drawing.Point(210, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Prediction_setup_page_background_image;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.BurlyWood;
            this.button2.Location = new System.Drawing.Point(12, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Image";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // catSetupBackBtn
            // 
            this.catSetupBackBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Prediction_setup_page_background_image;
            this.catSetupBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catSetupBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catSetupBackBtn.ForeColor = System.Drawing.Color.LightCoral;
            this.catSetupBackBtn.Location = new System.Drawing.Point(12, 394);
            this.catSetupBackBtn.Name = "catSetupBackBtn";
            this.catSetupBackBtn.Size = new System.Drawing.Size(143, 35);
            this.catSetupBackBtn.TabIndex = 4;
            this.catSetupBackBtn.Text = "Back";
            this.catSetupBackBtn.UseVisualStyleBackColor = true;
            this.catSetupBackBtn.Click += new System.EventHandler(this.catSetupBackBtn_Click);
            // 
            // predictingImgNameLbl
            // 
            this.predictingImgNameLbl.AutoSize = true;
            this.predictingImgNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.predictingImgNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictingImgNameLbl.ForeColor = System.Drawing.Color.SandyBrown;
            this.predictingImgNameLbl.Location = new System.Drawing.Point(210, 13);
            this.predictingImgNameLbl.Name = "predictingImgNameLbl";
            this.predictingImgNameLbl.Size = new System.Drawing.Size(174, 16);
            this.predictingImgNameLbl.TabIndex = 5;
            this.predictingImgNameLbl.Text = "Predicting Image File Name";
            // 
            // CategorizationSetupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Prediction_setup_page_background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.predictingImgNameLbl);
            this.Controls.Add(this.catSetupBackBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.categorizeBtn);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "CategorizationSetupPage";
            this.Text = "Categorization Setup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button categorizeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button catSetupBackBtn;
        private System.Windows.Forms.Label predictingImgNameLbl;
    }
}