
namespace RecepcjaWHotelu
{
    partial class Zaplanowane
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(250, 53);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(777, 393);
            this.dg.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(871, 516);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(156, 48);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Powrót";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(250, 516);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(140, 48);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Odśwież";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(618, 516);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(156, 48);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Usuń";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(460, 516);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(156, 48);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Aktualizuj";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Zaplanowane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dg);
            this.Name = "Zaplanowane";
            this.Size = new System.Drawing.Size(1276, 716);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
    }
}
