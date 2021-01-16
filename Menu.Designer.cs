
namespace RecepcjaWHotelu
{
    partial class Menu
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
            this.btn_zakwateruj = new System.Windows.Forms.Button();
            this.btn_wykwateruj = new System.Windows.Forms.Button();
            this.btn_wyklucz = new System.Windows.Forms.Button();
            this.btn_wyswietl = new System.Windows.Forms.Button();
            this.btn_rezerwuj = new System.Windows.Forms.Button();
            this.btn_zaplanowane = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_zakwateruj
            // 
            this.btn_zakwateruj.Location = new System.Drawing.Point(394, 253);
            this.btn_zakwateruj.Name = "btn_zakwateruj";
            this.btn_zakwateruj.Size = new System.Drawing.Size(201, 59);
            this.btn_zakwateruj.TabIndex = 0;
            this.btn_zakwateruj.Text = "Zakwateruj";
            this.btn_zakwateruj.UseVisualStyleBackColor = true;
            this.btn_zakwateruj.Click += new System.EventHandler(this.btn_zakwateruj_Click);
            // 
            // btn_wykwateruj
            // 
            this.btn_wykwateruj.Location = new System.Drawing.Point(685, 253);
            this.btn_wykwateruj.Name = "btn_wykwateruj";
            this.btn_wykwateruj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_wykwateruj.Size = new System.Drawing.Size(201, 59);
            this.btn_wykwateruj.TabIndex = 1;
            this.btn_wykwateruj.Text = "Wykwateruj";
            this.btn_wykwateruj.UseVisualStyleBackColor = true;
            this.btn_wykwateruj.Click += new System.EventHandler(this.btn_wykwateruj_Click);
            // 
            // btn_wyklucz
            // 
            this.btn_wyklucz.Location = new System.Drawing.Point(685, 343);
            this.btn_wyklucz.Name = "btn_wyklucz";
            this.btn_wyklucz.Size = new System.Drawing.Size(201, 59);
            this.btn_wyklucz.TabIndex = 3;
            this.btn_wyklucz.Text = "Edytuj wykluczenia";
            this.btn_wyklucz.UseVisualStyleBackColor = true;
            this.btn_wyklucz.Click += new System.EventHandler(this.btn_wyklucz_Click);
            // 
            // btn_wyswietl
            // 
            this.btn_wyswietl.Location = new System.Drawing.Point(394, 343);
            this.btn_wyswietl.Name = "btn_wyswietl";
            this.btn_wyswietl.Size = new System.Drawing.Size(201, 59);
            this.btn_wyswietl.TabIndex = 2;
            this.btn_wyswietl.Text = "Wyświetl aktywne zakwaterowania";
            this.btn_wyswietl.UseVisualStyleBackColor = true;
            this.btn_wyswietl.Click += new System.EventHandler(this.btn_wyswietl_Click);
            // 
            // btn_rezerwuj
            // 
            this.btn_rezerwuj.Location = new System.Drawing.Point(394, 169);
            this.btn_rezerwuj.Name = "btn_rezerwuj";
            this.btn_rezerwuj.Size = new System.Drawing.Size(489, 48);
            this.btn_rezerwuj.TabIndex = 4;
            this.btn_rezerwuj.Text = "Dodaj rezerwację";
            this.btn_rezerwuj.UseVisualStyleBackColor = true;
            this.btn_rezerwuj.Click += new System.EventHandler(this.btn_rezerwuj_Click);
            // 
            // btn_zaplanowane
            // 
            this.btn_zaplanowane.Location = new System.Drawing.Point(396, 427);
            this.btn_zaplanowane.Name = "btn_zaplanowane";
            this.btn_zaplanowane.Size = new System.Drawing.Size(201, 59);
            this.btn_zaplanowane.TabIndex = 5;
            this.btn_zaplanowane.Text = "Wyświetl zaplanowane rezerwacje";
            this.btn_zaplanowane.UseVisualStyleBackColor = true;
            this.btn_zaplanowane.Click += new System.EventHandler(this.btn_zaplanowane_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(685, 427);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(201, 59);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Wyloguj";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_zaplanowane);
            this.Controls.Add(this.btn_rezerwuj);
            this.Controls.Add(this.btn_wyklucz);
            this.Controls.Add(this.btn_wyswietl);
            this.Controls.Add(this.btn_wykwateruj);
            this.Controls.Add(this.btn_zakwateruj);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1276, 716);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_zakwateruj;
        private System.Windows.Forms.Button btn_wykwateruj;
        private System.Windows.Forms.Button btn_wyklucz;
        private System.Windows.Forms.Button btn_wyswietl;
        private System.Windows.Forms.Button btn_rezerwuj;
        private System.Windows.Forms.Button btn_zaplanowane;
        private System.Windows.Forms.Button btn_logout;
    }
}
