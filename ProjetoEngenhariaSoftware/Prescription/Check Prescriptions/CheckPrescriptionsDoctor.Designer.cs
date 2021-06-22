
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(666, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "CarregarPrescrição";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(384, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // ListMeds
            // 
            this.ListMeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListMeds.HideSelection = false;
            this.ListMeds.Location = new System.Drawing.Point(132, 78);
            this.ListMeds.Margin = new System.Windows.Forms.Padding(2);
            this.ListMeds.Name = "ListMeds";
            this.ListMeds.Size = new System.Drawing.Size(239, 295);
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
            this.ListExercises.Location = new System.Drawing.Point(397, 78);
            this.ListExercises.Margin = new System.Windows.Forms.Padding(2);
            this.ListExercises.Name = "ListExercises";
            this.ListExercises.Size = new System.Drawing.Size(249, 295);
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
            this.ListTreatments.Location = new System.Drawing.Point(673, 78);
            this.ListTreatments.Margin = new System.Windows.Forms.Padding(2);
            this.ListTreatments.Name = "ListTreatments";
            this.ListTreatments.Size = new System.Drawing.Size(259, 295);
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
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(130, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Meds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(394, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exercises";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(670, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Treatments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Client:";
            // 
            // LabelClientName
            // 
            this.LabelClientName.AutoSize = true;
            this.LabelClientName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LabelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelClientName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelClientName.Location = new System.Drawing.Point(80, 28);
            this.LabelClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelClientName.Name = "LabelClientName";
            this.LabelClientName.Size = new System.Drawing.Size(71, 13);
            this.LabelClientName.TabIndex = 11;
            this.LabelClientName.Text = "ClientName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 85);
            this.panel1.TabIndex = 12;
            // 
            // CheckPrescriptionsDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckPrescriptionsDoctor";
            this.Size = new System.Drawing.Size(1034, 394);
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
        private System.Windows.Forms.Panel panel1;
    }
}
