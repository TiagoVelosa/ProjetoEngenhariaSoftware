
namespace ProjetoEngenhariaSoftware.Therapy
{
    partial class TherapySessionControl
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
            this.BtnLoadTherapy = new System.Windows.Forms.Button();
            this.comboBoxTherapy = new System.Windows.Forms.ComboBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.listViewTreatment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLoadTherapy
            // 
            this.BtnLoadTherapy.Location = new System.Drawing.Point(744, 16);
            this.BtnLoadTherapy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLoadTherapy.Name = "BtnLoadTherapy";
            this.BtnLoadTherapy.Size = new System.Drawing.Size(376, 37);
            this.BtnLoadTherapy.TabIndex = 32;
            this.BtnLoadTherapy.Text = "Selecione a Sessão";
            this.BtnLoadTherapy.UseVisualStyleBackColor = true;
            this.BtnLoadTherapy.Click += new System.EventHandler(this.BtnLoadTherapy_Click);
            // 
            // comboBoxTherapy
            // 
            this.comboBoxTherapy.FormattingEnabled = true;
            this.comboBoxTherapy.Location = new System.Drawing.Point(269, 23);
            this.comboBoxTherapy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTherapy.Name = "comboBoxTherapy";
            this.comboBoxTherapy.Size = new System.Drawing.Size(455, 24);
            this.comboBoxTherapy.TabIndex = 31;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.Location = new System.Drawing.Point(724, 107);
            this.labelEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(0, 31);
            this.labelEnd.TabIndex = 30;
            this.labelEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEnd.UseWaitCursor = true;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(724, 70);
            this.labelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(0, 31);
            this.labelStart.TabIndex = 29;
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStart.UseWaitCursor = true;
            // 
            // listViewTreatment
            // 
            this.listViewTreatment.CheckBoxes = true;
            this.listViewTreatment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTreatment.HideSelection = false;
            this.listViewTreatment.Location = new System.Drawing.Point(287, 157);
            this.listViewTreatment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewTreatment.Name = "listViewTreatment";
            this.listViewTreatment.RightToLeftLayout = true;
            this.listViewTreatment.Size = new System.Drawing.Size(833, 232);
            this.listViewTreatment.TabIndex = 28;
            this.listViewTreatment.UseCompatibleStateImageBehavior = false;
            this.listViewTreatment.View = System.Windows.Forms.View.Details;
            this.listViewTreatment.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lista de Tratamentos";
            this.columnHeader1.Width = 611;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 46);
            this.button1.TabIndex = 27;
            this.button1.Text = "Acabar sessão de terapia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(832, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fim:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseWaitCursor = true;
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(832, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Inicio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseWaitCursor = true;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 54);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sessão de Terapia";
            this.label1.UseMnemonic = false;
            this.label1.Visible = false;
            // 
            // TherapySessionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLoadTherapy);
            this.Controls.Add(this.comboBoxTherapy);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.listViewTreatment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TherapySessionControl";
            this.Size = new System.Drawing.Size(1378, 485);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoadTherapy;
        private System.Windows.Forms.ComboBox comboBoxTherapy;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.ListView listViewTreatment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
