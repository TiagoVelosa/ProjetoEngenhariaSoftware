
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnTherapy = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.PictureBox();
            this.btnEditPrescription = new System.Windows.Forms.Button();
            this.UserNameDoctor = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.BtnPrescriptions = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PanelMenu.Controls.Add(this.button1);
            this.PanelMenu.Controls.Add(this.btnTherapy);
            this.PanelMenu.Controls.Add(this.BtnLogout);
            this.PanelMenu.Controls.Add(this.btnEditPrescription);
            this.PanelMenu.Controls.Add(this.UserNameDoctor);
            this.PanelMenu.Controls.Add(this.Type);
            this.PanelMenu.Controls.Add(this.BtnPrescriptions);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1028, 115);
            this.PanelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(784, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 98);
            this.button1.TabIndex = 12;
            this.button1.Text = "Consultar Prescrições";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTherapy
            // 
            this.btnTherapy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTherapy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTherapy.ForeColor = System.Drawing.Color.White;
            this.btnTherapy.Location = new System.Drawing.Point(616, 10);
            this.btnTherapy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTherapy.Name = "btnTherapy";
            this.btnTherapy.Size = new System.Drawing.Size(164, 98);
            this.btnTherapy.TabIndex = 11;
            this.btnTherapy.Text = "Sessões Terapia";
            this.btnTherapy.UseVisualStyleBackColor = false;
            this.btnTherapy.Click += new System.EventHandler(this.btnTherapy_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.logout;
            this.BtnLogout.Location = new System.Drawing.Point(989, 10);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(35, 41);
            this.BtnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLogout.TabIndex = 8;
            this.BtnLogout.TabStop = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnEditPrescription
            // 
            this.btnEditPrescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEditPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPrescription.ForeColor = System.Drawing.Color.White;
            this.btnEditPrescription.Location = new System.Drawing.Point(448, 10);
            this.btnEditPrescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditPrescription.Name = "btnEditPrescription";
            this.btnEditPrescription.Size = new System.Drawing.Size(164, 98);
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
            this.UserNameDoctor.Location = new System.Drawing.Point(165, 63);
            this.UserNameDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameDoctor.Name = "UserNameDoctor";
            this.UserNameDoctor.Size = new System.Drawing.Size(110, 25);
            this.UserNameDoctor.TabIndex = 6;
            this.UserNameDoctor.Text = "Username";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(180, 39);
            this.Type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(61, 25);
            this.Type.TabIndex = 5;
            this.Type.Text = "Type";
            // 
            // BtnPrescriptions
            // 
            this.BtnPrescriptions.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrescriptions.ForeColor = System.Drawing.Color.White;
            this.BtnPrescriptions.Location = new System.Drawing.Point(280, 10);
            this.BtnPrescriptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPrescriptions.Name = "BtnPrescriptions";
            this.BtnPrescriptions.Size = new System.Drawing.Size(164, 98);
            this.BtnPrescriptions.TabIndex = 1;
            this.BtnPrescriptions.Text = "Criar Prescrições";
            this.BtnPrescriptions.UseVisualStyleBackColor = false;
            this.BtnPrescriptions.Click += new System.EventHandler(this.BtnPrescriptions_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.Male_Doctor_512;
            this.Logo.Location = new System.Drawing.Point(17, 2);
            this.Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 110);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Location = new System.Drawing.Point(0, 118);
            this.OperationsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(1034, 396);
            this.OperationsPanel.TabIndex = 1;
            // 
            // FormDashBoardDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 514);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.PanelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDashBoardDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashBoardDoctor";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
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
        private System.Windows.Forms.Button btnTherapy;
        private System.Windows.Forms.Button button1;
    }
}