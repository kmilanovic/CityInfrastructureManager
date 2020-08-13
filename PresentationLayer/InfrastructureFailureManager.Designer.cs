namespace PresentationLayer
{
    partial class InfrastructureFailureManager
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconPictureBoxUser = new FontAwesome.Sharp.IconPictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.iconButtonHistoryOfFailures = new FontAwesome.Sharp.IconButton();
            this.iconButtonActiveFailures = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddFailure = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.iconPictureBoxUser);
            this.panelMenu.Controls.Add(this.lblUser);
            this.panelMenu.Controls.Add(this.iconButtonHistoryOfFailures);
            this.panelMenu.Controls.Add(this.iconButtonActiveFailures);
            this.panelMenu.Controls.Add(this.iconButtonAddFailure);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 653);
            this.panelMenu.TabIndex = 0;
            // 
            // iconPictureBoxUser
            // 
            this.iconPictureBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.iconPictureBoxUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBoxUser.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxUser.Location = new System.Drawing.Point(4, 517);
            this.iconPictureBoxUser.Name = "iconPictureBoxUser";
            this.iconPictureBoxUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconPictureBoxUser.Size = new System.Drawing.Size(45, 32);
            this.iconPictureBoxUser.TabIndex = 6;
            this.iconPictureBoxUser.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(39, 521);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.lblUser.Size = new System.Drawing.Size(117, 20);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "kmilanovic";
            // 
            // iconButtonHistoryOfFailures
            // 
            this.iconButtonHistoryOfFailures.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHistoryOfFailures.FlatAppearance.BorderSize = 0;
            this.iconButtonHistoryOfFailures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHistoryOfFailures.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHistoryOfFailures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHistoryOfFailures.ForeColor = System.Drawing.Color.White;
            this.iconButtonHistoryOfFailures.IconChar = FontAwesome.Sharp.IconChar.History;
            this.iconButtonHistoryOfFailures.IconColor = System.Drawing.Color.White;
            this.iconButtonHistoryOfFailures.IconSize = 32;
            this.iconButtonHistoryOfFailures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHistoryOfFailures.Location = new System.Drawing.Point(0, 260);
            this.iconButtonHistoryOfFailures.Name = "iconButtonHistoryOfFailures";
            this.iconButtonHistoryOfFailures.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonHistoryOfFailures.Rotation = 0D;
            this.iconButtonHistoryOfFailures.Size = new System.Drawing.Size(250, 60);
            this.iconButtonHistoryOfFailures.TabIndex = 3;
            this.iconButtonHistoryOfFailures.Text = "Povijest ispada";
            this.iconButtonHistoryOfFailures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHistoryOfFailures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHistoryOfFailures.UseVisualStyleBackColor = true;
            this.iconButtonHistoryOfFailures.Click += new System.EventHandler(this.iconButtonHistoryOfFailures_Click);
            // 
            // iconButtonActiveFailures
            // 
            this.iconButtonActiveFailures.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonActiveFailures.FlatAppearance.BorderSize = 0;
            this.iconButtonActiveFailures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonActiveFailures.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonActiveFailures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonActiveFailures.ForeColor = System.Drawing.Color.White;
            this.iconButtonActiveFailures.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconButtonActiveFailures.IconColor = System.Drawing.Color.White;
            this.iconButtonActiveFailures.IconSize = 32;
            this.iconButtonActiveFailures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonActiveFailures.Location = new System.Drawing.Point(0, 200);
            this.iconButtonActiveFailures.Name = "iconButtonActiveFailures";
            this.iconButtonActiveFailures.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonActiveFailures.Rotation = 0D;
            this.iconButtonActiveFailures.Size = new System.Drawing.Size(250, 60);
            this.iconButtonActiveFailures.TabIndex = 2;
            this.iconButtonActiveFailures.Text = "Aktivni ispadi";
            this.iconButtonActiveFailures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonActiveFailures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonActiveFailures.UseVisualStyleBackColor = true;
            this.iconButtonActiveFailures.Click += new System.EventHandler(this.iconButtonActiveFailures_Click);
            // 
            // iconButtonAddFailure
            // 
            this.iconButtonAddFailure.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAddFailure.FlatAppearance.BorderSize = 0;
            this.iconButtonAddFailure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddFailure.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAddFailure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddFailure.ForeColor = System.Drawing.Color.White;
            this.iconButtonAddFailure.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAddFailure.IconColor = System.Drawing.Color.White;
            this.iconButtonAddFailure.IconSize = 32;
            this.iconButtonAddFailure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddFailure.Location = new System.Drawing.Point(0, 140);
            this.iconButtonAddFailure.Name = "iconButtonAddFailure";
            this.iconButtonAddFailure.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonAddFailure.Rotation = 0D;
            this.iconButtonAddFailure.Size = new System.Drawing.Size(250, 60);
            this.iconButtonAddFailure.TabIndex = 1;
            this.iconButtonAddFailure.Text = "Dodaj ispad";
            this.iconButtonAddFailure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddFailure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddFailure.UseVisualStyleBackColor = true;
            this.iconButtonAddFailure.Click += new System.EventHandler(this.iconButtonAddFailure_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::PresentationLayer.Properties.Resources.LogoCIM6;
            this.btnHome.Location = new System.Drawing.Point(3, 31);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(244, 74);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1432, 75);
            this.panelTitleBar.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(250, 75);
            this.panelBody.Margin = new System.Windows.Forms.Padding(0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(20);
            this.panelBody.Size = new System.Drawing.Size(1432, 578);
            this.panelBody.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(16, 573);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 40);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "ODJAVA";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // InfrastructureFailureManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1682, 653);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "InfrastructureFailureManager";
            this.Text = "InfrastructureFailureManager";
            this.Load += new System.EventHandler(this.InfrastructureFailureManager_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonHistoryOfFailures;
        private FontAwesome.Sharp.IconButton iconButtonActiveFailures;
        private FontAwesome.Sharp.IconButton iconButtonAddFailure;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelBody;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogout;
    }
}