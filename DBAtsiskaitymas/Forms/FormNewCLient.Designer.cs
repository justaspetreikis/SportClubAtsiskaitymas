namespace SportClub.Forms
{
    partial class FormNewClient
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbIdNumber = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbIdNumber = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbClock = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(302, 127);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 35);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSurname.Location = new System.Drawing.Point(271, 193);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(113, 35);
            this.lbSurname.TabIndex = 1;
            this.lbSurname.Text = "Surname";
            // 
            // lbIdNumber
            // 
            this.lbIdNumber.AutoSize = true;
            this.lbIdNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdNumber.Location = new System.Drawing.Point(245, 263);
            this.lbIdNumber.Name = "lbIdNumber";
            this.lbIdNumber.Size = new System.Drawing.Size(139, 35);
            this.lbIdNumber.TabIndex = 2;
            this.lbIdNumber.Text = "ID Number";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(390, 121);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 41);
            this.tbName.TabIndex = 3;
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSurname.Location = new System.Drawing.Point(390, 187);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(298, 41);
            this.tbSurname.TabIndex = 4;
            // 
            // tbIdNumber
            // 
            this.tbIdNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbIdNumber.Location = new System.Drawing.Point(390, 257);
            this.tbIdNumber.MaxLength = 11;
            this.tbIdNumber.Name = "tbIdNumber";
            this.tbIdNumber.Size = new System.Drawing.Size(298, 41);
            this.tbIdNumber.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(550, 342);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(138, 47);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbClock
            // 
            this.lbClock.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbClock.Location = new System.Drawing.Point(708, 21);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(238, 35);
            this.lbClock.TabIndex = 12;
            this.lbClock.Text = "0000-00-00 00:00:00";
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
            // FormNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbClock);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbIdNumber);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbIdNumber);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Name = "FormNewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbName;
        private Label lbSurname;
        private Label lbIdNumber;
        private TextBox tbName;
        private TextBox tbSurname;
        private TextBox tbIdNumber;
        private Button btnRegister;
        private System.Windows.Forms.Timer timer;
        private Label lbClock;
        private Button btnBack;
    }
}