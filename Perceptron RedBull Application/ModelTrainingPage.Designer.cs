namespace Perceptron_RedBull_Application
{
    partial class ModelTrainingPage
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
            this.newCatNameTxt = new System.Windows.Forms.TextBox();
            this.addTrainingImgBtn = new System.Windows.Forms.Button();
            this.trainBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trainBackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newCatNameTxt
            // 
            this.newCatNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCatNameTxt.ForeColor = System.Drawing.Color.Black;
            this.newCatNameTxt.Location = new System.Drawing.Point(501, 265);
            this.newCatNameTxt.Name = "newCatNameTxt";
            this.newCatNameTxt.Size = new System.Drawing.Size(191, 26);
            this.newCatNameTxt.TabIndex = 0;
            this.newCatNameTxt.Enter += new System.EventHandler(this.newCatNameTxt_Enter);
            this.newCatNameTxt.Leave += new System.EventHandler(this.newCatNameTxt_Leave);
            // 
            // addTrainingImgBtn
            // 
            this.addTrainingImgBtn.Location = new System.Drawing.Point(572, 310);
            this.addTrainingImgBtn.Name = "addTrainingImgBtn";
            this.addTrainingImgBtn.Size = new System.Drawing.Size(120, 29);
            this.addTrainingImgBtn.TabIndex = 1;
            this.addTrainingImgBtn.Text = "Add Image Set";
            this.addTrainingImgBtn.UseVisualStyleBackColor = true;
            // 
            // trainBtn
            // 
            this.trainBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Product_trainnig_page_background_image;
            this.trainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainBtn.ForeColor = System.Drawing.Color.SandyBrown;
            this.trainBtn.Location = new System.Drawing.Point(573, 394);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(119, 35);
            this.trainBtn.TabIndex = 2;
            this.trainBtn.Text = "Train";
            this.trainBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(501, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "New category name: ";
            // 
            // trainBackBtn
            // 
            this.trainBackBtn.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Product_trainnig_page_background_image;
            this.trainBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainBackBtn.ForeColor = System.Drawing.Color.LightCoral;
            this.trainBackBtn.Location = new System.Drawing.Point(12, 394);
            this.trainBackBtn.Name = "trainBackBtn";
            this.trainBackBtn.Size = new System.Drawing.Size(119, 35);
            this.trainBackBtn.TabIndex = 4;
            this.trainBackBtn.Text = "Back";
            this.trainBackBtn.UseVisualStyleBackColor = true;
            this.trainBackBtn.Click += new System.EventHandler(this.trainBackBtn_Click);
            // 
            // ModelTrainingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perceptron_RedBull_Application.Properties.Resources.Product_trainnig_page_background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.trainBackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainBtn);
            this.Controls.Add(this.addTrainingImgBtn);
            this.Controls.Add(this.newCatNameTxt);
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "ModelTrainingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Center";
            this.Load += new System.EventHandler(this.ModelTrainingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newCatNameTxt;
        private System.Windows.Forms.Button addTrainingImgBtn;
        private System.Windows.Forms.Button trainBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button trainBackBtn;
    }
}