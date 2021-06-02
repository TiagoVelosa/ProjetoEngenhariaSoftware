
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BtnPrescriptions = new System.Windows.Forms.Button();
            this.OperationsPanel = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PanelMenu.Controls.Add(this.BtnPrescriptions);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1025, 142);
            this.PanelMenu.TabIndex = 0;
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
            // BtnPrescriptions
            // 
            this.BtnPrescriptions.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrescriptions.ForeColor = System.Drawing.Color.White;
            this.BtnPrescriptions.Location = new System.Drawing.Point(212, 12);
            this.BtnPrescriptions.Name = "BtnPrescriptions";
            this.BtnPrescriptions.Size = new System.Drawing.Size(218, 121);
            this.BtnPrescriptions.TabIndex = 1;
            this.BtnPrescriptions.Text = "Prescrições";
            this.BtnPrescriptions.UseVisualStyleBackColor = false;
            // 
            // OperationsPanel
            // 
            this.OperationsPanel.Location = new System.Drawing.Point(0, 145);
            this.OperationsPanel.Name = "OperationsPanel";
            this.OperationsPanel.Size = new System.Drawing.Size(1025, 488);
            this.OperationsPanel.TabIndex = 1;
            // 
            // FormDashBoardDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 632);
            this.Controls.Add(this.OperationsPanel);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FormDashBoardDoctor";
            this.Text = "FormDashBoardDoctor";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button BtnPrescriptions;
        private System.Windows.Forms.Panel OperationsPanel;
    }
}