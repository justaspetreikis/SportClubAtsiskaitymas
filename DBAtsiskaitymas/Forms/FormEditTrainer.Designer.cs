namespace SportClub.Forms
{
    partial class FormEditTrainer
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
            this.lbSelectTrainer = new System.Windows.Forms.Label();
            this.cbSelectTrainer = new System.Windows.Forms.ComboBox();
            this.lbSelectSport = new System.Windows.Forms.Label();
            this.cbSelectSport = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.clbClients = new System.Windows.Forms.CheckedListBox();
            this.lbSelectClients = new System.Windows.Forms.Label();
            this.lbTrainersSport = new System.Windows.Forms.Label();
            this.btnChangeAndAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSelectTrainer
            // 
            this.lbSelectTrainer.AutoSize = true;
            this.lbSelectTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectTrainer.Location = new System.Drawing.Point(28, 33);
            this.lbSelectTrainer.Name = "lbSelectTrainer";
            this.lbSelectTrainer.Size = new System.Drawing.Size(150, 31);
            this.lbSelectTrainer.TabIndex = 21;
            this.lbSelectTrainer.Text = "Select Trainer";
            // 
            // cbSelectTrainer
            // 
            this.cbSelectTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSelectTrainer.FormattingEnabled = true;
            this.cbSelectTrainer.Location = new System.Drawing.Point(28, 67);
            this.cbSelectTrainer.Name = "cbSelectTrainer";
            this.cbSelectTrainer.Size = new System.Drawing.Size(237, 39);
            this.cbSelectTrainer.TabIndex = 22;
            this.cbSelectTrainer.SelectedIndexChanged += new System.EventHandler(this.cbSelectTrainer_SelectedIndexChanged);
            // 
            // lbSelectSport
            // 
            this.lbSelectSport.AutoSize = true;
            this.lbSelectSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectSport.Location = new System.Drawing.Point(28, 161);
            this.lbSelectSport.Name = "lbSelectSport";
            this.lbSelectSport.Size = new System.Drawing.Size(136, 31);
            this.lbSelectSport.TabIndex = 23;
            this.lbSelectSport.Text = "Select Sport";
            // 
            // cbSelectSport
            // 
            this.cbSelectSport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSelectSport.FormattingEnabled = true;
            this.cbSelectSport.Location = new System.Drawing.Point(28, 195);
            this.cbSelectSport.Name = "cbSelectSport";
            this.cbSelectSport.Size = new System.Drawing.Size(237, 39);
            this.cbSelectSport.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(818, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 46);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // clbClients
            // 
            this.clbClients.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbClients.FormattingEnabled = true;
            this.clbClients.Location = new System.Drawing.Point(28, 285);
            this.clbClients.Name = "clbClients";
            this.clbClients.Size = new System.Drawing.Size(237, 204);
            this.clbClients.TabIndex = 26;
            // 
            // lbSelectClients
            // 
            this.lbSelectClients.AutoSize = true;
            this.lbSelectClients.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectClients.Location = new System.Drawing.Point(28, 251);
            this.lbSelectClients.Name = "lbSelectClients";
            this.lbSelectClients.Size = new System.Drawing.Size(150, 31);
            this.lbSelectClients.TabIndex = 27;
            this.lbSelectClients.Text = "Select Clients";
            // 
            // lbTrainersSport
            // 
            this.lbTrainersSport.AutoSize = true;
            this.lbTrainersSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTrainersSport.Location = new System.Drawing.Point(28, 109);
            this.lbTrainersSport.Name = "lbTrainersSport";
            this.lbTrainersSport.Size = new System.Drawing.Size(80, 31);
            this.lbTrainersSport.TabIndex = 28;
            this.lbTrainersSport.Text = "Sport: ";
            // 
            // btnChangeAndAdd
            // 
            this.btnChangeAndAdd.Location = new System.Drawing.Point(28, 495);
            this.btnChangeAndAdd.Name = "btnChangeAndAdd";
            this.btnChangeAndAdd.Size = new System.Drawing.Size(237, 46);
            this.btnChangeAndAdd.TabIndex = 29;
            this.btnChangeAndAdd.Text = "Change Sport and Add Clients";
            this.btnChangeAndAdd.UseVisualStyleBackColor = true;
            this.btnChangeAndAdd.Click += new System.EventHandler(this.btnChangeAndAdd_Click);
            // 
            // FormEditTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.btnChangeAndAdd);
            this.Controls.Add(this.lbTrainersSport);
            this.Controls.Add(this.lbSelectClients);
            this.Controls.Add(this.clbClients);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbSelectSport);
            this.Controls.Add(this.lbSelectSport);
            this.Controls.Add(this.cbSelectTrainer);
            this.Controls.Add(this.lbSelectTrainer);
            this.Name = "FormEditTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTrainer";
            this.Load += new System.EventHandler(this.FormEditTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSelectTrainer;
        private ComboBox cbSelectTrainer;
        private Label lbSelectSport;
        private ComboBox cbSelectSport;
        private Button btnBack;
        private CheckedListBox clbClients;
        private Label lbSelectClients;
        private Label lbTrainersSport;
        private Button btnChangeAndAdd;
    }
}