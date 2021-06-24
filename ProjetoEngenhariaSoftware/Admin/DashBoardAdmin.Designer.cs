
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
            this.BtnLoggout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLoggout)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTreeView
            // 
            this.mainTreeView.ImageIndex = 0;
            this.mainTreeView.ImageList = this.imageList1;
            this.mainTreeView.Location = new System.Drawing.Point(0, 66);
            this.mainTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTreeView.Name = "mainTreeView";
            this.mainTreeView.SelectedImageIndex = 0;
            this.mainTreeView.Size = new System.Drawing.Size(400, 587);
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
            this.BtnRegistDoctor.Location = new System.Drawing.Point(13, 14);
            this.BtnRegistDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistDoctor.Name = "BtnRegistDoctor";
            this.BtnRegistDoctor.Size = new System.Drawing.Size(212, 36);
            this.BtnRegistDoctor.TabIndex = 1;
            this.BtnRegistDoctor.Text = "Registar Doctor";
            this.BtnRegistDoctor.UseVisualStyleBackColor = false;
            this.BtnRegistDoctor.Click += new System.EventHandler(this.BtnRegisterDoctor_Click);
            // 
            // BtnLoggout
            // 
            this.BtnLoggout.Image = global::ProjetoEngenhariaSoftware.Properties.Resources.logout;
            this.BtnLoggout.Location = new System.Drawing.Point(323, 10);
            this.BtnLoggout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLoggout.Name = "BtnLoggout";
            this.BtnLoggout.Size = new System.Drawing.Size(61, 46);
            this.BtnLoggout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLoggout.TabIndex = 2;
            this.BtnLoggout.TabStop = false;
            this.BtnLoggout.Click += new System.EventHandler(this.BtnLoggout_Click);
            // 
            // FormTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 652);
            this.Controls.Add(this.BtnLoggout);
            this.Controls.Add(this.BtnRegistDoctor);
            this.Controls.Add(this.mainTreeView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTeste";
            this.Text = "FormTeste";
            ((System.ComponentModel.ISupportInitialize)(this.BtnLoggout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mainTreeView;
        private System.Windows.Forms.Button BtnRegistDoctor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox BtnLoggout;
    }
}