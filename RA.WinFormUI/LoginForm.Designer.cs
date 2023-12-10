namespace RA.WinFormUI
{
    partial class LoginForm
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
            bttnLogin = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            checkBeniHatirla = new CheckBox();
            SuspendLayout();
            // 
            // bttnLogin
            // 
            bttnLogin.Location = new Point(115, 109);
            bttnLogin.Name = "bttnLogin";
            bttnLogin.Size = new Size(157, 44);
            bttnLogin.TabIndex = 9;
            bttnLogin.Text = "Giriş";
            bttnLogin.UseVisualStyleBackColor = true;
            bttnLogin.Click += bttnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(115, 55);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(115, 23);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(157, 23);
            txtUserName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 59);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı :";
            // 
            // checkBeniHatirla
            // 
            checkBeniHatirla.AutoSize = true;
            checkBeniHatirla.Location = new Point(115, 84);
            checkBeniHatirla.Name = "checkBeniHatirla";
            checkBeniHatirla.Size = new Size(87, 19);
            checkBeniHatirla.TabIndex = 10;
            checkBeniHatirla.Text = "Beni Hatırla";
            checkBeniHatirla.UseVisualStyleBackColor = true;
            checkBeniHatirla.CheckedChanged += checkBeniHatirla_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 161);
            Controls.Add(checkBeniHatirla);
            Controls.Add(bttnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnLogin;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label2;
        private Label label1;
        private CheckBox checkBeniHatirla;
    }
}