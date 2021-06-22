
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
            this.BtnVisability = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPrescriptions = new System.Windows.Forms.ComboBox();
            this.BtnLoadPrescription = new System.Windows.Forms.Button();
            this.NonExistentMeds = new System.Windows.Forms.Label();
            this.NonExistentExercises = new System.Windows.Forms.Label();
            this.NonExistentTreatments = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // checkedListBoxMeds
            // 
            this.checkedListBoxMeds.FormattingEnabled = true;
            this.checkedListBoxMeds.Location = new System.Drawing.Point(382, 35);
            this.checkedListBoxMeds.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxMeds.Name = "checkedListBoxMeds";
            this.checkedListBoxMeds.Size = new System.Drawing.Size(256, 94);
            this.checkedListBoxMeds.TabIndex = 0;
            // 
            // checkedListBoxExercises
            // 
            this.checkedListBoxExercises.FormattingEnabled = true;
            this.checkedListBoxExercises.Location = new System.Drawing.Point(382, 140);
            this.checkedListBoxExercises.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxExercises.Name = "checkedListBoxExercises";
            this.checkedListBoxExercises.Size = new System.Drawing.Size(256, 94);
            this.checkedListBoxExercises.TabIndex = 1;
            // 
            // checkedListBoxTreatments
            // 
            this.checkedListBoxTreatments.FormattingEnabled = true;
            this.checkedListBoxTreatments.Location = new System.Drawing.Point(382, 245);
            this.checkedListBoxTreatments.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxTreatments.Name = "checkedListBoxTreatments";
            this.checkedListBoxTreatments.Size = new System.Drawing.Size(256, 94);
            this.checkedListBoxTreatments.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(259, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medicamentos Privados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exercícios Privados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tratamentos Privados";
            // 
            // BtnVisability
            // 
            this.BtnVisability.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnVisability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnVisability.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnVisability.Location = new System.Drawing.Point(441, 349);
            this.BtnVisability.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVisability.Name = "BtnVisability";
            this.BtnVisability.Size = new System.Drawing.Size(142, 37);
            this.BtnVisability.TabIndex = 6;
            this.BtnVisability.Text = "Atribuir Visibilidade";
            this.BtnVisability.UseVisualStyleBackColor = false;
            this.BtnVisability.Click += new System.EventHandler(this.BtnVisability_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(80, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Prescrições";
            // 
            // comboBoxPrescriptions
            // 
            this.comboBoxPrescriptions.FormattingEnabled = true;
            this.comboBoxPrescriptions.Location = new System.Drawing.Point(39, 108);
            this.comboBoxPrescriptions.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPrescriptions.Name = "comboBoxPrescriptions";
            this.comboBoxPrescriptions.Size = new System.Drawing.Size(149, 21);
            this.comboBoxPrescriptions.TabIndex = 8;
            // 
            // BtnLoadPrescription
            // 
            this.BtnLoadPrescription.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnLoadPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnLoadPrescription.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnLoadPrescription.Location = new System.Drawing.Point(39, 133);
            this.BtnLoadPrescription.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoadPrescription.Name = "BtnLoadPrescription";
            this.BtnLoadPrescription.Size = new System.Drawing.Size(148, 37);
            this.BtnLoadPrescription.TabIndex = 9;
            this.BtnLoadPrescription.Text = "Carregar Prescrição";
            this.BtnLoadPrescription.UseVisualStyleBackColor = false;
            this.BtnLoadPrescription.Click += new System.EventHandler(this.BtnLoadPrescription_Click);
            // 
            // NonExistentMeds
            // 
            this.NonExistentMeds.AutoSize = true;
            this.NonExistentMeds.Location = new System.Drawing.Point(658, 50);
            this.NonExistentMeds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NonExistentMeds.Name = "NonExistentMeds";
            this.NonExistentMeds.Size = new System.Drawing.Size(84, 52);
            this.NonExistentMeds.TabIndex = 10;
            this.NonExistentMeds.Text = "Esta Prescrição \r\nNão tem \r\nMedicamentos \r\nPrivados";
            this.NonExistentMeds.Visible = false;
            // 
            // NonExistentExercises
            // 
            this.NonExistentExercises.AutoSize = true;
            this.NonExistentExercises.Location = new System.Drawing.Point(658, 158);
            this.NonExistentExercises.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NonExistentExercises.Name = "NonExistentExercises";
            this.NonExistentExercises.Size = new System.Drawing.Size(81, 52);
            this.NonExistentExercises.TabIndex = 11;
            this.NonExistentExercises.Text = "Esta Prescrição\r\nNão tem \r\nExercícios \r\nPrivados";
            this.NonExistentExercises.Visible = false;
            // 
            // NonExistentTreatments
            // 
            this.NonExistentTreatments.AutoSize = true;
            this.NonExistentTreatments.Location = new System.Drawing.Point(658, 264);
            this.NonExistentTreatments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NonExistentTreatments.Name = "NonExistentTreatments";
            this.NonExistentTreatments.Size = new System.Drawing.Size(81, 52);
            this.NonExistentTreatments.TabIndex = 12;
            this.NonExistentTreatments.Text = "Esta Prescrição\r\nNão tem\r\nTratamentos\r\nPrivados";
            this.NonExistentTreatments.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 396);
            this.panel1.TabIndex = 13;
            // 
            // GivePermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NonExistentTreatments);
            this.Controls.Add(this.NonExistentExercises);
            this.Controls.Add(this.NonExistentMeds);
            this.Controls.Add(this.BtnLoadPrescription);
            this.Controls.Add(this.comboBoxPrescriptions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnVisability);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxTreatments);
            this.Controls.Add(this.checkedListBoxExercises);
            this.Controls.Add(this.checkedListBoxMeds);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GivePermission";
            this.Size = new System.Drawing.Size(769, 396);
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
        private System.Windows.Forms.Button BtnVisability;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPrescriptions;
        private System.Windows.Forms.Button BtnLoadPrescription;
        private System.Windows.Forms.Label NonExistentMeds;
        private System.Windows.Forms.Label NonExistentExercises;
        private System.Windows.Forms.Label NonExistentTreatments;
        private System.Windows.Forms.Panel panel1;
    }
}
