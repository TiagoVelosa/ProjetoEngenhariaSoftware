
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
            this.checkedListBoxTreatments = new System.Windows.Forms.CheckedListBox();
            this.listViewSelectedTreatments = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnMoveItems = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 554);
            this.panel1.TabIndex = 6;
            // 
            // BtnLoggout
            // 
            this.BtnLoggout.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnLoggout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoggout.ForeColor = System.Drawing.Color.White;
            this.BtnLoggout.Location = new System.Drawing.Point(12, 437);
            this.BtnLoggout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLoggout.Name = "BtnLoggout";
            this.BtnLoggout.Size = new System.Drawing.Size(219, 73);
            this.BtnLoggout.TabIndex = 2;
            this.BtnLoggout.Text = "Logout";
            this.BtnLoggout.UseVisualStyleBackColor = false;
            this.BtnLoggout.Click += new System.EventHandler(this.LoggoutButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.secretaria;
            this.Logo.Location = new System.Drawing.Point(31, 16);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(173, 135);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // labelclient
            // 
            this.labelclient.AutoSize = true;
            this.labelclient.Location = new System.Drawing.Point(384, 58);
            this.labelclient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelclient.Name = "labelclient";
            this.labelclient.Size = new System.Drawing.Size(51, 17);
            this.labelclient.TabIndex = 8;
            this.labelclient.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doutor Responsável";
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Location = new System.Drawing.Point(569, 155);
            this.DoctorNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(87, 17);
            this.DoctorNameLabel.TabIndex = 10;
            this.DoctorNameLabel.Text = "DoctorName";
            // 
            // clientComboBox
            // 
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(573, 58);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(160, 24);
            this.clientComboBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tratamentos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dia";
            // 
            // BtnLoadPrescription
            // 
            this.BtnLoadPrescription.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnLoadPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadPrescription.ForeColor = System.Drawing.Color.White;
            this.BtnLoadPrescription.Location = new System.Drawing.Point(793, 49);
            this.BtnLoadPrescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLoadPrescription.Name = "BtnLoadPrescription";
            this.BtnLoadPrescription.Size = new System.Drawing.Size(259, 37);
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
            this.BtnAddSession.Location = new System.Drawing.Point(573, 503);
            this.BtnAddSession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddSession.Name = "BtnAddSession";
            this.BtnAddSession.Size = new System.Drawing.Size(275, 37);
            this.BtnAddSession.TabIndex = 14;
            this.BtnAddSession.Text = "Adicionar Sessão";
            this.BtnAddSession.UseVisualStyleBackColor = false;
            this.BtnAddSession.Click += new System.EventHandler(this.BtnAddSession_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 412);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Início";
            // 
            // DayPicker
            // 
            this.DayPicker.Location = new System.Drawing.Point(362, 377);
            this.DayPicker.Margin = new System.Windows.Forms.Padding(4);
            this.DayPicker.Name = "DayPicker";
            this.DayPicker.Size = new System.Drawing.Size(200, 22);
            this.DayPicker.TabIndex = 16;
            this.DayPicker.Value = new System.DateTime(2021, 6, 22, 12, 22, 2, 0);
            this.DayPicker.ValueChanged += new System.EventHandler(this.DayPicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pescrição";
            // 
            // prescriptionCombobox
            // 
            this.prescriptionCombobox.FormattingEnabled = true;
            this.prescriptionCombobox.Location = new System.Drawing.Point(573, 106);
            this.prescriptionCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.prescriptionCombobox.Name = "prescriptionCombobox";
            this.prescriptionCombobox.Size = new System.Drawing.Size(160, 24);
            this.prescriptionCombobox.TabIndex = 19;
            // 
            // BtnLoadTreatments
            // 
            this.BtnLoadTreatments.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnLoadTreatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadTreatments.ForeColor = System.Drawing.Color.White;
            this.BtnLoadTreatments.Location = new System.Drawing.Point(793, 101);
            this.BtnLoadTreatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLoadTreatments.Name = "BtnLoadTreatments";
            this.BtnLoadTreatments.Size = new System.Drawing.Size(259, 37);
            this.BtnLoadTreatments.TabIndex = 20;
            this.BtnLoadTreatments.Text = "Carregar Tratamentos";
            this.BtnLoadTreatments.UseVisualStyleBackColor = false;
            this.BtnLoadTreatments.Click += new System.EventHandler(this.BtnLoadTreatments_Click);
            // 
            // checkedListBoxTreatments
            // 
            this.checkedListBoxTreatments.FormattingEnabled = true;
            this.checkedListBoxTreatments.Location = new System.Drawing.Point(335, 207);
            this.checkedListBoxTreatments.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxTreatments.Name = "checkedListBoxTreatments";
            this.checkedListBoxTreatments.Size = new System.Drawing.Size(336, 123);
            this.checkedListBoxTreatments.TabIndex = 21;
            // 
            // listViewSelectedTreatments
            // 
            this.listViewSelectedTreatments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome});
            this.listViewSelectedTreatments.HideSelection = false;
            this.listViewSelectedTreatments.Location = new System.Drawing.Point(746, 207);
            this.listViewSelectedTreatments.Name = "listViewSelectedTreatments";
            this.listViewSelectedTreatments.Size = new System.Drawing.Size(306, 123);
            this.listViewSelectedTreatments.TabIndex = 22;
            this.listViewSelectedTreatments.UseCompatibleStateImageBehavior = false;
            this.listViewSelectedTreatments.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "";
            this.Nome.Width = 300;
            // 
            // BtnMoveItems
            // 
            this.BtnMoveItems.Location = new System.Drawing.Point(678, 241);
            this.BtnMoveItems.Name = "BtnMoveItems";
            this.BtnMoveItems.Size = new System.Drawing.Size(62, 51);
            this.BtnMoveItems.TabIndex = 23;
            this.BtnMoveItems.Text = ">>>";
            this.BtnMoveItems.UseVisualStyleBackColor = true;
            this.BtnMoveItems.Click += new System.EventHandler(this.BtnMoveItems_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 448);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fim";
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = " ";
            this.StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime.Location = new System.Drawing.Point(362, 412);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(200, 30);
            this.StartTime.TabIndex = 25;
            this.StartTime.Value = new System.DateTime(2021, 6, 22, 0, 0, 0, 0);
            this.StartTime.ValueChanged += new System.EventHandler(this.StartTime_ValueChanged);
            this.StartTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartTime_MouseDown);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(703, 409);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(349, 22);
            this.TitleTextBox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(642, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Título";
            // 
            // EndTimeTxtBox
            // 
            this.EndTimeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeTxtBox.Location = new System.Drawing.Point(362, 448);
            this.EndTimeTxtBox.Name = "EndTimeTxtBox";
            this.EndTimeTxtBox.ReadOnly = true;
            this.EndTimeTxtBox.Size = new System.Drawing.Size(200, 30);
            this.EndTimeTxtBox.TabIndex = 29;
            // 
            // FormSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.EndTimeTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnMoveItems);
            this.Controls.Add(this.listViewSelectedTreatments);
            this.Controls.Add(this.checkedListBoxTreatments);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckedListBox checkedListBoxTreatments;
        private System.Windows.Forms.ListView listViewSelectedTreatments;
        private System.Windows.Forms.Button BtnMoveItems;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EndTimeTxtBox;
    }
}