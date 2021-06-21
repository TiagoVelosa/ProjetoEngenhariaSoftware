
namespace ProjetoEngenhariaSoftware.Client
{
    partial class GivePermission
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
            this.checkedListBoxMeds = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxExercises = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxTreatments = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPrescriptions = new System.Windows.Forms.ComboBox();
            this.BtnLoadPrescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxMeds
            // 
            this.checkedListBoxMeds.FormattingEnabled = true;
            this.checkedListBoxMeds.Location = new System.Drawing.Point(509, 43);
            this.checkedListBoxMeds.Name = "checkedListBoxMeds";
            this.checkedListBoxMeds.Size = new System.Drawing.Size(340, 123);
            this.checkedListBoxMeds.TabIndex = 0;
            // 
            // checkedListBoxExercises
            // 
            this.checkedListBoxExercises.FormattingEnabled = true;
            this.checkedListBoxExercises.Location = new System.Drawing.Point(509, 172);
            this.checkedListBoxExercises.Name = "checkedListBoxExercises";
            this.checkedListBoxExercises.Size = new System.Drawing.Size(340, 123);
            this.checkedListBoxExercises.TabIndex = 1;
            // 
            // checkedListBoxTreatments
            // 
            this.checkedListBoxTreatments.FormattingEnabled = true;
            this.checkedListBoxTreatments.Location = new System.Drawing.Point(509, 301);
            this.checkedListBoxTreatments.Name = "checkedListBoxTreatments";
            this.checkedListBoxTreatments.Size = new System.Drawing.Size(340, 123);
            this.checkedListBoxTreatments.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medicamentos Privados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exercícios Privados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tratamentos Privados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atribuir Visibilidade";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prescrições";
            // 
            // comboBoxPrescriptions
            // 
            this.comboBoxPrescriptions.FormattingEnabled = true;
            this.comboBoxPrescriptions.Location = new System.Drawing.Point(52, 133);
            this.comboBoxPrescriptions.Name = "comboBoxPrescriptions";
            this.comboBoxPrescriptions.Size = new System.Drawing.Size(197, 24);
            this.comboBoxPrescriptions.TabIndex = 8;
            // 
            // BtnLoadPrescription
            // 
            this.BtnLoadPrescription.Location = new System.Drawing.Point(52, 164);
            this.BtnLoadPrescription.Name = "BtnLoadPrescription";
            this.BtnLoadPrescription.Size = new System.Drawing.Size(197, 45);
            this.BtnLoadPrescription.TabIndex = 9;
            this.BtnLoadPrescription.Text = "Carregar Prescrição";
            this.BtnLoadPrescription.UseVisualStyleBackColor = true;
            this.BtnLoadPrescription.Click += new System.EventHandler(this.BtnLoadPrescription_Click);
            // 
            // GivePermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLoadPrescription);
            this.Controls.Add(this.comboBoxPrescriptions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxTreatments);
            this.Controls.Add(this.checkedListBoxExercises);
            this.Controls.Add(this.checkedListBoxMeds);
            this.Name = "GivePermission";
            this.Size = new System.Drawing.Size(1025, 487);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxMeds;
        private System.Windows.Forms.CheckedListBox checkedListBoxExercises;
        private System.Windows.Forms.CheckedListBox checkedListBoxTreatments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPrescriptions;
        private System.Windows.Forms.Button BtnLoadPrescription;
    }
}
