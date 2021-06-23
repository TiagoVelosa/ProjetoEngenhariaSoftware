
namespace ProjetoEngenhariaSoftware.Secretaria
{
    partial class FormSecretaria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLoggout = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelclient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLoadPrescription = new System.Windows.Forms.Button();
            this.BtnAddSession = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DayPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.prescriptionCombobox = new System.Windows.Forms.ComboBox();
            this.BtnLoadTreatments = new System.Windows.Forms.Button();
            this.listViewSelectedTreatments = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EndTimeTxtBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.BtnLoggout);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 450);
            this.panel1.TabIndex = 6;
            // 
            // BtnLoggout
            // 
            this.BtnLoggout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnLoggout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoggout.ForeColor = System.Drawing.Color.White;
            this.BtnLoggout.Location = new System.Drawing.Point(9, 355);
            this.BtnLoggout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoggout.Name = "BtnLoggout";
            this.BtnLoggout.Size = new System.Drawing.Size(164, 59);
            this.BtnLoggout.TabIndex = 2;
            this.BtnLoggout.Text = "Logout";
            this.BtnLoggout.UseVisualStyleBackColor = false;
            this.BtnLoggout.Click += new System.EventHandler(this.LoggoutButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.secretaria;
            this.Logo.Location = new System.Drawing.Point(23, 13);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 110);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // labelclient
            // 
            this.labelclient.AutoSize = true;
            this.labelclient.Location = new System.Drawing.Point(288, 47);
            this.labelclient.Name = "labelclient";
            this.labelclient.Size = new System.Drawing.Size(39, 13);
            this.labelclient.TabIndex = 8;
            this.labelclient.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doutor Responsável";
            this.label1.Visible = false;
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Location = new System.Drawing.Point(427, 126);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(67, 13);
            this.DoctorNameLabel.TabIndex = 10;
            this.DoctorNameLabel.Text = "DoctorName";
            this.DoctorNameLabel.Visible = false;
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(430, 47);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(121, 21);
            this.clientComboBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tratamentos";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dia";
            this.label3.Visible = false;
            // 
            // BtnLoadPrescription
            // 
            this.BtnLoadPrescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnLoadPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadPrescription.ForeColor = System.Drawing.Color.White;
            this.BtnLoadPrescription.Location = new System.Drawing.Point(595, 40);
            this.BtnLoadPrescription.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoadPrescription.Name = "BtnLoadPrescription";
            this.BtnLoadPrescription.Size = new System.Drawing.Size(194, 30);
            this.BtnLoadPrescription.TabIndex = 3;
            this.BtnLoadPrescription.Text = "Carregar Pescrições";
            this.BtnLoadPrescription.UseVisualStyleBackColor = false;
            this.BtnLoadPrescription.Click += new System.EventHandler(this.BtnLoadPescription_Click);
            // 
            // BtnAddSession
            // 
            this.BtnAddSession.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnAddSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddSession.ForeColor = System.Drawing.Color.White;
            this.BtnAddSession.Location = new System.Drawing.Point(430, 409);
            this.BtnAddSession.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddSession.Name = "BtnAddSession";
            this.BtnAddSession.Size = new System.Drawing.Size(206, 30);
            this.BtnAddSession.TabIndex = 14;
            this.BtnAddSession.Text = "Adicionar Sessão";
            this.BtnAddSession.UseVisualStyleBackColor = false;
            this.BtnAddSession.Visible = false;
            this.BtnAddSession.Click += new System.EventHandler(this.BtnAddSession_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Início";
            this.label4.Visible = false;
            // 
            // DayPicker
            // 
            this.DayPicker.Location = new System.Drawing.Point(272, 306);
            this.DayPicker.Name = "DayPicker";
            this.DayPicker.Size = new System.Drawing.Size(151, 20);
            this.DayPicker.TabIndex = 16;
            this.DayPicker.Value = new System.DateTime(2021, 6, 22, 12, 22, 2, 0);
            this.DayPicker.Visible = false;
            this.DayPicker.ValueChanged += new System.EventHandler(this.DayPicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pescrição";
            this.label5.Visible = false;
            // 
            // prescriptionCombobox
            // 
            this.prescriptionCombobox.FormattingEnabled = true;
            this.prescriptionCombobox.Location = new System.Drawing.Point(430, 86);
            this.prescriptionCombobox.Name = "prescriptionCombobox";
            this.prescriptionCombobox.Size = new System.Drawing.Size(121, 21);
            this.prescriptionCombobox.TabIndex = 19;
            this.prescriptionCombobox.Visible = false;
            // 
            // BtnLoadTreatments
            // 
            this.BtnLoadTreatments.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnLoadTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadTreatments.ForeColor = System.Drawing.Color.White;
            this.BtnLoadTreatments.Location = new System.Drawing.Point(595, 82);
            this.BtnLoadTreatments.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoadTreatments.Name = "BtnLoadTreatments";
            this.BtnLoadTreatments.Size = new System.Drawing.Size(194, 30);
            this.BtnLoadTreatments.TabIndex = 20;
            this.BtnLoadTreatments.Text = "Carregar Tratamentos";
            this.BtnLoadTreatments.UseVisualStyleBackColor = false;
            this.BtnLoadTreatments.Visible = false;
            this.BtnLoadTreatments.Click += new System.EventHandler(this.BtnLoadTreatments_Click);
            // 
            // listViewSelectedTreatments
            // 
            this.listViewSelectedTreatments.CheckBoxes = true;
            this.listViewSelectedTreatments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome});
            this.listViewSelectedTreatments.HideSelection = false;
            this.listViewSelectedTreatments.Location = new System.Drawing.Point(264, 174);
            this.listViewSelectedTreatments.Margin = new System.Windows.Forms.Padding(2);
            this.listViewSelectedTreatments.Name = "listViewSelectedTreatments";
            this.listViewSelectedTreatments.Size = new System.Drawing.Size(450, 113);
            this.listViewSelectedTreatments.TabIndex = 22;
            this.listViewSelectedTreatments.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedTreatments.View = System.Windows.Forms.View.Details;
            this.listViewSelectedTreatments.Visible = false;
            // 
            // Nome
            // 
            this.Nome.Text = "";
            this.Nome.Width = 300;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fim";
            this.label6.Visible = false;
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = " ";
            this.StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime.Location = new System.Drawing.Point(272, 335);
            this.StartTime.Margin = new System.Windows.Forms.Padding(2);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(151, 26);
            this.StartTime.TabIndex = 25;
            this.StartTime.Value = new System.DateTime(2021, 6, 22, 0, 0, 0, 0);
            this.StartTime.Visible = false;
            this.StartTime.ValueChanged += new System.EventHandler(this.StartTime_ValueChanged);
            this.StartTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartTime_MouseDown);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(527, 332);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(263, 20);
            this.TitleTextBox.TabIndex = 27;
            this.TitleTextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Título";
            this.label7.Visible = false;
            // 
            // EndTimeTxtBox
            // 
            this.EndTimeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeTxtBox.Location = new System.Drawing.Point(272, 364);
            this.EndTimeTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.EndTimeTxtBox.Name = "EndTimeTxtBox";
            this.EndTimeTxtBox.ReadOnly = true;
            this.EndTimeTxtBox.Size = new System.Drawing.Size(151, 26);
            this.EndTimeTxtBox.TabIndex = 29;
            this.EndTimeTxtBox.Visible = false;
            // 
            // FormSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndTimeTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listViewSelectedTreatments);
            this.Controls.Add(this.BtnLoadTreatments);
            this.Controls.Add(this.prescriptionCombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DayPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddSession);
            this.Controls.Add(this.BtnLoadPrescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.DoctorNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelclient);
            this.Controls.Add(this.panel1);
            this.Name = "FormSecretaria";
            this.Text = "FormSecretaria";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnLoggout;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLoadPrescription;
        private System.Windows.Forms.Button BtnAddSession;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DayPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox prescriptionCombobox;
        private System.Windows.Forms.Button BtnLoadTreatments;
        private System.Windows.Forms.ListView listViewSelectedTreatments;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EndTimeTxtBox;
    }
}