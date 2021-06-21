
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
            this.LoggoutButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.labelclient = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorNameLabel = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLoadPrescription = new System.Windows.Forms.Button();
            this.AddSessionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pescriptionCombobox = new System.Windows.Forms.ComboBox();
            this.BtnLoadTreatments = new System.Windows.Forms.Button();
            this.checkedListBoxTreatments = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.LoggoutButton);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 450);
            this.panel1.TabIndex = 6;
            // 
            // LoggoutButton
            // 
            this.LoggoutButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoggoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggoutButton.ForeColor = System.Drawing.Color.White;
            this.LoggoutButton.Location = new System.Drawing.Point(9, 355);
            this.LoggoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoggoutButton.Name = "LoggoutButton";
            this.LoggoutButton.Size = new System.Drawing.Size(164, 59);
            this.LoggoutButton.TabIndex = 2;
            this.LoggoutButton.Text = "Logout";
            this.LoggoutButton.UseVisualStyleBackColor = false;
            this.LoggoutButton.Click += new System.EventHandler(this.LoggoutButton_Click);
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
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doutor";
            // 
            // DoctorNameLabel
            // 
            this.DoctorNameLabel.AutoSize = true;
            this.DoctorNameLabel.Location = new System.Drawing.Point(427, 126);
            this.DoctorNameLabel.Name = "DoctorNameLabel";
            this.DoctorNameLabel.Size = new System.Drawing.Size(67, 13);
            this.DoctorNameLabel.TabIndex = 10;
            this.DoctorNameLabel.Text = "DoctorName";
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
            this.label2.Location = new System.Drawing.Point(288, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tratamentos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Início";
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
            // AddSessionButton
            // 
            this.AddSessionButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddSessionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSessionButton.ForeColor = System.Drawing.Color.White;
            this.AddSessionButton.Location = new System.Drawing.Point(430, 409);
            this.AddSessionButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddSessionButton.Name = "AddSessionButton";
            this.AddSessionButton.Size = new System.Drawing.Size(206, 30);
            this.AddSessionButton.TabIndex = 14;
            this.AddSessionButton.Text = "Adicionar Sessão";
            this.AddSessionButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data Fim";
            // 
            // dateBegin
            // 
            this.dateBegin.Location = new System.Drawing.Point(430, 307);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(200, 20);
            this.dateBegin.TabIndex = 16;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(430, 355);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pescrição";
            // 
            // pescriptionCombobox
            // 
            this.pescriptionCombobox.FormattingEnabled = true;
            this.pescriptionCombobox.Location = new System.Drawing.Point(430, 86);
            this.pescriptionCombobox.Name = "pescriptionCombobox";
            this.pescriptionCombobox.Size = new System.Drawing.Size(121, 21);
            this.pescriptionCombobox.TabIndex = 19;
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
            this.BtnLoadTreatments.Click += new System.EventHandler(this.BtnLoadTreatments_Click);
            // 
            // checkedListBoxTreatments
            // 
            this.checkedListBoxTreatments.FormattingEnabled = true;
            this.checkedListBoxTreatments.Location = new System.Drawing.Point(430, 165);
            this.checkedListBoxTreatments.Name = "checkedListBoxTreatments";
            this.checkedListBoxTreatments.Size = new System.Drawing.Size(253, 109);
            this.checkedListBoxTreatments.TabIndex = 21;
            // 
            // FormSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxTreatments);
            this.Controls.Add(this.BtnLoadTreatments);
            this.Controls.Add(this.pescriptionCombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateBegin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddSessionButton);
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
        private System.Windows.Forms.Button LoggoutButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label labelclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DoctorNameLabel;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLoadPrescription;
        private System.Windows.Forms.Button AddSessionButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pescriptionCombobox;
        private System.Windows.Forms.Button BtnLoadTreatments;
        private System.Windows.Forms.CheckedListBox checkedListBoxTreatments;
    }
}