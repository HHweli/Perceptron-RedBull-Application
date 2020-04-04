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
            this.predictingImageBox = new System.Windows.Forms.PictureBox();
            this.addPredictImgBtn = new System.Windows.Forms.Button();
            this.catSetupBackBtn = new System.Windows.Forms.Button();
            this.predictingImgNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.predictingImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // categorizeBtn
            // 
            this.categorizeBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Prediction_setup_page_background_image;
            this.categorizeBtn.Enabled = false;
            this.categorizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorizeBtn.ForeColor = System.Drawing.Color.SandyBrown;
            this.categorizeBtn.Location = new System.Drawing.Point(12, 338);
            this.categorizeBtn.Name = "categorizeBtn";
            this.categorizeBtn.Size = new System.Drawing.Size(143, 35);
            this.categorizeBtn.TabIndex = 1;
            this.categorizeBtn.Text = "Categorize";
            this.categorizeBtn.UseVisualStyleBackColor = true;
            this.categorizeBtn.Click += new System.EventHandler(this.categorizeBtn_Click);
            // 
            // predictingImageBox
            // 
            this.predictingImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.predictingImageBox.Location = new System.Drawing.Point(210, 44);
            this.predictingImageBox.Name = "predictingImageBox";
            this.predictingImageBox.Size = new System.Drawing.Size(482, 385);
            this.predictingImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.predictingImageBox.TabIndex = 2;
            this.predictingImageBox.TabStop = false;
            // 
            // addPredictImgBtn
            // 
            this.addPredictImgBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Prediction_setup_page_background_image;
            this.addPredictImgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPredictImgBtn.ForeColor = System.Drawing.Color.BurlyWood;
            this.addPredictImgBtn.Location = new System.Drawing.Point(210, 4);
            this.addPredictImgBtn.Name = "addPredictImgBtn";
            this.addPredictImgBtn.Size = new System.Drawing.Size(127, 34);
            this.addPredictImgBtn.TabIndex = 3;
            this.addPredictImgBtn.Text = "Add Image";
            this.addPredictImgBtn.UseVisualStyleBackColor = true;
            this.addPredictImgBtn.Click += new System.EventHandler(this.addPredictImgBtn_Click);
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
            this.predictingImgNameLbl.Location = new System.Drawing.Point(343, 9);
            this.predictingImgNameLbl.Name = "predictingImgNameLbl";
            this.predictingImgNameLbl.Size = new System.Drawing.Size(0, 16);
            this.predictingImgNameLbl.TabIndex = 5;
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
            this.Controls.Add(this.addPredictImgBtn);
            this.Controls.Add(this.predictingImageBox);
            this.Controls.Add(this.categorizeBtn);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "CategorizationSetupPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorization Setup";
            ((System.ComponentModel.ISupportInitialize)(this.predictingImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button categorizeBtn;
        private System.Windows.Forms.PictureBox predictingImageBox;
        private System.Windows.Forms.Button addPredictImgBtn;
        private System.Windows.Forms.Button catSetupBackBtn;
        private System.Windows.Forms.Label predictingImgNameLbl;
    }
}