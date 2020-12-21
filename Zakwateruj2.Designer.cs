
namespace RecepcjaWHotelu
{
    partial class Zakwateruj2
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
            this.bx_nrpokoju = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nrrez = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.rd_teraz = new System.Windows.Forms.RadioButton();
            this.rd_pozniej = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.bx_nrpokoju.Location = new System.Drawing.Point(240, 89);
            this.bx_nrpokoju.Name = "bx_nrpokoju";
            this.bx_nrpokoju.Size = new System.Drawing.Size(272, 21);
            this.bx_nrpokoju.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer pokoju";
            // 
            // txt_nrrez
            // 
            this.txt_nrrez.Location = new System.Drawing.Point(241, 156);
            this.txt_nrrez.Name = "txt_nrrez";
            this.txt_nrrez.Size = new System.Drawing.Size(270, 20);
            this.txt_nrrez.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numer rezerwacji";
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(302, 281);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(155, 46);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Potwierdź";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // rd_teraz
            // 
            this.rd_teraz.AutoSize = true;
            this.rd_teraz.Location = new System.Drawing.Point(267, 227);
            this.rd_teraz.Name = "rd_teraz";
            this.rd_teraz.Size = new System.Drawing.Size(52, 17);
            this.rd_teraz.TabIndex = 5;
            this.rd_teraz.TabStop = true;
            this.rd_teraz.Text = "Teraz";
            this.rd_teraz.UseVisualStyleBackColor = true;
            // 
            // rd_pozniej
            // 
            this.rd_pozniej.AutoSize = true;
            this.rd_pozniej.Location = new System.Drawing.Point(267, 250);
            this.rd_pozniej.Name = "rd_pozniej";
            this.rd_pozniej.Size = new System.Drawing.Size(117, 17);
            this.rd_pozniej.TabIndex = 6;
            this.rd_pozniej.TabStop = true;
            this.rd_pozniej.Text = "Przy wymeldowaniu";
            this.rd_pozniej.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rodzaj płatności";
            // 
            // Zakwateruj2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rd_pozniej);
            this.Controls.Add(this.rd_teraz);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nrrez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bx_nrpokoju);
            this.Name = "Zakwateruj2";
            this.Size = new System.Drawing.Size(765, 405);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bx_nrpokoju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nrrez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.RadioButton rd_teraz;
        private System.Windows.Forms.RadioButton rd_pozniej;
        private System.Windows.Forms.Label label3;
    }
}
