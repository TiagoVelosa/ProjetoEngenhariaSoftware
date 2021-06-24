
namespace ProjetoEngenhariaSoftware.Therapy
{
    partial class AddNote
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
            this.label3 = new System.Windows.Forms.Label();
            this.listViewTratamentos = new System.Windows.Forms.ListView();
            this.Tratamento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionarNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "(Obrigatório)";
            // 
            // listViewTratamentos
            // 
            this.listViewTratamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tratamento});
            this.listViewTratamentos.HideSelection = false;
            this.listViewTratamentos.Location = new System.Drawing.Point(372, 57);
            this.listViewTratamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewTratamentos.Name = "listViewTratamentos";
            this.listViewTratamentos.Size = new System.Drawing.Size(401, 210);
            this.listViewTratamentos.TabIndex = 16;
            this.listViewTratamentos.UseCompatibleStateImageBehavior = false;
            this.listViewTratamentos.View = System.Windows.Forms.View.Details;
            // 
            // Tratamento
            // 
            this.Tratamento.Text = "Tratamento";
            this.Tratamento.Width = 298;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tratamentos concluídos na sessão:";
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(16, 55);
            this.textBoxNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNota.Multiline = true;
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(341, 211);
            this.textBoxNota.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adicione uma nota à sessão";
            // 
            // btnAdicionarNota
            // 
            this.btnAdicionarNota.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdicionarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdicionarNota.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAdicionarNota.Location = new System.Drawing.Point(304, 293);
            this.btnAdicionarNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionarNota.Name = "btnAdicionarNota";
            this.btnAdicionarNota.Size = new System.Drawing.Size(216, 32);
            this.btnAdicionarNota.TabIndex = 12;
            this.btnAdicionarNota.Text = "Concluir Sessão\r\n";
            this.btnAdicionarNota.UseVisualStyleBackColor = false;
            this.btnAdicionarNota.Click += new System.EventHandler(this.btnAdicionarNota_Click);
            // 
            // AddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewTratamentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionarNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddNote";
            this.Text = "AddNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewTratamentos;
        private System.Windows.Forms.ColumnHeader Tratamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarNota;
    }
}