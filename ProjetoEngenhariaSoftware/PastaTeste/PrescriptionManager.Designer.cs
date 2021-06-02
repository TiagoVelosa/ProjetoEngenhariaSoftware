
namespace ProjetoEngenhariaSoftware.PastaTeste
{
    partial class PrescriptionManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAddPrescription = new System.Windows.Forms.Button();
            this.PanelPrescriptions = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnAddPrescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 488);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(8, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 101);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit Prescription";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAddPrescription
            // 
            this.BtnAddPrescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnAddPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddPrescription.ForeColor = System.Drawing.Color.White;
            this.BtnAddPrescription.Location = new System.Drawing.Point(8, 94);
            this.BtnAddPrescription.Name = "BtnAddPrescription";
            this.BtnAddPrescription.Size = new System.Drawing.Size(192, 101);
            this.BtnAddPrescription.TabIndex = 1;
            this.BtnAddPrescription.Text = "Add Prescription";
            this.BtnAddPrescription.UseVisualStyleBackColor = false;
            this.BtnAddPrescription.Click += new System.EventHandler(this.BtnAddPrescription_Click);
            // 
            // PanelPrescriptions
            // 
            this.PanelPrescriptions.Location = new System.Drawing.Point(206, 0);
            this.PanelPrescriptions.Name = "PanelPrescriptions";
            this.PanelPrescriptions.Size = new System.Drawing.Size(816, 485);
            this.PanelPrescriptions.TabIndex = 1;
            // 
            // PrescriptionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelPrescriptions);
            this.Controls.Add(this.panel1);
            this.Name = "PrescriptionManager";
            this.Size = new System.Drawing.Size(1025, 488);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAddPrescription;
        private System.Windows.Forms.Panel PanelPrescriptions;
    }
}
