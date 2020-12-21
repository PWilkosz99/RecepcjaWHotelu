
namespace RecepcjaWHotelu
{
    partial class Login
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ULogin = new System.Windows.Forms.TextBox();
            this.UPassword = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_conn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ULogin
            // 
            this.ULogin.Location = new System.Drawing.Point(161, 43);
            this.ULogin.Name = "ULogin";
            this.ULogin.Size = new System.Drawing.Size(451, 20);
            this.ULogin.TabIndex = 0;
            // 
            // UPassword
            // 
            this.UPassword.Location = new System.Drawing.Point(161, 125);
            this.UPassword.Name = "UPassword";
            this.UPassword.PasswordChar = '*';
            this.UPassword.Size = new System.Drawing.Size(451, 20);
            this.UPassword.TabIndex = 1;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(304, 187);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(160, 48);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "Zaloguj!";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło:";
            // 
            // label_conn
            // 
            this.label_conn.AutoSize = true;
            this.label_conn.ForeColor = System.Drawing.Color.OliveDrab;
            this.label_conn.Location = new System.Drawing.Point(276, 160);
            this.label_conn.Name = "label_conn";
            this.label_conn.Size = new System.Drawing.Size(212, 13);
            this.label_conn.TabIndex = 5;
            this.label_conn.Text = "Nawiązywanie połączenia z bazą danych...";
            this.label_conn.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_conn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.UPassword);
            this.Controls.Add(this.ULogin);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1200, 287);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ULogin;
        private System.Windows.Forms.TextBox UPassword;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_conn;
    }
}
