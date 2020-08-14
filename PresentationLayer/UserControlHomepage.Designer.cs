namespace PresentationLayer
{
    partial class UserControlHomepage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxHomepage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomepage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHomepage
            // 
            this.pictureBoxHomepage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHomepage.Image = global::PresentationLayer.Properties.Resources.City_Landscape2;
            this.pictureBoxHomepage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHomepage.Name = "pictureBoxHomepage";
            this.pictureBoxHomepage.Size = new System.Drawing.Size(1320, 550);
            this.pictureBoxHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHomepage.TabIndex = 0;
            this.pictureBoxHomepage.TabStop = false;
            // 
            // UserControlHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBoxHomepage);
            this.Name = "UserControlHomepage";
            this.Size = new System.Drawing.Size(1320, 550);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomepage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHomepage;
    }
}
