namespace SportClub.Forms
{
    partial class FormNewSport
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbId.Location = new System.Drawing.Point(383, 172);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(298, 41);
            this.tbId.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(383, 231);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(298, 41);
            this.tbName.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(295, 237);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 35);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Name";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbId.Location = new System.Drawing.Point(295, 175);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(40, 35);
            this.lbId.TabIndex = 9;
            this.lbId.Text = "ID";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(543, 278);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(138, 47);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(818, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 46);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormNewSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Name = "FormNewSport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewSport";
            this.Load += new System.EventHandler(this.FormNewSport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbId;
        private TextBox tbName;
        private Label lbName;
        private Label lbId;
        private Button btnRegister;
        private Button btnBack;
    }
}