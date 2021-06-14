
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
            this.BtnRegistDoctor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.ImageIndex = 0;
            this.mainTreeView.ImageList = this.imageList1;
            this.mainTreeView.Location = new System.Drawing.Point(0, 66);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.SelectedImageIndex = 0;
            this.mainTreeView.Size = new System.Drawing.Size(400, 588);
            this.mainTreeView.TabIndex = 0;
            // 
            // BtnRegistDoctor
            // 
            this.BtnRegistDoctor.Location = new System.Drawing.Point(13, 13);
            this.BtnRegistDoctor.Name = "BtnRegistDoctor";
            this.BtnRegistDoctor.Size = new System.Drawing.Size(212, 36);
            this.BtnRegistDoctor.TabIndex = 1;
            this.BtnRegistDoctor.Text = "Registar Doctor";
            this.BtnRegistDoctor.UseVisualStyleBackColor = true;
            this.BtnRegistDoctor.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Doctor.jpg");
            // 
            // FormTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 652);
            this.Controls.Add(this.BtnRegistDoctor);
            this.Controls.Add(this.mainTreeView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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