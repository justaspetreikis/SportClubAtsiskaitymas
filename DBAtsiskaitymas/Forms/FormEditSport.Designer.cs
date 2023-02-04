namespace SportClub.Forms
{
    partial class FormEditSport
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
            this.cbSelectSport = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbSelectSport = new System.Windows.Forms.Label();
            this.lbSelectTrainer = new System.Windows.Forms.Label();
            this.cb_SelectTrainer = new System.Windows.Forms.ComboBox();
            this.lbSelectClients = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.clbClients = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cbSelectSport
            // 
            this.cbSelectSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSelectSport.FormattingEnabled = true;
            this.cbSelectSport.Location = new System.Drawing.Point(12, 43);
            this.cbSelectSport.Name = "cbSelectSport";
            this.cbSelectSport.Size = new System.Drawing.Size(237, 39);
            this.cbSelectSport.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(818, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 46);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbSelectSport
            // 
            this.lbSelectSport.AutoSize = true;
            this.lbSelectSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectSport.Location = new System.Drawing.Point(12, 9);
            this.lbSelectSport.Name = "lbSelectSport";
            this.lbSelectSport.Size = new System.Drawing.Size(136, 31);
            this.lbSelectSport.TabIndex = 19;
            this.lbSelectSport.Text = "Select Sport";
            // 
            // lbSelectTrainer
            // 
            this.lbSelectTrainer.AutoSize = true;
            this.lbSelectTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectTrainer.Location = new System.Drawing.Point(12, 103);
            this.lbSelectTrainer.Name = "lbSelectTrainer";
            this.lbSelectTrainer.Size = new System.Drawing.Size(510, 31);
            this.lbSelectTrainer.TabIndex = 20;
            this.lbSelectTrainer.Text = "Select Trainer (shows only trainers without Sport)";
            // 
            // cb_SelectTrainer
            // 
            this.cb_SelectTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SelectTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_SelectTrainer.FormattingEnabled = true;
            this.cb_SelectTrainer.Location = new System.Drawing.Point(12, 137);
            this.cb_SelectTrainer.Name = "cb_SelectTrainer";
            this.cb_SelectTrainer.Size = new System.Drawing.Size(237, 39);
            this.cb_SelectTrainer.TabIndex = 21;
            // 
            // lbSelectClients
            // 
            this.lbSelectClients.AutoSize = true;
            this.lbSelectClients.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectClients.Location = new System.Drawing.Point(12, 203);
            this.lbSelectClients.Name = "lbSelectClients";
            this.lbSelectClients.Size = new System.Drawing.Size(150, 31);
            this.lbSelectClients.TabIndex = 22;
            this.lbSelectClients.Text = "Select Clients";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 447);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 46);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // clbClients
            // 
            this.clbClients.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbClients.FormattingEnabled = true;
            this.clbClients.Location = new System.Drawing.Point(12, 237);
            this.clbClients.Name = "clbClients";
            this.clbClients.Size = new System.Drawing.Size(237, 204);
            this.clbClients.TabIndex = 27;
            // 
            // FormEditSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.clbClients);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbSelectClients);
            this.Controls.Add(this.cb_SelectTrainer);
            this.Controls.Add(this.lbSelectTrainer);
            this.Controls.Add(this.lbSelectSport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbSelectSport);
            this.Name = "FormEditSport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditSport";
            this.Load += new System.EventHandler(this.FormEditSport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbSelectSport;
        private Button btnBack;
        private Label lbSelectSport;
        private Label lbSelectTrainer;
        private ComboBox cb_SelectTrainer;
        private Label lbSelectClients;
        private Button btnEdit;
        private CheckedListBox clbClients;
    }
}