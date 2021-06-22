
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
            this.ListViewMeds = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DosageHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FrequencyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewExercises = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListViewTreatments = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.DosageTxtBox = new System.Windows.Forms.TextBox();
            this.FrequencyTxtBox = new System.Windows.Forms.TextBox();
            this.BtnEditMed = new System.Windows.Forms.Button();
            this.ExerciseNameTxtBox = new System.Windows.Forms.TextBox();
            this.TimeTxtBox = new System.Windows.Forms.TextBox();
            this.BtnEditExercise = new System.Windows.Forms.Button();
            this.TreatmentNameTxtBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.BtnEditTreatment = new System.Windows.Forms.Button();
            this.BtnEditPrescription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPrescription
            // 
            this.comboBoxPrescription.FormattingEnabled = true;
            this.comboBoxPrescription.Location = new System.Drawing.Point(360, 20);
            this.comboBoxPrescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPrescription.Name = "comboBoxPrescription";
            this.comboBoxPrescription.Size = new System.Drawing.Size(455, 24);
            this.comboBoxPrescription.TabIndex = 0;
            // 
            // BtnLoadPrescription
            // 
            this.BtnLoadPrescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnLoadPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnLoadPrescription.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnLoadPrescription.Location = new System.Drawing.Point(831, 20);
            this.BtnLoadPrescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLoadPrescription.Name = "BtnLoadPrescription";
            this.BtnLoadPrescription.Size = new System.Drawing.Size(232, 23);
            this.BtnLoadPrescription.TabIndex = 1;
            this.BtnLoadPrescription.Text = "Carregar";
            this.BtnLoadPrescription.UseVisualStyleBackColor = false;
            this.BtnLoadPrescription.Click += new System.EventHandler(this.BtnLoadPrescription_Click);
            // 
            // ListViewMeds
            // 
            this.ListViewMeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.DosageHeader,
            this.FrequencyHeader});
            this.ListViewMeds.HideSelection = false;
            this.ListViewMeds.Location = new System.Drawing.Point(528, 53);
            this.ListViewMeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewMeds.Name = "ListViewMeds";
            this.ListViewMeds.Size = new System.Drawing.Size(535, 139);
            this.ListViewMeds.TabIndex = 2;
            this.ListViewMeds.UseCompatibleStateImageBehavior = false;
            this.ListViewMeds.View = System.Windows.Forms.View.Details;
            this.ListViewMeds.SelectedIndexChanged += new System.EventHandler(this.ListViewMeds_SelectedIndexChanged);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Nome";
            this.NameHeader.Width = 150;
            // 
            // DosageHeader
            // 
            this.DosageHeader.Text = "Dosage";
            this.DosageHeader.Width = 150;
            // 
            // FrequencyHeader
            // 
            this.FrequencyHeader.Text = "Frequência";
            this.FrequencyHeader.Width = 155;
            // 
            // ListViewExercises
            // 
            this.ListViewExercises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.columnHeader1});
            this.ListViewExercises.HideSelection = false;
            this.ListViewExercises.Location = new System.Drawing.Point(528, 196);
            this.ListViewExercises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewExercises.Name = "ListViewExercises";
            this.ListViewExercises.Size = new System.Drawing.Size(535, 127);
            this.ListViewExercises.TabIndex = 3;
            this.ListViewExercises.UseCompatibleStateImageBehavior = false;
            this.ListViewExercises.View = System.Windows.Forms.View.Details;
            this.ListViewExercises.SelectedIndexChanged += new System.EventHandler(this.ListViewExercises_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data Sugerida";
            this.columnHeader1.Width = 200;
            // 
            // ListViewTreatments
            // 
            this.ListViewTreatments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewTreatments.HideSelection = false;
            this.ListViewTreatments.Location = new System.Drawing.Point(528, 327);
            this.ListViewTreatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewTreatments.Name = "ListViewTreatments";
            this.ListViewTreatments.Size = new System.Drawing.Size(535, 132);
            this.ListViewTreatments.TabIndex = 4;
            this.ListViewTreatments.UseCompatibleStateImageBehavior = false;
            this.ListViewTreatments.View = System.Windows.Forms.View.Details;
            this.ListViewTreatments.SelectedIndexChanged += new System.EventHandler(this.ListViewTreatments_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Estado";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descrição";
            this.columnHeader4.Width = 150;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(342, 53);
            this.NameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(180, 22);
            this.NameTxtBox.TabIndex = 8;
            // 
            // DosageTxtBox
            // 
            this.DosageTxtBox.Location = new System.Drawing.Point(342, 90);
            this.DosageTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DosageTxtBox.Name = "DosageTxtBox";
            this.DosageTxtBox.Size = new System.Drawing.Size(180, 22);
            this.DosageTxtBox.TabIndex = 9;
            // 
            // FrequencyTxtBox
            // 
            this.FrequencyTxtBox.Location = new System.Drawing.Point(342, 125);
            this.FrequencyTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FrequencyTxtBox.Name = "FrequencyTxtBox";
            this.FrequencyTxtBox.Size = new System.Drawing.Size(180, 22);
            this.FrequencyTxtBox.TabIndex = 10;
            // 
            // BtnEditMed
            // 
            this.BtnEditMed.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnEditMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnEditMed.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnEditMed.Location = new System.Drawing.Point(187, 53);
            this.BtnEditMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditMed.Name = "BtnEditMed";
            this.BtnEditMed.Size = new System.Drawing.Size(136, 46);
            this.BtnEditMed.TabIndex = 11;
            this.BtnEditMed.Text = "Editar Medicamento";
            this.BtnEditMed.UseVisualStyleBackColor = false;
            this.BtnEditMed.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExerciseNameTxtBox
            // 
            this.ExerciseNameTxtBox.Location = new System.Drawing.Point(342, 196);
            this.ExerciseNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExerciseNameTxtBox.Name = "ExerciseNameTxtBox";
            this.ExerciseNameTxtBox.Size = new System.Drawing.Size(180, 22);
            this.ExerciseNameTxtBox.TabIndex = 12;
            // 
            // TimeTxtBox
            // 
            this.TimeTxtBox.Location = new System.Drawing.Point(342, 233);
            this.TimeTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeTxtBox.Name = "TimeTxtBox";
            this.TimeTxtBox.Size = new System.Drawing.Size(180, 22);
            this.TimeTxtBox.TabIndex = 13;
            // 
            // BtnEditExercise
            // 
            this.BtnEditExercise.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnEditExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnEditExercise.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnEditExercise.Location = new System.Drawing.Point(187, 196);
            this.BtnEditExercise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditExercise.Name = "BtnEditExercise";
            this.BtnEditExercise.Size = new System.Drawing.Size(136, 46);
            this.BtnEditExercise.TabIndex = 14;
            this.BtnEditExercise.Text = "Editar Exercício";
            this.BtnEditExercise.UseVisualStyleBackColor = false;
            this.BtnEditExercise.Click += new System.EventHandler(this.BtnEditExercise_Click);
            // 
            // TreatmentNameTxtBox
            // 
            this.TreatmentNameTxtBox.Location = new System.Drawing.Point(342, 327);
            this.TreatmentNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TreatmentNameTxtBox.Name = "TreatmentNameTxtBox";
            this.TreatmentNameTxtBox.Size = new System.Drawing.Size(180, 22);
            this.TreatmentNameTxtBox.TabIndex = 15;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(342, 364);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(180, 95);
            this.DescriptionTextBox.TabIndex = 16;
            // 
            // BtnEditTreatment
            // 
            this.BtnEditTreatment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnEditTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnEditTreatment.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnEditTreatment.Location = new System.Drawing.Point(187, 327);
            this.BtnEditTreatment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditTreatment.Name = "BtnEditTreatment";
            this.BtnEditTreatment.Size = new System.Drawing.Size(136, 46);
            this.BtnEditTreatment.TabIndex = 17;
            this.BtnEditTreatment.Text = "Editar Tratamento";
            this.BtnEditTreatment.UseVisualStyleBackColor = false;
            this.BtnEditTreatment.Click += new System.EventHandler(this.BtnEditTreatment_Click);
            // 
            // BtnEditPrescription
            // 
            this.BtnEditPrescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnEditPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnEditPrescription.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnEditPrescription.Location = new System.Drawing.Point(1126, 216);
            this.BtnEditPrescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditPrescription.Name = "BtnEditPrescription";
            this.BtnEditPrescription.Size = new System.Drawing.Size(190, 54);
            this.BtnEditPrescription.TabIndex = 18;
            this.BtnEditPrescription.Text = "Editar Prescrição";
            this.BtnEditPrescription.UseVisualStyleBackColor = false;
            this.BtnEditPrescription.Click += new System.EventHandler(this.BtnEditPrescription_Click);
            // 
            // EditPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnEditPrescription);
            this.Controls.Add(this.BtnEditTreatment);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TreatmentNameTxtBox);
            this.Controls.Add(this.BtnEditExercise);
            this.Controls.Add(this.TimeTxtBox);
            this.Controls.Add(this.ExerciseNameTxtBox);
            this.Controls.Add(this.BtnEditMed);
            this.Controls.Add(this.FrequencyTxtBox);
            this.Controls.Add(this.DosageTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.ListViewTreatments);
            this.Controls.Add(this.ListViewExercises);
            this.Controls.Add(this.ListViewMeds);
            this.Controls.Add(this.BtnLoadPrescription);
            this.Controls.Add(this.comboBoxPrescription);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditPrescription";
            this.Size = new System.Drawing.Size(1378, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPrescription;
        private System.Windows.Forms.Button BtnLoadPrescription;
        private System.Windows.Forms.ListView ListViewMeds;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader DosageHeader;
        private System.Windows.Forms.ColumnHeader FrequencyHeader;
        private System.Windows.Forms.ListView ListViewExercises;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView ListViewTreatments;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox DosageTxtBox;
        private System.Windows.Forms.TextBox FrequencyTxtBox;
        private System.Windows.Forms.Button BtnEditMed;
        private System.Windows.Forms.TextBox ExerciseNameTxtBox;
        private System.Windows.Forms.TextBox TimeTxtBox;
        private System.Windows.Forms.Button BtnEditExercise;
        private System.Windows.Forms.TextBox TreatmentNameTxtBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button BtnEditTreatment;
        private System.Windows.Forms.Button BtnEditPrescription;
    }
}
