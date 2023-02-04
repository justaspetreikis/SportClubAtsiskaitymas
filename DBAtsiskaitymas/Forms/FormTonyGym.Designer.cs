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
            this.btnTrainersClients = new System.Windows.Forms.Button();
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
            this.labelSportClubName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSportClubName.Font = new System.Drawing.Font("Goudy Stout", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSportClubName.ForeColor = System.Drawing.Color.Red;
            this.labelSportClubName.Location = new System.Drawing.Point(110, 20);
            this.labelSportClubName.Name = "labelSportClubName";
            this.labelSportClubName.Size = new System.Drawing.Size(795, 91);
            this.labelSportClubName.TabIndex = 0;
            this.labelSportClubName.Text = "SPORT CLUB";
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
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnNewTrainer
            // 
            this.btnNewTrainer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewTrainer.Location = new System.Drawing.Point(12, 343);
            this.btnNewTrainer.Name = "btnNewTrainer";
            this.btnNewTrainer.Size = new System.Drawing.Size(470, 100);
            this.btnNewTrainer.TabIndex = 2;
            this.btnNewTrainer.Text = "New Trainer Register";
            this.btnNewTrainer.UseVisualStyleBackColor = true;
            this.btnNewTrainer.Click += new System.EventHandler(this.btnNewTrainer_Click);
            // 
            // btnNewSport
            // 
            this.btnNewSport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNewSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewSport.Location = new System.Drawing.Point(12, 237);
            this.btnNewSport.Name = "btnNewSport";
            this.btnNewSport.Size = new System.Drawing.Size(470, 100);
            this.btnNewSport.TabIndex = 3;
            this.btnNewSport.Text = "Add New Sport";
            this.btnNewSport.UseVisualStyleBackColor = true;
            this.btnNewSport.Click += new System.EventHandler(this.btnNewSport_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditClient.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditClient.Location = new System.Drawing.Point(500, 131);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(470, 100);
            this.btnEditClient.TabIndex = 4;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnEditTrainer
            // 
            this.btnEditTrainer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditTrainer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditTrainer.Location = new System.Drawing.Point(500, 343);
            this.btnEditTrainer.Name = "btnEditTrainer";
            this.btnEditTrainer.Size = new System.Drawing.Size(470, 100);
            this.btnEditTrainer.TabIndex = 5;
            this.btnEditTrainer.Text = "Edit Trainer";
            this.btnEditTrainer.UseVisualStyleBackColor = true;
            this.btnEditTrainer.Click += new System.EventHandler(this.btnEditTrainer_Click);
            // 
            // btnEditSport
            // 
            this.btnEditSport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditSport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSport.Location = new System.Drawing.Point(500, 237);
            this.btnEditSport.Name = "btnEditSport";
            this.btnEditSport.Size = new System.Drawing.Size(470, 100);
            this.btnEditSport.TabIndex = 6;
            this.btnEditSport.Text = "Edit Sport";
            this.btnEditSport.UseVisualStyleBackColor = true;
            this.btnEditSport.Click += new System.EventHandler(this.btnEditSport_Click);
            // 
            // btnClientsInfo
            // 
            this.btnClientsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClientsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientsInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClientsInfo.Location = new System.Drawing.Point(12, 449);
            this.btnClientsInfo.Name = "btnClientsInfo";
            this.btnClientsInfo.Size = new System.Drawing.Size(315, 80);
            this.btnClientsInfo.TabIndex = 7;
            this.btnClientsInfo.Text = "Clients Info";
            this.btnClientsInfo.UseVisualStyleBackColor = false;
            this.btnClientsInfo.Click += new System.EventHandler(this.btnClientsInfo_Click);
            // 
            // btnTrainersInfo
            // 
            this.btnTrainersInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTrainersInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrainersInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrainersInfo.Location = new System.Drawing.Point(334, 449);
            this.btnTrainersInfo.Name = "btnTrainersInfo";
            this.btnTrainersInfo.Size = new System.Drawing.Size(315, 80);
            this.btnTrainersInfo.TabIndex = 9;
            this.btnTrainersInfo.Text = "Trainers Info";
            this.btnTrainersInfo.UseVisualStyleBackColor = false;
            this.btnTrainersInfo.Click += new System.EventHandler(this.btnTrainersInfo_Click);
            // 
            // btnTrainersClients
            // 
            this.btnTrainersClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrainersClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrainersClients.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrainersClients.Location = new System.Drawing.Point(655, 449);
            this.btnTrainersClients.Name = "btnTrainersClients";
            this.btnTrainersClients.Size = new System.Drawing.Size(315, 80);
            this.btnTrainersClients.TabIndex = 10;
            this.btnTrainersClients.Text = "Clients by trainer";
            this.btnTrainersClients.UseVisualStyleBackColor = false;
            this.btnTrainersClients.Click += new System.EventHandler(this.btnTrainersClients_Click);
            // 
            // TonyGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.btnTrainersClients);
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
        private Button btnTrainersClients;
    }
}