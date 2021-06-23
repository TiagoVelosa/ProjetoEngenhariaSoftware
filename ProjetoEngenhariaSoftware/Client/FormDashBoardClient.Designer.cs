
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
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnVisability);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.UserNameClient);
            this.panel1.Controls.Add(this.BtnPrescriptions);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 115);
            this.panel1.TabIndex = 5;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.logout;
            this.BtnLogout.Location = new System.Drawing.Point(727, 6);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(33, 41);
            this.BtnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.TabStop = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnVisability
            // 
            this.BtnVisability.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnVisability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVisability.ForeColor = System.Drawing.Color.White;
            this.BtnVisability.Location = new System.Drawing.Point(452, 10);
            this.BtnVisability.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVisability.Name = "BtnVisability";
            this.BtnVisability.Size = new System.Drawing.Size(164, 98);
            this.BtnVisability.TabIndex = 5;
            this.BtnVisability.Text = "Atribuir Visibilidade";
            this.BtnVisability.UseVisualStyleBackColor = false;
            this.BtnVisability.Click += new System.EventHandler(this.BtnVisability_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(158, 23);
            this.Type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(61, 25);
            this.Type.TabIndex = 4;
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameClient
            // 
            this.UserNameClient.AutoSize = true;
            this.UserNameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserNameClient.Location = new System.Drawing.Point(158, 54);
            this.UserNameClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameClient.Name = "UserNameClient";
            this.UserNameClient.Size = new System.Drawing.Size(110, 25);
            this.UserNameClient.TabIndex = 3;
            this.UserNameClient.Text = "Username";
            this.UserNameClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPrescriptions
            // 
            this.BtnPrescriptions.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrescriptions.ForeColor = System.Drawing.Color.White;
            this.BtnPrescriptions.Location = new System.Drawing.Point(284, 10);
            this.BtnPrescriptions.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPrescriptions.Name = "BtnPrescriptions";
            this.BtnPrescriptions.Size = new System.Drawing.Size(164, 98);
            this.BtnPrescriptions.TabIndex = 2;
            this.BtnPrescriptions.Text = "Consultar Prescrições";
            this.BtnPrescriptions.UseVisualStyleBackColor = false;
            this.BtnPrescriptions.Click += new System.EventHandler(this.BtnPrescriptions_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.patient;
            this.Logo.Location = new System.Drawing.Point(9, 2);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 110);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Location = new System.Drawing.Point(0, 119);
            this.OperationsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(769, 396);
            this.OperationsPanel.TabIndex = 6;
            // 
            // FormDashBoardClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 514);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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