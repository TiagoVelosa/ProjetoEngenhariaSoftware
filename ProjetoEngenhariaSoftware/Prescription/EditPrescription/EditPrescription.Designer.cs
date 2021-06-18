
namespace ProjetoEngenhariaSoftware.Prescription
{
    partial class EditPrescription
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
            this.comboBoxPrescription = new System.Windows.Forms.ComboBox();
            this.BtnLoadPrescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPrescription
            // 
            this.comboBoxPrescription.FormattingEnabled = true;
            this.comboBoxPrescription.Location = new System.Drawing.Point(263, 21);
            this.comboBoxPrescription.Name = "comboBoxPrescription";
            this.comboBoxPrescription.Size = new System.Drawing.Size(454, 24);
            this.comboBoxPrescription.TabIndex = 0;
            // 
            // BtnLoadPrescription
            // 
            this.BtnLoadPrescription.Location = new System.Drawing.Point(743, 21);
            this.BtnLoadPrescription.Name = "BtnLoadPrescription";
            this.BtnLoadPrescription.Size = new System.Drawing.Size(232, 23);
            this.BtnLoadPrescription.TabIndex = 1;
            this.BtnLoadPrescription.Text = "Carregar";
            this.BtnLoadPrescription.UseVisualStyleBackColor = true;
            // 
            // EditPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLoadPrescription);
            this.Controls.Add(this.comboBoxPrescription);
            this.Name = "EditPrescription";
            this.Size = new System.Drawing.Size(1025, 485);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPrescription;
        private System.Windows.Forms.Button BtnLoadPrescription;
    }
}
