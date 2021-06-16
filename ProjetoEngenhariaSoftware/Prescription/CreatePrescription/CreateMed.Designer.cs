
namespace ProjetoEngenhariaSoftware.Prescription.CreatePrescription
{
    partial class CreateMed
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
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.DosageTxtBox = new System.Windows.Forms.TextBox();
            this.FrequencyTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(210, 72);
            this.NameTxtBox.Multiline = true;
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(235, 22);
            this.NameTxtBox.TabIndex = 0;
            // 
            // DosageTxtBox
            // 
            this.DosageTxtBox.Location = new System.Drawing.Point(210, 137);
            this.DosageTxtBox.Multiline = true;
            this.DosageTxtBox.Name = "DosageTxtBox";
            this.DosageTxtBox.Size = new System.Drawing.Size(235, 22);
            this.DosageTxtBox.TabIndex = 1;
            // 
            // FrequencyTxtBox
            // 
            this.FrequencyTxtBox.Location = new System.Drawing.Point(210, 205);
            this.FrequencyTxtBox.Multiline = true;
            this.FrequencyTxtBox.Name = "FrequencyTxtBox";
            this.FrequencyTxtBox.Size = new System.Drawing.Size(235, 22);
            this.FrequencyTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dosagem (gr)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Frequência";
            // 
            // BtnAdd
            // 
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAdd.Location = new System.Drawing.Point(254, 246);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 37);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(356, 246);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(96, 37);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CreateMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 295);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FrequencyTxtBox);
            this.Controls.Add(this.DosageTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Name = "CreateMed";
            this.Text = "CreatePrescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox DosageTxtBox;
        private System.Windows.Forms.TextBox FrequencyTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
    }
}