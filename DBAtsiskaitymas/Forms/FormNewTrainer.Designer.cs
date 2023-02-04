namespace SportClub.Forms
{
    partial class FormNewTrainer
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbSport = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbClock = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbSports = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(359, 112);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 41);
            this.tbName.TabIndex = 4;
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSurname.Location = new System.Drawing.Point(359, 159);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(298, 41);
            this.tbSurname.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(186, 118);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 35);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSurname.Location = new System.Drawing.Point(155, 165);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(113, 35);
            this.lbSurname.TabIndex = 8;
            this.lbSurname.Text = "Surname";
            // 
            // lbSport
            // 
            this.lbSport.AutoSize = true;
            this.lbSport.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSport.Location = new System.Drawing.Point(120, 209);
            this.lbSport.Name = "lbSport";
            this.lbSport.Size = new System.Drawing.Size(233, 35);
            this.lbSport.TabIndex = 9;
            this.lbSport.Text = "Sport Specialization";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbClock
            // 
            this.lbClock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbClock.Location = new System.Drawing.Point(732, 19);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(238, 35);
            this.lbClock.TabIndex = 13;
            this.lbClock.Text = "0000-00-00 00:00:00";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(519, 258);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(138, 47);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbSports
            // 
            this.cbSports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSports.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSports.FormattingEnabled = true;
            this.cbSports.Location = new System.Drawing.Point(359, 209);
            this.cbSports.Name = "cbSports";
            this.cbSports.Size = new System.Drawing.Size(298, 43);
            this.cbSports.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(818, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 46);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormNewTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbSports);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbClock);
            this.Controls.Add(this.lbSport);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Name = "FormNewTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewTrainer";
            this.Load += new System.EventHandler(this.FormNewTrainer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbName;
        private TextBox tbSurname;
        private Label lbName;
        private Label lbSurname;
        private Label lbSport;
        private System.Windows.Forms.Timer timer;
        private Label lbClock;
        private Button btnRegister;
        private ComboBox cbSports;
        private Button btnBack;
    }
}