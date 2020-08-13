namespace PresentationLayer
{
    partial class UserControlActiveFailures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewActiveFailures = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_TypeOfFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginOfFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndOfFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveFailures)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActiveFailures
            // 
            this.dataGridViewActiveFailures.AllowUserToAddRows = false;
            this.dataGridViewActiveFailures.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewActiveFailures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewActiveFailures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewActiveFailures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewActiveFailures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewActiveFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActiveFailures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Id_Username,
            this.Id_TypeOfFailure,
            this.Id_City,
            this.BeginOfFailure,
            this.EndOfFailure,
            this.AdditionalDescription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActiveFailures.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewActiveFailures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewActiveFailures.EnableHeadersVisualStyles = false;
            this.dataGridViewActiveFailures.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewActiveFailures.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewActiveFailures.Name = "dataGridViewActiveFailures";
            this.dataGridViewActiveFailures.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewActiveFailures.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewActiveFailures.RowHeadersVisible = false;
            this.dataGridViewActiveFailures.RowTemplate.Height = 24;
            this.dataGridViewActiveFailures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActiveFailures.Size = new System.Drawing.Size(985, 440);
            this.dataGridViewActiveFailures.TabIndex = 0;
            this.dataGridViewActiveFailures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActiveFailures_CellContentClick);
            this.dataGridViewActiveFailures.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewActiveFailures_CellDoubleClick);
            this.dataGridViewActiveFailures.SelectionChanged += new System.EventHandler(this.dataGridViewActiveFailures_SelectionChanged);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Id_Username
            // 
            this.Id_Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_Username.DataPropertyName = "Id_Username";
            this.Id_Username.HeaderText = "Id korisnika";
            this.Id_Username.Name = "Id_Username";
            // 
            // Id_TypeOfFailure
            // 
            this.Id_TypeOfFailure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_TypeOfFailure.DataPropertyName = "Id_TypeOfFailure";
            this.Id_TypeOfFailure.HeaderText = "Id vrste ispada";
            this.Id_TypeOfFailure.Name = "Id_TypeOfFailure";
            // 
            // Id_City
            // 
            this.Id_City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_City.DataPropertyName = "Id_City";
            this.Id_City.HeaderText = "Id grada";
            this.Id_City.Name = "Id_City";
            // 
            // BeginOfFailure
            // 
            this.BeginOfFailure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BeginOfFailure.DataPropertyName = "BeginOfFailure";
            this.BeginOfFailure.HeaderText = "Datum i vrijeme početka ispada";
            this.BeginOfFailure.Name = "BeginOfFailure";
            // 
            // EndOfFailure
            // 
            this.EndOfFailure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndOfFailure.DataPropertyName = "EndOfFailure";
            this.EndOfFailure.HeaderText = "Datum i vrijeme završetka ispada";
            this.EndOfFailure.Name = "EndOfFailure";
            // 
            // AdditionalDescription
            // 
            this.AdditionalDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdditionalDescription.DataPropertyName = "AdditionalDescription";
            this.AdditionalDescription.HeaderText = "Dodatan opis";
            this.AdditionalDescription.Name = "AdditionalDescription";
            // 
            // UserControlActiveFailures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dataGridViewActiveFailures);
            this.Name = "UserControlActiveFailures";
            this.Size = new System.Drawing.Size(985, 440);
            this.Load += new System.EventHandler(this.UserControlActiveFailures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActiveFailures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActiveFailures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_TypeOfFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginOfFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndOfFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalDescription;
    }
}
