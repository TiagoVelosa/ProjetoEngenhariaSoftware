﻿
namespace ProjetoEngenhariaSoftware
{
    partial class CreatePrescription
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
            this.BtnMeds = new System.Windows.Forms.Button();
            this.BtnExercises = new System.Windows.Forms.Button();
            this.btnTreatments = new System.Windows.Forms.Button();
            this.BtnRegistPrescription = new System.Windows.Forms.Button();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListViewMeds
            // 
            this.ListViewMeds.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ListViewMeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.DosageHeader,
            this.FrequencyHeader});
            this.ListViewMeds.HideSelection = false;
            this.ListViewMeds.Location = new System.Drawing.Point(546, 13);
            this.ListViewMeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewMeds.Name = "ListViewMeds";
            this.ListViewMeds.Size = new System.Drawing.Size(535, 139);
            this.ListViewMeds.TabIndex = 0;
            this.ListViewMeds.UseCompatibleStateImageBehavior = false;
            this.ListViewMeds.View = System.Windows.Forms.View.Details;
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
            this.ListViewExercises.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ListViewExercises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.columnHeader1});
            this.ListViewExercises.HideSelection = false;
            this.ListViewExercises.Location = new System.Drawing.Point(546, 159);
            this.ListViewExercises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewExercises.Name = "ListViewExercises";
            this.ListViewExercises.Size = new System.Drawing.Size(535, 127);
            this.ListViewExercises.TabIndex = 1;
            this.ListViewExercises.UseCompatibleStateImageBehavior = false;
            this.ListViewExercises.View = System.Windows.Forms.View.Details;
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
            this.ListViewTreatments.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ListViewTreatments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewTreatments.HideSelection = false;
            this.ListViewTreatments.Location = new System.Drawing.Point(546, 290);
            this.ListViewTreatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListViewTreatments.Name = "ListViewTreatments";
            this.ListViewTreatments.Size = new System.Drawing.Size(535, 132);
            this.ListViewTreatments.TabIndex = 2;
            this.ListViewTreatments.UseCompatibleStateImageBehavior = false;
            this.ListViewTreatments.View = System.Windows.Forms.View.Details;
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
            // BtnMeds
            // 
            this.BtnMeds.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnMeds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnMeds.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnMeds.Location = new System.Drawing.Point(388, 13);
            this.BtnMeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMeds.Name = "BtnMeds";
            this.BtnMeds.Size = new System.Drawing.Size(139, 46);
            this.BtnMeds.TabIndex = 3;
            this.BtnMeds.Text = "Adicionar Medicamentos";
            this.BtnMeds.UseVisualStyleBackColor = false;
            this.BtnMeds.Click += new System.EventHandler(this.BtnMeds_Click);
            // 
            // BtnExercises
            // 
            this.BtnExercises.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnExercises.Location = new System.Drawing.Point(388, 159);
            this.BtnExercises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExercises.Name = "BtnExercises";
            this.BtnExercises.Size = new System.Drawing.Size(139, 44);
            this.BtnExercises.TabIndex = 4;
            this.BtnExercises.Text = "Adicionar Exercícios";
            this.BtnExercises.UseVisualStyleBackColor = false;
            this.BtnExercises.Click += new System.EventHandler(this.BtnExercises_Click);
            // 
            // btnTreatments
            // 
            this.btnTreatments.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTreatments.Location = new System.Drawing.Point(388, 290);
            this.btnTreatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTreatments.Name = "btnTreatments";
            this.btnTreatments.Size = new System.Drawing.Size(139, 46);
            this.btnTreatments.TabIndex = 5;
            this.btnTreatments.Text = "Adicionar Tratamentos";
            this.btnTreatments.UseVisualStyleBackColor = false;
            this.btnTreatments.Click += new System.EventHandler(this.btnTreatments_Click);
            // 
            // BtnRegistPrescription
            // 
            this.BtnRegistPrescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnRegistPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnRegistPrescription.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnRegistPrescription.Location = new System.Drawing.Point(921, 426);
            this.BtnRegistPrescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistPrescription.Name = "BtnRegistPrescription";
            this.BtnRegistPrescription.Size = new System.Drawing.Size(160, 39);
            this.BtnRegistPrescription.TabIndex = 9;
            this.BtnRegistPrescription.Text = "Preescrever";
            this.BtnRegistPrescription.UseVisualStyleBackColor = false;
            this.BtnRegistPrescription.Click += new System.EventHandler(this.BtnRegistPrescription_Click);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(121, 290);
            this.comboBoxClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(183, 24);
            this.comboBoxClients.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(171, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(118, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Título";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxTitle.Location = new System.Drawing.Point(121, 110);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(183, 93);
            this.textBoxTitle.TabIndex = 13;
            // 
            // CreatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.BtnRegistPrescription);
            this.Controls.Add(this.btnTreatments);
            this.Controls.Add(this.BtnExercises);
            this.Controls.Add(this.BtnMeds);
            this.Controls.Add(this.ListViewTreatments);
            this.Controls.Add(this.ListViewExercises);
            this.Controls.Add(this.ListViewMeds);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreatePrescription";
            this.Size = new System.Drawing.Size(1378, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewMeds;
        private System.Windows.Forms.ListView ListViewExercises;
        private System.Windows.Forms.ListView ListViewTreatments;
        private System.Windows.Forms.Button BtnMeds;
        private System.Windows.Forms.Button BtnExercises;
        private System.Windows.Forms.Button btnTreatments;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader DosageHeader;
        private System.Windows.Forms.ColumnHeader FrequencyHeader;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button BtnRegistPrescription;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}
