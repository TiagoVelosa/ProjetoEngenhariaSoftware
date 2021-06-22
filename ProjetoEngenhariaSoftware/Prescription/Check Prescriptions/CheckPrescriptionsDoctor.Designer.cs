﻿
namespace ProjetoEngenhariaSoftware.Prescription.Check_Prescriptions
{
    partial class CheckPrescriptionsDoctor
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ListMeds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListExercises = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListTreatments = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelClientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(888, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "CarregarPrescrição";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(362, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(510, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // ListMeds
            // 
            this.ListMeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListMeds.HideSelection = false;
            this.ListMeds.Location = new System.Drawing.Point(176, 96);
            this.ListMeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListMeds.Name = "ListMeds";
            this.ListMeds.Size = new System.Drawing.Size(317, 362);
            this.ListMeds.TabIndex = 3;
            this.ListMeds.UseCompatibleStateImageBehavior = false;
            this.ListMeds.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dosagem";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frequency";
            this.columnHeader3.Width = 150;
            // 
            // ListExercises
            // 
            this.ListExercises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.ListExercises.HideSelection = false;
            this.ListExercises.Location = new System.Drawing.Point(528, 96);
            this.ListExercises.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListExercises.Name = "ListExercises";
            this.ListExercises.Size = new System.Drawing.Size(331, 362);
            this.ListExercises.TabIndex = 4;
            this.ListExercises.UseCompatibleStateImageBehavior = false;
            this.ListExercises.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nome";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hora Sugerida";
            this.columnHeader6.Width = 150;
            // 
            // ListTreatments
            // 
            this.ListTreatments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.ListTreatments.HideSelection = false;
            this.ListTreatments.Location = new System.Drawing.Point(897, 96);
            this.ListTreatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListTreatments.Name = "ListTreatments";
            this.ListTreatments.Size = new System.Drawing.Size(344, 362);
            this.ListTreatments.TabIndex = 5;
            this.ListTreatments.UseCompatibleStateImageBehavior = false;
            this.ListTreatments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nome";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Estado";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Descrição";
            this.columnHeader10.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(173, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Meds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(525, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exercises";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(894, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Treatments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Client:";
            // 
            // LabelClientName
            // 
            this.LabelClientName.AutoSize = true;
            this.LabelClientName.Location = new System.Drawing.Point(107, 34);
            this.LabelClientName.Name = "LabelClientName";
            this.LabelClientName.Size = new System.Drawing.Size(80, 17);
            this.LabelClientName.TabIndex = 11;
            this.LabelClientName.Text = "ClientName";
            // 
            // CheckPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelClientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListTreatments);
            this.Controls.Add(this.ListExercises);
            this.Controls.Add(this.ListMeds);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "CheckPrescriptions";
            this.Size = new System.Drawing.Size(1378, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView ListMeds;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView ListExercises;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView ListTreatments;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelClientName;
    }
}
