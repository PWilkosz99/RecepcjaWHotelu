
namespace RecepcjaWHotelu
{
    partial class Rezerwuj
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
            this.txt_nrrez = new System.Windows.Forms.TextBox();
            this.date_od = new System.Windows.Forms.DateTimePicker();
            this.date_do = new System.Windows.Forms.DateTimePicker();
            this.cmb_osob = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_parking = new System.Windows.Forms.CheckBox();
            this.chk_spa = new System.Windows.Forms.CheckBox();
            this.chk_jedzenie = new System.Windows.Forms.CheckBox();
            this.chk_silownia = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_nrrez
            // 
            this.txt_nrrez.Location = new System.Drawing.Point(150, 56);
            this.txt_nrrez.MaxLength = 30;
            this.txt_nrrez.Name = "txt_nrrez";
            this.txt_nrrez.Size = new System.Drawing.Size(247, 20);
            this.txt_nrrez.TabIndex = 0;
            this.txt_nrrez.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nrrez_KeyPress);
            // 
            // date_od
            // 
            this.date_od.Location = new System.Drawing.Point(145, 121);
            this.date_od.Name = "date_od";
            this.date_od.Size = new System.Drawing.Size(246, 20);
            this.date_od.TabIndex = 1;
            this.date_od.Value = new System.DateTime(2020, 12, 21, 0, 0, 0, 0);
            // 
            // date_do
            // 
            this.date_do.Location = new System.Drawing.Point(145, 174);
            this.date_do.Name = "date_do";
            this.date_do.Size = new System.Drawing.Size(246, 20);
            this.date_do.TabIndex = 2;
            this.date_do.Value = new System.DateTime(2020, 12, 21, 0, 0, 0, 0);
            // 
            // cmb_osob
            // 
            this.cmb_osob.FormattingEnabled = true;
            this.cmb_osob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_osob.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmb_osob.Location = new System.Drawing.Point(204, 232);
            this.cmb_osob.Name = "cmb_osob";
            this.cmb_osob.Size = new System.Drawing.Size(121, 21);
            this.cmb_osob.TabIndex = 3;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(148, 362);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(249, 36);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Potwierdź";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numer Rezerwacji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ilość osób";
            // 
            // chk_parking
            // 
            this.chk_parking.AutoSize = true;
            this.chk_parking.Location = new System.Drawing.Point(145, 272);
            this.chk_parking.Name = "chk_parking";
            this.chk_parking.Size = new System.Drawing.Size(120, 17);
            this.chk_parking.TabIndex = 9;
            this.chk_parking.Text = "Miejsce parkingowe";
            this.chk_parking.UseVisualStyleBackColor = true;
            // 
            // chk_spa
            // 
            this.chk_spa.AutoSize = true;
            this.chk_spa.Location = new System.Drawing.Point(316, 272);
            this.chk_spa.Name = "chk_spa";
            this.chk_spa.Size = new System.Drawing.Size(88, 17);
            this.chk_spa.TabIndex = 10;
            this.chk_spa.Text = "Pobyt w SPA";
            this.chk_spa.UseVisualStyleBackColor = true;
            // 
            // chk_jedzenie
            // 
            this.chk_jedzenie.AutoSize = true;
            this.chk_jedzenie.Location = new System.Drawing.Point(145, 309);
            this.chk_jedzenie.Name = "chk_jedzenie";
            this.chk_jedzenie.Size = new System.Drawing.Size(58, 17);
            this.chk_jedzenie.TabIndex = 11;
            this.chk_jedzenie.Text = "Posiłki";
            this.chk_jedzenie.UseVisualStyleBackColor = true;
            // 
            // chk_silownia
            // 
            this.chk_silownia.AutoSize = true;
            this.chk_silownia.Location = new System.Drawing.Point(316, 309);
            this.chk_silownia.Name = "chk_silownia";
            this.chk_silownia.Size = new System.Drawing.Size(114, 17);
            this.chk_silownia.TabIndex = 12;
            this.chk_silownia.Text = "Wstęp na siłownie";
            this.chk_silownia.UseVisualStyleBackColor = true;
            // 
            // Rezerwuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_silownia);
            this.Controls.Add(this.chk_jedzenie);
            this.Controls.Add(this.chk_spa);
            this.Controls.Add(this.chk_parking);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cmb_osob);
            this.Controls.Add(this.date_do);
            this.Controls.Add(this.date_od);
            this.Controls.Add(this.txt_nrrez);
            this.Name = "Rezerwuj";
            this.Size = new System.Drawing.Size(632, 494);
            this.Load += new System.EventHandler(this.Rezerwuj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date_od;
        private System.Windows.Forms.DateTimePicker date_do;
        private System.Windows.Forms.ComboBox cmb_osob;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_parking;
        private System.Windows.Forms.CheckBox chk_spa;
        private System.Windows.Forms.CheckBox chk_jedzenie;
        private System.Windows.Forms.CheckBox chk_silownia;
        private System.Windows.Forms.TextBox txt_nrrez;
    }
}
