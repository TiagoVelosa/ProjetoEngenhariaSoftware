
namespace ProjetoEngenhariaSoftware
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.UsernameError = new System.Windows.Forms.Label();
            this.PassWordError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.LightGray;
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(118, 162);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(292, 35);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.BackColor = System.Drawing.Color.LightGray;
            this.PassWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordTextBox.Location = new System.Drawing.Point(118, 284);
            this.PassWordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.PasswordChar = '*';
            this.PassWordTextBox.Size = new System.Drawing.Size(292, 35);
            this.PassWordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(202, 366);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(120, 42);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // UsernameError
            // 
            this.UsernameError.AutoSize = true;
            this.UsernameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameError.ForeColor = System.Drawing.Color.Red;
            this.UsernameError.Location = new System.Drawing.Point(414, 172);
            this.UsernameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameError.Name = "UsernameError";
            this.UsernameError.Size = new System.Drawing.Size(78, 20);
            this.UsernameError.TabIndex = 17;
            this.UsernameError.Text = "Required!";
            this.UsernameError.Visible = false;
            // 
            // PassWordError
            // 
            this.PassWordError.AutoSize = true;
            this.PassWordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordError.ForeColor = System.Drawing.Color.Red;
            this.PassWordError.Location = new System.Drawing.Point(414, 293);
            this.PassWordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassWordError.Name = "PassWordError";
            this.PassWordError.Size = new System.Drawing.Size(78, 20);
            this.PassWordError.TabIndex = 18;
            this.PassWordError.Text = "Required!";
            this.PassWordError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PassWordError);
            this.Controls.Add(this.UsernameError);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(532, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label UsernameError;
        private System.Windows.Forms.Label PassWordError;
    }
}
