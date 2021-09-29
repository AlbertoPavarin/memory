
namespace Memory
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VincitoreLbl = new System.Windows.Forms.Label();
            this.PunteggioLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VincitoreLbl
            // 
            this.VincitoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VincitoreLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VincitoreLbl.Location = new System.Drawing.Point(111, 369);
            this.VincitoreLbl.Name = "VincitoreLbl";
            this.VincitoreLbl.Size = new System.Drawing.Size(372, 23);
            this.VincitoreLbl.TabIndex = 0;
            this.VincitoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VincitoreLbl.Visible = false;
            // 
            // PunteggioLbl
            // 
            this.PunteggioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunteggioLbl.Location = new System.Drawing.Point(12, 429);
            this.PunteggioLbl.Name = "PunteggioLbl";
            this.PunteggioLbl.Size = new System.Drawing.Size(182, 32);
            this.PunteggioLbl.TabIndex = 1;
            this.PunteggioLbl.Text = "Punteggio: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.PunteggioLbl);
            this.Controls.Add(this.VincitoreLbl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label VincitoreLbl;
        private System.Windows.Forms.Label PunteggioLbl;
    }
}

