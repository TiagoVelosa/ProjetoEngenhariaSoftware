
namespace ProjetoEngenhariaSoftware.Prescription.CreatePrescription
{
    partial class CreateExercise
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
            this.DateTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(199, 60);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(235, 22);
            this.NameTxtBox.TabIndex = 0;
            // 
            // DateTxtBox
            // 
            this.DateTxtBox.Location = new System.Drawing.Point(199, 151);
            this.DateTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTxtBox.Name = "DateTxtBox";
            this.DateTxtBox.Size = new System.Drawing.Size(235, 22);
            this.DateTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(53, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Sugerida\r\n(\"HH:mm\")\r\n";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnAdd.Location = new System.Drawing.Point(236, 234);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 37);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Adicionar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnCancel.Location = new System.Drawing.Point(339, 234);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(96, 37);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // CreateExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 295);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateExercise";
            this.Text = "CreateExercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox DateTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
    }
}