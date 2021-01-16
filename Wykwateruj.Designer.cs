
namespace RecepcjaWHotelu
{
    partial class Wykwateruj
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
            this.txt_nrrezerwacji = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_numerpokoju = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nrrezerwacji
            // 
            this.txt_nrrezerwacji.Location = new System.Drawing.Point(500, 248);
            this.txt_nrrezerwacji.Name = "txt_nrrezerwacji";
            this.txt_nrrezerwacji.Size = new System.Drawing.Size(276, 20);
            this.txt_nrrezerwacji.TabIndex = 1;
            this.txt_nrrezerwacji.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nrrezerwacji_KeyPress);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(500, 418);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(141, 46);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Potwierdź";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numer rezerwacji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numer pokoju";
            // 
            // cmb_numerpokoju
            // 
            this.cmb_numerpokoju.FormattingEnabled = true;
            this.cmb_numerpokoju.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmb_numerpokoju.Location = new System.Drawing.Point(500, 330);
            this.cmb_numerpokoju.Name = "cmb_numerpokoju";
            this.cmb_numerpokoju.Size = new System.Drawing.Size(276, 21);
            this.cmb_numerpokoju.TabIndex = 5;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(647, 416);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(141, 48);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Powrót";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Wykwateruj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.cmb_numerpokoju);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_nrrezerwacji);
            this.Name = "Wykwateruj";
            this.Size = new System.Drawing.Size(1276, 716);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nrrezerwacji;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_numerpokoju;
        private System.Windows.Forms.Button btn_back;
    }
}
