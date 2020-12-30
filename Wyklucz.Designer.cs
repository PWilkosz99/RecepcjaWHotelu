
namespace RecepcjaWHotelu
{
    partial class Wyklucz
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
            this.lb_pokoj = new System.Windows.Forms.Label();
            this.cmb_pokoj = new System.Windows.Forms.ComboBox();
            this.lbl_powod = new System.Windows.Forms.Label();
            this.txt_powod = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_pokoj
            // 
            this.lb_pokoj.AutoSize = true;
            this.lb_pokoj.Location = new System.Drawing.Point(251, 96);
            this.lb_pokoj.Name = "lb_pokoj";
            this.lb_pokoj.Size = new System.Drawing.Size(73, 13);
            this.lb_pokoj.TabIndex = 0;
            this.lb_pokoj.Text = "Numer pokoju";
            // 
            // cmb_pokoj
            // 
            this.cmb_pokoj.FormattingEnabled = true;
            this.cmb_pokoj.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmb_pokoj.Location = new System.Drawing.Point(186, 139);
            this.cmb_pokoj.Name = "cmb_pokoj";
            this.cmb_pokoj.Size = new System.Drawing.Size(191, 21);
            this.cmb_pokoj.TabIndex = 1;
            // 
            // lbl_powod
            // 
            this.lbl_powod.AutoSize = true;
            this.lbl_powod.Location = new System.Drawing.Point(265, 213);
            this.lbl_powod.Name = "lbl_powod";
            this.lbl_powod.Size = new System.Drawing.Size(40, 13);
            this.lbl_powod.TabIndex = 2;
            this.lbl_powod.Text = "Powód";
            // 
            // txt_powod
            // 
            this.txt_powod.Location = new System.Drawing.Point(112, 241);
            this.txt_powod.Name = "txt_powod";
            this.txt_powod.Size = new System.Drawing.Size(346, 20);
            this.txt_powod.TabIndex = 3;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(112, 334);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(163, 57);
            this.btn_confirm.TabIndex = 4;
            this.btn_confirm.Text = "Dodaj";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(281, 334);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(177, 57);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Usuń";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(411, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(141, 48);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Powrót";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Wyklucz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_powod);
            this.Controls.Add(this.lbl_powod);
            this.Controls.Add(this.cmb_pokoj);
            this.Controls.Add(this.lb_pokoj);
            this.Name = "Wyklucz";
            this.Size = new System.Drawing.Size(971, 554);
            this.Load += new System.EventHandler(this.Wyklucz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_pokoj;
        private System.Windows.Forms.ComboBox cmb_pokoj;
        private System.Windows.Forms.Label lbl_powod;
        private System.Windows.Forms.TextBox txt_powod;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
    }
}
