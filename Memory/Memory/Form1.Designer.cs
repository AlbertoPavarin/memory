
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VincitoreLbl = new System.Windows.Forms.Label();
            this.punti1Lbl = new System.Windows.Forms.Label();
            this.utente2Txt = new System.Windows.Forms.TextBox();
            this.giocaBtn = new System.Windows.Forms.Button();
            this.utente1Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.punti2Lbl = new System.Windows.Forms.Label();
            this.turnoLbl = new System.Windows.Forms.Label();
            this.partitaBtn = new System.Windows.Forms.Button();
            this.storicoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VincitoreLbl
            // 
            this.VincitoreLbl.BackColor = System.Drawing.Color.Transparent;
            this.VincitoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VincitoreLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VincitoreLbl.Location = new System.Drawing.Point(-6, 369);
            this.VincitoreLbl.Name = "VincitoreLbl";
            this.VincitoreLbl.Size = new System.Drawing.Size(649, 40);
            this.VincitoreLbl.TabIndex = 0;
            this.VincitoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VincitoreLbl.Visible = false;
            // 
            // punti1Lbl
            // 
            this.punti1Lbl.BackColor = System.Drawing.Color.Transparent;
            this.punti1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punti1Lbl.Location = new System.Drawing.Point(12, 420);
            this.punti1Lbl.Name = "punti1Lbl";
            this.punti1Lbl.Size = new System.Drawing.Size(299, 32);
            this.punti1Lbl.TabIndex = 1;
            this.punti1Lbl.Visible = false;
            // 
            // utente2Txt
            // 
            this.utente2Txt.Location = new System.Drawing.Point(213, 229);
            this.utente2Txt.MaxLength = 10;
            this.utente2Txt.Name = "utente2Txt";
            this.utente2Txt.Size = new System.Drawing.Size(205, 20);
            this.utente2Txt.TabIndex = 3;
            // 
            // giocaBtn
            // 
            this.giocaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giocaBtn.Location = new System.Drawing.Point(268, 265);
            this.giocaBtn.Name = "giocaBtn";
            this.giocaBtn.Size = new System.Drawing.Size(90, 50);
            this.giocaBtn.TabIndex = 4;
            this.giocaBtn.Text = "Gioca";
            this.giocaBtn.UseVisualStyleBackColor = true;
            this.giocaBtn.Click += new System.EventHandler(this.giocaBtn_Click);
            // 
            // utente1Txt
            // 
            this.utente1Txt.Location = new System.Drawing.Point(213, 168);
            this.utente1Txt.MaxLength = 10;
            this.utente1Txt.Name = "utente1Txt";
            this.utente1Txt.Size = new System.Drawing.Size(205, 20);
            this.utente1Txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(210, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserisci il nome dell\'utente 1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(210, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inserisci il nome dell\'utente 2";
            // 
            // punti2Lbl
            // 
            this.punti2Lbl.BackColor = System.Drawing.Color.Transparent;
            this.punti2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punti2Lbl.Location = new System.Drawing.Point(321, 420);
            this.punti2Lbl.Name = "punti2Lbl";
            this.punti2Lbl.Size = new System.Drawing.Size(312, 32);
            this.punti2Lbl.TabIndex = 8;
            this.punti2Lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.punti2Lbl.Visible = false;
            // 
            // turnoLbl
            // 
            this.turnoLbl.BackColor = System.Drawing.Color.Transparent;
            this.turnoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoLbl.Location = new System.Drawing.Point(-2, -2);
            this.turnoLbl.Name = "turnoLbl";
            this.turnoLbl.Size = new System.Drawing.Size(635, 64);
            this.turnoLbl.TabIndex = 9;
            this.turnoLbl.Text = "É il turno di: ";
            this.turnoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.turnoLbl.Visible = false;
            // 
            // partitaBtn
            // 
            this.partitaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partitaBtn.Location = new System.Drawing.Point(268, 330);
            this.partitaBtn.Name = "partitaBtn";
            this.partitaBtn.Size = new System.Drawing.Size(90, 50);
            this.partitaBtn.TabIndex = 10;
            this.partitaBtn.Text = "Ultima Partita";
            this.partitaBtn.UseVisualStyleBackColor = true;
            this.partitaBtn.Click += new System.EventHandler(this.storicoBtn_Click);
            // 
            // storicoLbl
            // 
            this.storicoLbl.BackColor = System.Drawing.Color.Transparent;
            this.storicoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storicoLbl.Location = new System.Drawing.Point(0, 11);
            this.storicoLbl.Name = "storicoLbl";
            this.storicoLbl.Size = new System.Drawing.Size(633, 108);
            this.storicoLbl.TabIndex = 11;
            this.storicoLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.storicoLbl);
            this.Controls.Add(this.partitaBtn);
            this.Controls.Add(this.turnoLbl);
            this.Controls.Add(this.punti2Lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.utente1Txt);
            this.Controls.Add(this.giocaBtn);
            this.Controls.Add(this.utente2Txt);
            this.Controls.Add(this.punti1Lbl);
            this.Controls.Add(this.VincitoreLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label VincitoreLbl;
        private System.Windows.Forms.Label punti1Lbl;
        private System.Windows.Forms.TextBox utente2Txt;
        private System.Windows.Forms.Button giocaBtn;
        private System.Windows.Forms.TextBox utente1Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label punti2Lbl;
        private System.Windows.Forms.Label turnoLbl;
        private System.Windows.Forms.Button partitaBtn;
        private System.Windows.Forms.Label storicoLbl;
    }
}

