namespace CourseWorkNFRV
{
    partial class CourseWorkNFRV_N3
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
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOrderedDither = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 12);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(12, 41);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(1131, 498);
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOrderedDither
            // 
            this.btnOrderedDither.Location = new System.Drawing.Point(107, 12);
            this.btnOrderedDither.Name = "btnOrderedDither";
            this.btnOrderedDither.Size = new System.Drawing.Size(136, 23);
            this.btnOrderedDither.TabIndex = 2;
            this.btnOrderedDither.Text = "Ordered Dithering";
            this.btnOrderedDither.UseVisualStyleBackColor = true;
            this.btnOrderedDither.Click += new System.EventHandler(this.btnOrderedDither_Click);
            // 
            // CourseWorkNFRV_N3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 540);
            this.Controls.Add(this.btnOrderedDither);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.btnLoadImage);
            this.Name = "CourseWorkNFRV_N3";
            this.Text = "Course Work NFRV N3";
            this.Load += new System.EventHandler(this.CourseWorkNFRV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOrderedDither;
    }
}

