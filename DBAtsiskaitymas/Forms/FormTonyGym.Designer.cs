namespace DBAtsiskaitymas
{
    partial class TonyGym
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSportClubName = new System.Windows.Forms.Label();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnNewTrainer = new System.Windows.Forms.Button();
            this.btnNewSport = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnEditTrainer = new System.Windows.Forms.Button();
            this.btnEditSport = new System.Windows.Forms.Button();
            this.btnClientsInfo = new System.Windows.Forms.Button();
            this.btnTrainersInfo = new System.Windows.Forms.Button();
            this.btnSportsInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelSportClubName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 125);
            this.panel1.TabIndex = 0;
            // 
            // labelSportClubName
            // 
            this.labelSportClubName.Font = new System.Drawing.Font("Goudy Stout", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSportClubName.ForeColor = System.Drawing.Color.Red;
            this.labelSportClubName.Location = new System.Drawing.Point(3, 9);
            this.labelSportClubName.Name = "labelSportClubName";
            this.labelSportClubName.Size = new System.Drawing.Size(967, 103);
            this.labelSportClubName.TabIndex = 0;
            this.labelSportClubName.Text = "TONY GYM";
            this.labelSportClubName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewClient
            // 
            this.btnNewClient.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewClient.Location = new System.Drawing.Point(12, 131);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(470, 100);
            this.btnNewClient.TabIndex = 1;
            this.btnNewClient.Text = "New Client Register";
            this.btnNewClient.UseVisualStyleBackColor = true;
            // 
            // btnNewTrainer
            // 
            this.btnNewTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewTrainer.Location = new System.Drawing.Point(12, 343);
            this.btnNewTrainer.Name = "btnNewTrainer";
            this.btnNewTrainer.Size = new System.Drawing.Size(470, 100);
            this.btnNewTrainer.TabIndex = 2;
            this.btnNewTrainer.Text = "New Trainer Register";
            this.btnNewTrainer.UseVisualStyleBackColor = true;
            // 
            // btnNewSport
            // 
            this.btnNewSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewSport.Location = new System.Drawing.Point(12, 237);
            this.btnNewSport.Name = "btnNewSport";
            this.btnNewSport.Size = new System.Drawing.Size(470, 100);
            this.btnNewSport.TabIndex = 3;
            this.btnNewSport.Text = "Add New Sport";
            this.btnNewSport.UseVisualStyleBackColor = true;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditClient.Location = new System.Drawing.Point(500, 131);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(470, 100);
            this.btnEditClient.TabIndex = 4;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = true;
            // 
            // btnEditTrainer
            // 
            this.btnEditTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTrainer.Location = new System.Drawing.Point(500, 343);
            this.btnEditTrainer.Name = "btnEditTrainer";
            this.btnEditTrainer.Size = new System.Drawing.Size(470, 100);
            this.btnEditTrainer.TabIndex = 5;
            this.btnEditTrainer.Text = "Edit Trainer";
            this.btnEditTrainer.UseVisualStyleBackColor = true;
            // 
            // btnEditSport
            // 
            this.btnEditSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSport.Location = new System.Drawing.Point(500, 237);
            this.btnEditSport.Name = "btnEditSport";
            this.btnEditSport.Size = new System.Drawing.Size(470, 100);
            this.btnEditSport.TabIndex = 6;
            this.btnEditSport.Text = "Edit Sport";
            this.btnEditSport.UseVisualStyleBackColor = true;
            // 
            // btnClientsInfo
            // 
            this.btnClientsInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientsInfo.Location = new System.Drawing.Point(12, 449);
            this.btnClientsInfo.Name = "btnClientsInfo";
            this.btnClientsInfo.Size = new System.Drawing.Size(315, 80);
            this.btnClientsInfo.TabIndex = 7;
            this.btnClientsInfo.Text = "Clients Info";
            this.btnClientsInfo.UseVisualStyleBackColor = true;
            this.btnClientsInfo.Click += new System.EventHandler(this.btnClientsInfo_Click);
            // 
            // btnTrainersInfo
            // 
            this.btnTrainersInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrainersInfo.Location = new System.Drawing.Point(333, 449);
            this.btnTrainersInfo.Name = "btnTrainersInfo";
            this.btnTrainersInfo.Size = new System.Drawing.Size(315, 80);
            this.btnTrainersInfo.TabIndex = 8;
            this.btnTrainersInfo.Text = "Trainers Info";
            this.btnTrainersInfo.UseVisualStyleBackColor = true;
            // 
            // btnSportsInfo
            // 
            this.btnSportsInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSportsInfo.Location = new System.Drawing.Point(655, 449);
            this.btnSportsInfo.Name = "btnSportsInfo";
            this.btnSportsInfo.Size = new System.Drawing.Size(315, 80);
            this.btnSportsInfo.TabIndex = 9;
            this.btnSportsInfo.Text = "Sports Info";
            this.btnSportsInfo.UseVisualStyleBackColor = true;
            // 
            // TonyGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.btnSportsInfo);
            this.Controls.Add(this.btnTrainersInfo);
            this.Controls.Add(this.btnClientsInfo);
            this.Controls.Add(this.btnEditSport);
            this.Controls.Add(this.btnEditTrainer);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnNewSport);
            this.Controls.Add(this.btnNewTrainer);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.panel1);
            this.Name = "TonyGym";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tony GYM";
            this.Load += new System.EventHandler(this.TonyGym_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label labelSportClubName;
        private Button btnNewClient;
        private Button btnNewTrainer;
        private Button btnNewSport;
        private Button btnEditClient;
        private Button btnEditTrainer;
        private Button btnEditSport;
        private Button btnClientsInfo;
        private Button btnTrainersInfo;
        private Button btnSportsInfo;
    }
}