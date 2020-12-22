
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
            this.btn_potwierdz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_pozniej = new System.Windows.Forms.RadioButton();
            this.rd_teraz = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nrrez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bx_nrpokoju = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Termin płatności";
            // 
            // rd_pozniej
            // 
            this.rd_pozniej.AutoSize = true;
            this.rd_pozniej.Location = new System.Drawing.Point(283, 242);
            this.rd_pozniej.Name = "rd_pozniej";
            this.rd_pozniej.Size = new System.Drawing.Size(117, 17);
            this.rd_pozniej.TabIndex = 14;
            this.rd_pozniej.TabStop = true;
            this.rd_pozniej.Text = "Przy wymeldowaniu";
            this.rd_pozniej.UseVisualStyleBackColor = true;
            // 
            // rd_teraz
            // 
            this.rd_teraz.AutoSize = true;
            this.rd_teraz.Location = new System.Drawing.Point(283, 219);
            this.rd_teraz.Name = "rd_teraz";
            this.rd_teraz.Size = new System.Drawing.Size(52, 17);
            this.rd_teraz.TabIndex = 13;
            this.rd_teraz.TabStop = true;
            this.rd_teraz.Text = "Teraz";
            this.rd_teraz.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numer rezerwacji";
            // 
            // txt_nrrez
            // 
            this.txt_nrrez.Location = new System.Drawing.Point(256, 79);
            this.txt_nrrez.Name = "txt_nrrez";
            this.txt_nrrez.Size = new System.Drawing.Size(270, 20);
            this.txt_nrrez.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numer pokoju";
            // 
            // bx_nrpokoju
            // 
            this.bx_nrpokoju.FormattingEnabled = true;
            this.bx_nrpokoju.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.bx_nrpokoju.Location = new System.Drawing.Point(256, 154);
            this.bx_nrpokoju.Name = "bx_nrpokoju";
            this.bx_nrpokoju.Size = new System.Drawing.Size(272, 21);
            this.bx_nrpokoju.TabIndex = 9;
            // 
            // Zakwateruj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rd_pozniej);
            this.Controls.Add(this.rd_teraz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nrrez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bx_nrpokoju);
            this.Controls.Add(this.btn_potwierdz);
            this.Name = "Zakwateruj";
            this.Size = new System.Drawing.Size(847, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_potwierdz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd_pozniej;
        private System.Windows.Forms.RadioButton rd_teraz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nrrez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bx_nrpokoju;
    }
}
