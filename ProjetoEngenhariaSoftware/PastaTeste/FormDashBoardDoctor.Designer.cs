
namespace ProjetoEngenhariaSoftware
{
    partial class FormDashBoardDoctor
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnEditPrescription = new System.Windows.Forms.Button();
            this.UserNameDoctor = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.BtnPrescriptions = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PanelMenu.Controls.Add(this.BtnLogout);
            this.PanelMenu.Controls.Add(this.btnEditPrescription);
            this.PanelMenu.Controls.Add(this.UserNameDoctor);
            this.PanelMenu.Controls.Add(this.Type);
            this.PanelMenu.Controls.Add(this.BtnPrescriptions);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1025, 142);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnEditPrescription
            // 
            this.btnEditPrescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPrescription.ForeColor = System.Drawing.Color.White;
            this.btnEditPrescription.Location = new System.Drawing.Point(597, 12);
            this.btnEditPrescription.Name = "btnEditPrescription";
            this.btnEditPrescription.Size = new System.Drawing.Size(218, 121);
            this.btnEditPrescription.TabIndex = 7;
            this.btnEditPrescription.Text = "Editar Prescrições";
            this.btnEditPrescription.UseVisualStyleBackColor = false;
            this.btnEditPrescription.Click += new System.EventHandler(this.btnEditPrescription_Click);
            // 
            // UserNameDoctor
            // 
            this.UserNameDoctor.AutoSize = true;
            this.UserNameDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameDoctor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserNameDoctor.Location = new System.Drawing.Point(220, 77);
            this.UserNameDoctor.Name = "UserNameDoctor";
            this.UserNameDoctor.Size = new System.Drawing.Size(138, 29);
            this.UserNameDoctor.TabIndex = 6;
            this.UserNameDoctor.Text = "Username";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(240, 48);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(73, 29);
            this.Type.TabIndex = 5;
            this.Type.Text = "Type";
            // 
            // BtnPrescriptions
            // 
            this.BtnPrescriptions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrescriptions.ForeColor = System.Drawing.Color.White;
            this.BtnPrescriptions.Location = new System.Drawing.Point(373, 12);
            this.BtnPrescriptions.Name = "BtnPrescriptions";
            this.BtnPrescriptions.Size = new System.Drawing.Size(218, 121);
            this.BtnPrescriptions.TabIndex = 1;
            this.BtnPrescriptions.Text = "Criar Prescrições";
            this.BtnPrescriptions.UseVisualStyleBackColor = false;
            this.BtnPrescriptions.Click += new System.EventHandler(this.BtnPrescriptions_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.Male_Doctor_512;
            this.Logo.Location = new System.Drawing.Point(23, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(173, 136);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Location = new System.Drawing.Point(0, 145);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(1025, 488);
            this.OperationsPanel.TabIndex = 1;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.logout;
            this.BtnLogout.Location = new System.Drawing.Point(966, 12);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(47, 50);
            this.BtnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLogout.TabIndex = 8;
            this.BtnLogout.TabStop = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // FormDashBoardDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 632);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FormDashBoardDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashBoardDoctor";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button BtnPrescriptions;
        private System.Windows.Forms.Panel OperationsPanel;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label UserNameDoctor;
        private System.Windows.Forms.Button btnEditPrescription;
        private System.Windows.Forms.PictureBox BtnLogout;
    }
}