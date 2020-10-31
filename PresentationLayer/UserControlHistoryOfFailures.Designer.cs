namespace PresentationLayer
{
    partial class UserControlHistoryOfFailures
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
            this.dataGridViewHistoryOfFailures = new System.Windows.Forms.DataGridView();
            this.Id_History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_UsernameHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_TypeOfFailureHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_CityHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginOfFailureHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndOfFailureHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalDescriptionHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryOfFailures)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistoryOfFailures
            // 
            this.dataGridViewHistoryOfFailures.AllowUserToAddRows = false;
            this.dataGridViewHistoryOfFailures.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHistoryOfFailures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistoryOfFailures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewHistoryOfFailures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistoryOfFailures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistoryOfFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoryOfFailures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_History,
            this.Id_UsernameHistory,
            this.Id_TypeOfFailureHistory,
            this.Id_CityHistory,
            this.BeginOfFailureHistory,
            this.EndOfFailureHistory,
            this.AdditionalDescriptionHistory});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistoryOfFailures.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHistoryOfFailures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistoryOfFailures.EnableHeadersVisualStyles = false;
            this.dataGridViewHistoryOfFailures.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewHistoryOfFailures.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHistoryOfFailures.Name = "dataGridViewHistoryOfFailures";
            this.dataGridViewHistoryOfFailures.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistoryOfFailures.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHistoryOfFailures.RowHeadersVisible = false;
            this.dataGridViewHistoryOfFailures.RowTemplate.Height = 24;
            this.dataGridViewHistoryOfFailures.Size = new System.Drawing.Size(1320, 550);
            this.dataGridViewHistoryOfFailures.TabIndex = 3;
            // 
            // Id_History
            // 
            this.Id_History.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_History.DataPropertyName = "Id";
            this.Id_History.HeaderText = "Id";
            this.Id_History.Name = "Id_History";
            // 
            // Id_UsernameHistory
            // 
            this.Id_UsernameHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_UsernameHistory.DataPropertyName = "Id_Username";
            this.Id_UsernameHistory.HeaderText = "Id korisnika";
            this.Id_UsernameHistory.Name = "Id_UsernameHistory";
            // 
            // Id_TypeOfFailureHistory
            // 
            this.Id_TypeOfFailureHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_TypeOfFailureHistory.DataPropertyName = "Id_TypeOfFailure";
            this.Id_TypeOfFailureHistory.HeaderText = "Id vrste ispada";
            this.Id_TypeOfFailureHistory.Name = "Id_TypeOfFailureHistory";
            // 
            // Id_CityHistory
            // 
            this.Id_CityHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_CityHistory.DataPropertyName = "Id_City";
            this.Id_CityHistory.HeaderText = "Id grada";
            this.Id_CityHistory.Name = "Id_CityHistory";
            // 
            // BeginOfFailureHistory
            // 
            this.BeginOfFailureHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BeginOfFailureHistory.DataPropertyName = "BeginOfFailure";
            this.BeginOfFailureHistory.HeaderText = "Datum i vrijeme početka ispada";
            this.BeginOfFailureHistory.Name = "BeginOfFailureHistory";
            // 
            // EndOfFailureHistory
            // 
            this.EndOfFailureHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndOfFailureHistory.DataPropertyName = "EndOfFailure";
            this.EndOfFailureHistory.HeaderText = "Datum i vrijeme završetka ispada";
            this.EndOfFailureHistory.Name = "EndOfFailureHistory";
            // 
            // AdditionalDescriptionHistory
            // 
            this.AdditionalDescriptionHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdditionalDescriptionHistory.DataPropertyName = "AdditionalDescription";
            this.AdditionalDescriptionHistory.HeaderText = "Dodatan opis";
            this.AdditionalDescriptionHistory.Name = "AdditionalDescriptionHistory";
            // 
            // UserControlHistoryOfFailures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dataGridViewHistoryOfFailures);
            this.Name = "UserControlHistoryOfFailures";
            this.Size = new System.Drawing.Size(1320, 550);
            this.Load += new System.EventHandler(this.UserControlHistoryOfFailures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryOfFailures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewHistoryOfFailures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_History;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_UsernameHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_TypeOfFailureHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_CityHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginOfFailureHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndOfFailureHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalDescriptionHistory;
    }
}
