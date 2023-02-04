namespace SportClub.Forms
{
    partial class FormTrainersInfo
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
            this.lbSelectSport = new System.Windows.Forms.Label();
            this.cbSelectSport = new System.Windows.Forms.ComboBox();
            this.btnShowAllTrainers = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSelectSport
            // 
            this.lbSelectSport.AutoSize = true;
            this.lbSelectSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectSport.Location = new System.Drawing.Point(12, 9);
            this.lbSelectSport.Name = "lbSelectSport";
            this.lbSelectSport.Size = new System.Drawing.Size(136, 31);
            this.lbSelectSport.TabIndex = 25;
            this.lbSelectSport.Text = "Select Sport";
            // 
            // cbSelectSport
            // 
            this.cbSelectSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSelectSport.FormattingEnabled = true;
            this.cbSelectSport.Location = new System.Drawing.Point(12, 43);
            this.cbSelectSport.Name = "cbSelectSport";
            this.cbSelectSport.Size = new System.Drawing.Size(237, 39);
            this.cbSelectSport.TabIndex = 26;
            // 
            // btnShowAllTrainers
            // 
            this.btnShowAllTrainers.Location = new System.Drawing.Point(12, 88);
            this.btnShowAllTrainers.Name = "btnShowAllTrainers";
            this.btnShowAllTrainers.Size = new System.Drawing.Size(136, 46);
            this.btnShowAllTrainers.TabIndex = 28;
            this.btnShowAllTrainers.Text = "Show all trainers";
            this.btnShowAllTrainers.UseVisualStyleBackColor = true;
            this.btnShowAllTrainers.Click += new System.EventHandler(this.btnShowAllTrainers_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.sportIdDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.trainerBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 140);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(747, 343);
            this.dataGridView.TabIndex = 29;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 290;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // sportIdDataGridViewTextBoxColumn
            // 
            this.sportIdDataGridViewTextBoxColumn.DataPropertyName = "SportId";
            this.sportIdDataGridViewTextBoxColumn.HeaderText = "SportId";
            this.sportIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sportIdDataGridViewTextBoxColumn.Name = "sportIdDataGridViewTextBoxColumn";
            this.sportIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataSource = typeof(DBAtsiskaitymas.Models.Trainer);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(818, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 46);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormTrainersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnShowAllTrainers);
            this.Controls.Add(this.cbSelectSport);
            this.Controls.Add(this.lbSelectSport);
            this.Name = "FormTrainersInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainersInfo";
            this.Load += new System.EventHandler(this.FormTrainersInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSelectSport;
        private ComboBox cbSelectSport;
        private Button btnShowAllTrainers;
        private DataGridView dataGridView;
        private Button btnBack;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sportIdDataGridViewTextBoxColumn;
        private BindingSource trainerBindingSource;
    }
}