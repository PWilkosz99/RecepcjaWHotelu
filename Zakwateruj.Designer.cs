
namespace RecepcjaWHotelu
{
    partial class Zakwateruj
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
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.txt_numer = new System.Windows.Forms.MaskedTextBox();
            this.txt_imie = new System.Windows.Forms.TextBox();
            this.txt_nazwisko = new System.Windows.Forms.TextBox();
            this.btn_potwierdz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dt1
            // 
            this.dt1.Location = new System.Drawing.Point(137, 92);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(227, 20);
            this.dt1.TabIndex = 1;
            // 
            // dt2
            // 
            this.dt2.Location = new System.Drawing.Point(394, 92);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(206, 20);
            this.dt2.TabIndex = 3;
            // 
            // txt_numer
            // 
            this.txt_numer.Location = new System.Drawing.Point(252, 205);
            this.txt_numer.Mask = "(000) 000-000-000";
            this.txt_numer.Name = "txt_numer";
            this.txt_numer.Size = new System.Drawing.Size(250, 20);
            this.txt_numer.TabIndex = 5;
            // 
            // txt_imie
            // 
            this.txt_imie.Location = new System.Drawing.Point(137, 150);
            this.txt_imie.Name = "txt_imie";
            this.txt_imie.Size = new System.Drawing.Size(227, 20);
            this.txt_imie.TabIndex = 6;
            // 
            // txt_nazwisko
            // 
            this.txt_nazwisko.Location = new System.Drawing.Point(394, 150);
            this.txt_nazwisko.Name = "txt_nazwisko";
            this.txt_nazwisko.Size = new System.Drawing.Size(206, 20);
            this.txt_nazwisko.TabIndex = 7;
            // 
            // btn_potwierdz
            // 
            this.btn_potwierdz.Location = new System.Drawing.Point(258, 285);
            this.btn_potwierdz.Name = "btn_potwierdz";
            this.btn_potwierdz.Size = new System.Drawing.Size(244, 41);
            this.btn_potwierdz.TabIndex = 8;
            this.btn_potwierdz.Text = "Potwierdź";
            this.btn_potwierdz.UseVisualStyleBackColor = true;
            this.btn_potwierdz.Click += new System.EventHandler(this.btn_potwierdz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Imie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nazwisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Numer telefonu";
            // 
            // Zakwateruj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_potwierdz);
            this.Controls.Add(this.txt_nazwisko);
            this.Controls.Add(this.txt_imie);
            this.Controls.Add(this.txt_numer);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.dt1);
            this.Name = "Zakwateruj";
            this.Size = new System.Drawing.Size(847, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.MaskedTextBox txt_numer;
        private System.Windows.Forms.TextBox txt_imie;
        private System.Windows.Forms.TextBox txt_nazwisko;
        private System.Windows.Forms.Button btn_potwierdz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
