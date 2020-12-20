
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_zakwateruj
            // 
            this.btn_zakwateruj.Location = new System.Drawing.Point(133, 60);
            this.btn_zakwateruj.Name = "btn_zakwateruj";
            this.btn_zakwateruj.Size = new System.Drawing.Size(201, 59);
            this.btn_zakwateruj.TabIndex = 0;
            this.btn_zakwateruj.Text = "Zakwateruj";
            this.btn_zakwateruj.UseVisualStyleBackColor = true;
            this.btn_zakwateruj.Click += new System.EventHandler(this.btn_zakwateruj_Click);
            // 
            // btn_wykwateruj
            // 
            this.btn_wykwateruj.Location = new System.Drawing.Point(412, 60);
            this.btn_wykwateruj.Name = "btn_wykwateruj";
            this.btn_wykwateruj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_wykwateruj.Size = new System.Drawing.Size(201, 59);
            this.btn_wykwateruj.TabIndex = 1;
            this.btn_wykwateruj.Text = "Wykwateruj";
            this.btn_wykwateruj.UseVisualStyleBackColor = true;
            this.btn_wykwateruj.Click += new System.EventHandler(this.btn_wykwateruj_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 59);
            this.button4.TabIndex = 2;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_wykwateruj);
            this.Controls.Add(this.btn_zakwateruj);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(918, 458);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_zakwateruj;
        private System.Windows.Forms.Button btn_wykwateruj;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
