namespace SportClub.Forms
{
    partial class FormEditClient
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
            this.lbSelectClient = new System.Windows.Forms.Label();
            this.cbSelectClient = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbSelectTrainer = new System.Windows.Forms.Label();
            this.cbSelectTrainer = new System.Windows.Forms.ComboBox();
            this.lbTrainersSport = new System.Windows.Forms.Label();
            this.btnAddTrainer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSelectClient
            // 
            this.lbSelectClient.AutoSize = true;
            this.lbSelectClient.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectClient.Location = new System.Drawing.Point(37, 43);
            this.lbSelectClient.Name = "lbSelectClient";
            this.lbSelectClient.Size = new System.Drawing.Size(140, 31);
            this.lbSelectClient.TabIndex = 20;
            this.lbSelectClient.Text = "Select Client";
            // 
            // cbSelectClient
            // 
            this.cbSelectClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectClient.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSelectClient.FormattingEnabled = true;
            this.cbSelectClient.Location = new System.Drawing.Point(37, 77);
            this.cbSelectClient.Name = "cbSelectClient";
            this.cbSelectClient.Size = new System.Drawing.Size(237, 39);
            this.cbSelectClient.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(818, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 46);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbSelectTrainer
            // 
            this.lbSelectTrainer.AutoSize = true;
            this.lbSelectTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSelectTrainer.Location = new System.Drawing.Point(37, 159);
            this.lbSelectTrainer.Name = "lbSelectTrainer";
            this.lbSelectTrainer.Size = new System.Drawing.Size(156, 31);
            this.lbSelectTrainer.TabIndex = 23;
            this.lbSelectTrainer.Text = "Select Trainer ";
            // 
            // cbSelectTrainer
            // 
            this.cbSelectTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSelectTrainer.FormattingEnabled = true;
            this.cbSelectTrainer.Location = new System.Drawing.Point(37, 193);
            this.cbSelectTrainer.Name = "cbSelectTrainer";
            this.cbSelectTrainer.Size = new System.Drawing.Size(237, 39);
            this.cbSelectTrainer.TabIndex = 24;
            this.cbSelectTrainer.SelectedIndexChanged += new System.EventHandler(this.cbSelectTrainer_SelectedIndexChanged);
            // 
            // lbTrainersSport
            // 
            this.lbTrainersSport.AutoSize = true;
            this.lbTrainersSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTrainersSport.Location = new System.Drawing.Point(37, 235);
            this.lbTrainersSport.Name = "lbTrainersSport";
            this.lbTrainersSport.Size = new System.Drawing.Size(80, 31);
            this.lbTrainersSport.TabIndex = 25;
            this.lbTrainersSport.Text = "Sport: ";
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.Location = new System.Drawing.Point(37, 269);
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.Size = new System.Drawing.Size(152, 46);
            this.btnAddTrainer.TabIndex = 26;
            this.btnAddTrainer.Text = "Add trainer";
            this.btnAddTrainer.UseVisualStyleBackColor = true;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // FormEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.btnAddTrainer);
            this.Controls.Add(this.lbTrainersSport);
            this.Controls.Add(this.cbSelectTrainer);
            this.Controls.Add(this.lbSelectTrainer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbSelectClient);
            this.Controls.Add(this.lbSelectClient);
            this.Name = "FormEditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditClient";
            this.Load += new System.EventHandler(this.FormEditClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSelectClient;
        private ComboBox cbSelectClient;
        private Button btnBack;
        private Label lbSelectTrainer;
        private ComboBox cbSelectTrainer;
        private Label lbTrainersSport;
        private Button btnAddTrainer;
        private CheckBox checkBox1;
    }
}