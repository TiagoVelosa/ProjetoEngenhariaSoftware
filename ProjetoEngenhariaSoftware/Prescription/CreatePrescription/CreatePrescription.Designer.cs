
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
            this.MedsLabel = new System.Windows.Forms.Label();
            this.ExercisesLabel = new System.Windows.Forms.Label();
            this.TreatmentsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListViewMeds
            // 
            this.ListViewMeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.DosageHeader,
            this.FrequencyHeader});
            this.ListViewMeds.HideSelection = false;
            this.ListViewMeds.Location = new System.Drawing.Point(231, 13);
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
            this.ListViewExercises.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.columnHeader1});
            this.ListViewExercises.HideSelection = false;
            this.ListViewExercises.Location = new System.Drawing.Point(231, 158);
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
            this.ListViewTreatments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ListViewTreatments.HideSelection = false;
            this.ListViewTreatments.Location = new System.Drawing.Point(231, 291);
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
            this.BtnMeds.Location = new System.Drawing.Point(59, 13);
            this.BtnMeds.Name = "BtnMeds";
            this.BtnMeds.Size = new System.Drawing.Size(139, 45);
            this.BtnMeds.TabIndex = 3;
            this.BtnMeds.Text = "Adicionar Medicamentos";
            this.BtnMeds.UseVisualStyleBackColor = true;
            this.BtnMeds.Click += new System.EventHandler(this.BtnMeds_Click);
            // 
            // BtnExercises
            // 
            this.BtnExercises.Location = new System.Drawing.Point(59, 158);
            this.BtnExercises.Name = "BtnExercises";
            this.BtnExercises.Size = new System.Drawing.Size(139, 44);
            this.BtnExercises.TabIndex = 4;
            this.BtnExercises.Text = "Adicionar Exercícios";
            this.BtnExercises.UseVisualStyleBackColor = true;
            this.BtnExercises.Click += new System.EventHandler(this.BtnExercises_Click);
            // 
            // btnTreatments
            // 
            this.btnTreatments.Location = new System.Drawing.Point(59, 291);
            this.btnTreatments.Name = "btnTreatments";
            this.btnTreatments.Size = new System.Drawing.Size(139, 45);
            this.btnTreatments.TabIndex = 5;
            this.btnTreatments.Text = "Adicionar Tratamentos";
            this.btnTreatments.UseVisualStyleBackColor = true;
            this.btnTreatments.Click += new System.EventHandler(this.btnTreatments_Click);
            // 
            // MedsLabel
            // 
            this.MedsLabel.AutoSize = true;
            this.MedsLabel.Location = new System.Drawing.Point(878, 26);
            this.MedsLabel.Name = "MedsLabel";
            this.MedsLabel.Size = new System.Drawing.Size(58, 17);
            this.MedsLabel.TabIndex = 6;
            this.MedsLabel.Text = "Número";
            // 
            // ExercisesLabel
            // 
            this.ExercisesLabel.AutoSize = true;
            this.ExercisesLabel.Location = new System.Drawing.Point(878, 174);
            this.ExercisesLabel.Name = "ExercisesLabel";
            this.ExercisesLabel.Size = new System.Drawing.Size(58, 17);
            this.ExercisesLabel.TabIndex = 7;
            this.ExercisesLabel.Text = "Número";
            // 
            // TreatmentsLabel
            // 
            this.TreatmentsLabel.AutoSize = true;
            this.TreatmentsLabel.Location = new System.Drawing.Point(878, 307);
            this.TreatmentsLabel.Name = "TreatmentsLabel";
            this.TreatmentsLabel.Size = new System.Drawing.Size(58, 17);
            this.TreatmentsLabel.TabIndex = 8;
            this.TreatmentsLabel.Text = "Número";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Preescrever";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 412);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Paciente";
            // 
            // CreatePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TreatmentsLabel);
            this.Controls.Add(this.ExercisesLabel);
            this.Controls.Add(this.MedsLabel);
            this.Controls.Add(this.btnTreatments);
            this.Controls.Add(this.BtnExercises);
            this.Controls.Add(this.BtnMeds);
            this.Controls.Add(this.ListViewTreatments);
            this.Controls.Add(this.ListViewExercises);
            this.Controls.Add(this.ListViewMeds);
            this.Name = "CreatePrescription";
            this.Size = new System.Drawing.Size(816, 485);
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
        private System.Windows.Forms.Label MedsLabel;
        private System.Windows.Forms.Label ExercisesLabel;
        private System.Windows.Forms.Label TreatmentsLabel;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
