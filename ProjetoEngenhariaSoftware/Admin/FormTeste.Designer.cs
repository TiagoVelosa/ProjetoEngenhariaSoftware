﻿
namespace ProjetoEngenhariaSoftware
{
    partial class FormTeste
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeste));
            this.mainTreeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnRegistDoctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.ImageIndex = 0;
            this.mainTreeView.ImageList = this.imageList1;
            this.mainTreeView.Location = new System.Drawing.Point(0, 54);
            this.mainTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.SelectedImageIndex = 0;
            this.mainTreeView.Size = new System.Drawing.Size(301, 478);
            this.mainTreeView.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Doctor.jpg");
            // 
            // BtnRegistDoctor
            // 
            this.BtnRegistDoctor.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnRegistDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnRegistDoctor.ForeColor = System.Drawing.Color.White;
            this.BtnRegistDoctor.Location = new System.Drawing.Point(10, 11);
            this.BtnRegistDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRegistDoctor.Name = "BtnRegistDoctor";
            this.BtnRegistDoctor.Size = new System.Drawing.Size(159, 29);
            this.BtnRegistDoctor.TabIndex = 1;
            this.BtnRegistDoctor.Text = "Registar Doctor";
            this.BtnRegistDoctor.UseVisualStyleBackColor = false;
            this.BtnRegistDoctor.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 530);
            this.Controls.Add(this.BtnRegistDoctor);
            this.Controls.Add(this.mainTreeView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTeste";
            this.Text = "FormTeste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.Button BtnRegistDoctor;
        private System.Windows.Forms.ImageList imageList1;
    }
}