using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Memory
{
    public partial class Form1 : Form
    {

        int nChitarra, nAmp, nBatteria, nMetronomo = 0;

        int punteggio1 = 0;
        int punteggio2 = 0;

        string percorso = AppDomain.CurrentDomain.BaseDirectory + "ultimaPartita";

        int turno;

        string utente1, utente2;

        PictureBox primoClick, secondoClick;

        PictureBox[] memory = new PictureBox[8];

        Random turnoRnd = new Random();

        int xImg = 100;
        int yImg = 110;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.sfondo;
        }

        public void creazioneImg()
        {
            for (int i = 0; i < memory.Length; i++)
            {
                int nCarta = random.Next(0, 4);
                if (controlloNCarte(nCarta) > 2)
                {
                    i--;
                }
                else
                {
                    string nome;
                    memory[i] = new PictureBox();
                    memory[i].Name = nomeCarta(nCarta);
                    nome = memory[i].Name;
                    memory[i].Size = new Size(100, 100);
                    memory[i].Location = new Point(xImg, yImg);
                    memory[i].Image = assegnazioneCarta(nCarta);
                    memory[i].BackColor = Color.LightBlue;
                    memory[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    memory[i].Padding = new Padding(5000, 0, 0, 0);
                    memory[i].BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(memory[i]);
                    memory[i].Click += new EventHandler(clickCarta);
     
                    xImg += memory[i].Width + 10;

                    if (xImg >= 440)
                    {
                        yImg += 120;
                        xImg = 100;
                    }
                }                
            }
        }

        public Image assegnazioneCarta(int nCarta)
        {
            Image simboloCarta = null;
            switch (nCarta)
            {
                case 0:
                    simboloCarta = Properties.Resources._1;
                    return simboloCarta;
                case 1:
                    simboloCarta = Properties.Resources._2;
                    return simboloCarta;
                case 2:
                    simboloCarta = Properties.Resources._3;
                    return simboloCarta;
                case 3:
                    simboloCarta = Properties.Resources._4;
                    return simboloCarta;
            }
            return simboloCarta;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            primoClick.Padding = new Padding(5000, 0, 0, 0);
            secondoClick.Padding = new Padding(5000, 0, 0, 0);
            primoClick.BackColor = Color.LightBlue;
            secondoClick.BackColor = Color.LightBlue;

            primoClick.Enabled = true;
            secondoClick.Enabled = true;
            primoClick = null;
            secondoClick = null;
        }

        public void salvaPunteggi()
        {
            StreamWriter punteggi = new StreamWriter(percorso);           
            punteggi.WriteLine($"L'ultima partita tra {utente1} e {utente2} si è concluso con il punteggio:\n{punteggio1} - {punteggio2}\n");
            punteggi.Close();
        }

        private void storicoBtn_Click(object sender, EventArgs e)
        {
            storicoLbl.Visible = true;           
            StreamReader leggiStorico = new StreamReader(percorso);
            storicoLbl.Text = leggiStorico.ReadToEnd();
        }

        private void giocaBtn_Click(object sender, EventArgs e)
        {
            if (utente1Txt.Text != "" && utente2Txt.Text != "")
            {
                storicoLbl.Visible = false;
                partitaBtn.Visible = false;
                turnoLbl.Visible = true;
                utente1 = utente1Txt.Text;
                utente2 = utente2Txt.Text;
                utente1Txt.Visible = false;
                utente2Txt.Visible = false;
                giocaBtn.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                punti1Lbl.Text = $"Punteggio {utente1}: {punteggio1}";
                punti2Lbl.Text = $"Punteggio {utente2}: {punteggio2}";
                punti1Lbl.Visible = true;
                punti2Lbl.Visible = true;
                turno = turnoRnd.Next(1, 3);
                if (turno == 1)
                    turnoLbl.Text += $"{utente1}";
                else
                    turnoLbl.Text += $"{utente2}";
                creazioneImg();
            }
            else
            {
                MessageBox.Show("Inserire dei nomi utenti");
            }
        }
    
        public int controlloNCarte(int nCarta)
        {
            switch (nCarta)
            {
                case 0:
                    nChitarra++;
                    return nChitarra;
                case 1:
                    nAmp++; 
                    return nAmp;
                case 2:
                    nBatteria++;
                    return nBatteria;
                case 3:
                    nMetronomo++;
                    return nMetronomo;
            }
            return -1;
        }

        public string nomeCarta(int nCarta)
        {
            string nome = "";
            switch (nCarta)
            {
                case 0:
                    nome = "Chitarra";
                    return nome;
                case 1:
                    nome = "Amplificatore";
                    return nome;
                case 2:
                    nome = "Batteria";
                    return nome;
                case 3:
                    nome = "Metronomo";
                    return nome;
            }

            return nome;
        }

        public void clickCarta(object sender, EventArgs ea)
        {
            if (primoClick != null && secondoClick != null)
            {
                return;
            }

            PictureBox cartaCliccata = sender as PictureBox;

            if (cartaCliccata == null)
            {
                return;
            }
            
            if (primoClick == null)
            {
                primoClick = cartaCliccata;
                primoClick.BackColor = Color.CadetBlue;
                primoClick.Enabled = false;
                primoClick.Image = cartaCliccata.Image;
                primoClick.Padding = new Padding(10, 10, 10, 10);
                return;
            }

            secondoClick = cartaCliccata;
            secondoClick.BackColor = Color.CadetBlue;
            secondoClick.Image = cartaCliccata.Image;
         
            secondoClick.Padding = new Padding(10, 10, 10, 10);

            if (primoClick.Name == secondoClick.Name)
            {
                if (turno == 1)
                    punteggio1++;
                else
                    punteggio2++;               

                MessageBox.Show("Complimenti, hai trovato una coppia");
                primoClick.Enabled = false;
                secondoClick.Enabled = false;
                punti1Lbl.Text = $"Punteggio {utente1}: {punteggio1}";
                punti2Lbl.Text = $"Punteggio {utente2}: {punteggio2}";

                if (punteggio1 + punteggio2 == memory.Length / 2)
                    controlloVincitore(punteggio1, punteggio2, utente1, utente2);
                
                primoClick = null;
                secondoClick = null;
            }
            else
            {
                timer1.Start();
                if (turno == 1)
                {
                    turno++;
                }
                else
                {
                    turno--;
                }
            }

            if (turno == 1)
                turnoLbl.Text = $"É il turno di: {utente1}";
            else
                turnoLbl.Text = $"É il turno di: {utente2}";
        }

        public void controlloVincitore(int punti1, int punti2, string utente1, string utente2)
        {
            if (punti1 > punti2)
            {
                VincitoreLbl.Visible = true;
                VincitoreLbl.Text = $"Complimenti {utente1} hai vinto";
            }
            else if (punti1 < punti2)
            {
                VincitoreLbl.Visible = true;
                VincitoreLbl.Text = $"Complimenti {utente2} hai vinto";
            }
            else
            {
                VincitoreLbl.Visible = true;
                VincitoreLbl.Text = "Pareggio";
            }
            turnoLbl.Visible = false;
            partitaBtn.Visible = true;
            salvaPunteggi();
        }
    }
}
