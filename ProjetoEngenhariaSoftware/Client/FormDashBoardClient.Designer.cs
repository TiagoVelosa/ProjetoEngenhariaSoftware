
namespace ProjetoEngenhariaSoftware
{
    partial class FormDashBoardClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.PictureBox();
            this.BtnVisability = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.UserNameClient = new System.Windows.Forms.Label();
            this.BtnPrescriptions = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnVisability);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.UserNameClient);
            this.panel1.Controls.Add(this.BtnPrescriptions);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 142);
            this.panel1.TabIndex = 5;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.logout;
            this.BtnLogout.Location = new System.Drawing.Point(969, 7);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(44, 50);
            this.BtnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.TabStop = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnVisability
            // 
            this.BtnVisability.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnVisability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVisability.ForeColor = System.Drawing.Color.White;
            this.BtnVisability.Location = new System.Drawing.Point(602, 12);
            this.BtnVisability.Name = "BtnVisability";
            this.BtnVisability.Size = new System.Drawing.Size(218, 121);
            this.BtnVisability.TabIndex = 5;
            this.BtnVisability.Text = "Atribuir Visibilidade";
            this.BtnVisability.UseVisualStyleBackColor = false;
            this.BtnVisability.Click += new System.EventHandler(this.BtnVisability_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(237, 28);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(73, 29);
            this.Type.TabIndex = 4;
            this.Type.Text = "Type";
            // 
            // UserNameClient
            // 
            this.UserNameClient.AutoSize = true;
            this.UserNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserNameClient.Location = new System.Drawing.Point(210, 67);
            this.UserNameClient.Name = "UserNameClient";
            this.UserNameClient.Size = new System.Drawing.Size(138, 29);
            this.UserNameClient.TabIndex = 3;
            this.UserNameClient.Text = "Username";
            // 
            // BtnPrescriptions
            // 
            this.BtnPrescriptions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrescriptions.ForeColor = System.Drawing.Color.White;
            this.BtnPrescriptions.Location = new System.Drawing.Point(378, 12);
            this.BtnPrescriptions.Name = "BtnPrescriptions";
            this.BtnPrescriptions.Size = new System.Drawing.Size(218, 121);
            this.BtnPrescriptions.TabIndex = 2;
            this.BtnPrescriptions.Text = "Consultar Prescrições";
            this.BtnPrescriptions.UseVisualStyleBackColor = false;
            this.BtnPrescriptions.Click += new System.EventHandler(this.BtnPrescriptions_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.patient;
            this.Logo.Location = new System.Drawing.Point(12, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(173, 136);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Location = new System.Drawing.Point(0, 146);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(1025, 487);
            this.OperationsPanel.TabIndex = 6;
            // 
            // FormDashBoardClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 632);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "FormDashBoardClient";
            this.Text = "FormDashBoardClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button BtnPrescriptions;
        private System.Windows.Forms.Panel OperationsPanel;
        private System.Windows.Forms.Label UserNameClient;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Button BtnVisability;
        private System.Windows.Forms.PictureBox BtnLogout;
    }
}