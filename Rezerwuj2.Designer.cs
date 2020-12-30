
namespace RecepcjaWHotelu
{
    partial class Rezerwuj2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_potwierdz = new System.Windows.Forms.Button();
            this.txt_nazwisko = new System.Windows.Forms.TextBox();
            this.txt_imie = new System.Windows.Forms.TextBox();
            this.txt_numer = new System.Windows.Forms.MaskedTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Numer telefonu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Imie";
            // 
            // btn_potwierdz
            // 
            this.btn_potwierdz.Location = new System.Drawing.Point(158, 253);
            this.btn_potwierdz.Name = "btn_potwierdz";
            this.btn_potwierdz.Size = new System.Drawing.Size(244, 41);
            this.btn_potwierdz.TabIndex = 17;
            this.btn_potwierdz.Text = "Potwierdź";
            this.btn_potwierdz.UseVisualStyleBackColor = true;
            this.btn_potwierdz.Click += new System.EventHandler(this.btn_potwierdz_Click);
            // 
            // txt_nazwisko
            // 
            this.txt_nazwisko.Location = new System.Drawing.Point(158, 114);
            this.txt_nazwisko.Name = "txt_nazwisko";
            this.txt_nazwisko.Size = new System.Drawing.Size(244, 20);
            this.txt_nazwisko.TabIndex = 16;
            // 
            // txt_imie
            // 
            this.txt_imie.Location = new System.Drawing.Point(158, 58);
            this.txt_imie.Name = "txt_imie";
            this.txt_imie.Size = new System.Drawing.Size(244, 20);
            this.txt_imie.TabIndex = 15;
            // 
            // txt_numer
            // 
            this.txt_numer.Location = new System.Drawing.Point(158, 173);
            this.txt_numer.Mask = "(000) 000-000-000";
            this.txt_numer.Name = "txt_numer";
            this.txt_numer.Size = new System.Drawing.Size(244, 20);
            this.txt_numer.TabIndex = 14;
            this.txt_numer.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(452, 24);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(141, 48);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Powrót";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Rezerwuj2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_potwierdz);
            this.Controls.Add(this.txt_nazwisko);
            this.Controls.Add(this.txt_imie);
            this.Controls.Add(this.txt_numer);
            this.Name = "Rezerwuj2";
            this.Size = new System.Drawing.Size(711, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_potwierdz;
        private System.Windows.Forms.TextBox txt_nazwisko;
        private System.Windows.Forms.TextBox txt_imie;
        private System.Windows.Forms.MaskedTextBox txt_numer;
        private System.Windows.Forms.Button btn_back;
    }
}
