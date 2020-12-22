
namespace RecepcjaWHotelu
{
    partial class Platnosc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kwota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_gotowka = new System.Windows.Forms.RadioButton();
            this.rd_karta = new System.Windows.Forms.RadioButton();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wartość rachunku";
            // 
            // txt_kwota
            // 
            this.txt_kwota.Location = new System.Drawing.Point(200, 93);
            this.txt_kwota.Name = "txt_kwota";
            this.txt_kwota.Size = new System.Drawing.Size(160, 20);
            this.txt_kwota.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metoda płatności";
            // 
            // rd_gotowka
            // 
            this.rd_gotowka.AutoSize = true;
            this.rd_gotowka.Location = new System.Drawing.Point(200, 146);
            this.rd_gotowka.Name = "rd_gotowka";
            this.rd_gotowka.Size = new System.Drawing.Size(68, 17);
            this.rd_gotowka.TabIndex = 3;
            this.rd_gotowka.TabStop = true;
            this.rd_gotowka.Text = "Gotówka";
            this.rd_gotowka.UseVisualStyleBackColor = true;
            // 
            // rd_karta
            // 
            this.rd_karta.AutoSize = true;
            this.rd_karta.Location = new System.Drawing.Point(200, 169);
            this.rd_karta.Name = "rd_karta";
            this.rd_karta.Size = new System.Drawing.Size(50, 17);
            this.rd_karta.TabIndex = 4;
            this.rd_karta.TabStop = true;
            this.rd_karta.Text = "Karta";
            this.rd_karta.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(200, 238);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(150, 46);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "Potwierdź";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // Platnosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.rd_karta);
            this.Controls.Add(this.rd_gotowka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kwota);
            this.Controls.Add(this.label1);
            this.Name = "Platnosc";
            this.Size = new System.Drawing.Size(670, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kwota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rd_gotowka;
        private System.Windows.Forms.RadioButton rd_karta;
        private System.Windows.Forms.Button btn_confirm;
    }
}
