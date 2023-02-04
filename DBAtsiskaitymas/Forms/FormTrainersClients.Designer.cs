namespace SportClub.Forms
{
    partial class FormTrainersClients
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
            this.lbSelectTrainer = new System.Windows.Forms.Label();
            this.cbSelectTrainer = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShowClients = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSelectTrainer
            // 
            this.lbSelectTrainer.AutoSize = true;
            this.lbSelectTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectTrainer.Location = new System.Drawing.Point(12, 9);
            this.lbSelectTrainer.Name = "lbSelectTrainer";
            this.lbSelectTrainer.Size = new System.Drawing.Size(150, 31);
            this.lbSelectTrainer.TabIndex = 26;
            this.lbSelectTrainer.Text = "Select Trainer";
            // 
            // cbSelectTrainer
            // 
            this.cbSelectTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSelectTrainer.FormattingEnabled = true;
            this.cbSelectTrainer.Location = new System.Drawing.Point(12, 43);
            this.cbSelectTrainer.Name = "cbSelectTrainer";
            this.cbSelectTrainer.Size = new System.Drawing.Size(237, 39);
            this.cbSelectTrainer.TabIndex = 27;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(818, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 46);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShowClients
            // 
            this.btnShowClients.Location = new System.Drawing.Point(12, 88);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(136, 46);
            this.btnShowClients.TabIndex = 32;
            this.btnShowClients.Text = "Show clients";
            this.btnShowClients.UseVisualStyleBackColor = true;
            this.btnShowClients.Click += new System.EventHandler(this.btnShowClients_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.identificationNumberDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(942, 335);
            this.dataGridView1.TabIndex = 33;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(DBAtsiskaitymas.Models.Client);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 270;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // identificationNumberDataGridViewTextBoxColumn
            // 
            this.identificationNumberDataGridViewTextBoxColumn.DataPropertyName = "IdentificationNumber";
            this.identificationNumberDataGridViewTextBoxColumn.HeaderText = "IdentificationNumber";
            this.identificationNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identificationNumberDataGridViewTextBoxColumn.Name = "identificationNumberDataGridViewTextBoxColumn";
            this.identificationNumberDataGridViewTextBoxColumn.Width = 180;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.Width = 180;
            // 
            // FormTrainersClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowClients);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbSelectTrainer);
            this.Controls.Add(this.lbSelectTrainer);
            this.Name = "FormTrainersClients";
            this.Text = "TrainersClients";
            this.Load += new System.EventHandler(this.FormTrainersClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSelectTrainer;
        private ComboBox cbSelectTrainer;
        private Button btnBack;
        private Button btnShowClients;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn identificationNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private BindingSource clientBindingSource;
    }
}