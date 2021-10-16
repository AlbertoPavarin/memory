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
            for (int i = 0; i < memory.Length; i++) // Viene iterato ogni elemento nell'array
            {
                int nCarta = random.Next(0, 4);
                if (controlloNCarte(nCarta) > 2) // Se sono presenti già due carte dello stesso tipo viene mandato indietro di un ciclo rifacendo l'estrazione della carta 
                {
                    i--;
                }
                else
                {
                    memory[i] = new PictureBox(); // Viene creata una picturebox per ogni elemento dell'array
                    memory[i].Name = nomeCarta(nCarta); // Viene dato un nome alla picturebox grazie alla funzione nomeCarta, la quale assegna un nome ad ogni carta in corrispondenza del numero generato 
                    memory[i].Size = new Size(100, 100);
                    memory[i].Location = new Point(xImg, yImg);
                    memory[i].Image = assegnazioneCarta(nCarta); // Viene assegnata un'immagine grazie alla funzione assegnazioneCarta, la quale assegna un'immagine in corrispondenza del numero generato
                    memory[i].BackColor = Color.LightBlue;
                    memory[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    memory[i].Padding = new Padding(100, 0, 0, 0);
                    memory[i].BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(memory[i]);
                    memory[i].Click += new EventHandler(clickCarta); // Ad ogni click viene triggerato l'evento clickCarta
     
                    xImg += memory[i].Width + 10;

                    if (xImg >= 440)
                    {
                        yImg += 120;
                        xImg = 100;
                    }
                }                
            }
        }

        public Image assegnazioneCarta(int nCarta) // Funzione per assegnare ad ogni pictureBox un'immagine a seconda del numero random generato
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

            // Vengono resettate la prima e la seconda carta cliccata
            primoClick.Padding = new Padding(100, 0, 0, 0);
            secondoClick.Padding = new Padding(100, 0, 0, 0);
            primoClick.BackColor = Color.LightBlue;
            secondoClick.BackColor = Color.LightBlue;

            // Le due carte cliccate vengono riabilitate
            primoClick.Enabled = true;
            secondoClick.Enabled = true;
            // Le variabili che salvano i due click vengono impostate a null, cioè a niente
            primoClick = null;
            secondoClick = null;
        }

        public void salvaPunteggi() // Funzione per salvare la partita
        {
            StreamWriter punteggi = new StreamWriter(percorso);           
            punteggi.WriteLine($"L'ultima partita tra {utente1} e {utente2} si è concluso con il punteggio:\n{punteggio1} - {punteggio2}\n");
            punteggi.Close();
        }

        private void storicoBtn_Click(object sender, EventArgs e) // Viene mostrata l'ultima partita nel momento in cui si clicka sul pulsante "ultima partita"
        {
            storicoLbl.Visible = true;           
            StreamReader leggiStorico = new StreamReader(percorso);
            storicoLbl.Text = leggiStorico.ReadToEnd();
        }

        private void giocaBtn_Click(object sender, EventArgs e)
        {
            if (utente1Txt.Text != "" && utente2Txt.Text != "") // La partita incomincia solo se le due textBox per i nomi dei giocatori non sono vuote
            {
                nChitarra = 0;
                nAmp = 0;
                nMetronomo = 0;
                nBatteria = 0;
                punteggio1 = 0;
                punteggio2 = 0;
                xImg = 100;
                yImg = 110;
                turno = 0;
                turnoLbl.Text = "É il turno di: ";


                VincitoreLbl.Visible = false;
                storicoLbl.Visible = false;
                partitaBtn.Visible = false;
                turnoLbl.Visible = true;

                // Viene salvata nella variabile utente1 il contenuto della textBox utente1Txt
                utente1 = utente1Txt.Text;

                // Viene salvata nella variabile utente2 il contenuto della textBox utente2Txt
                utente2 = utente2Txt.Text;
                utente1Txt.Visible = false;
                utente2Txt.Visible = false;
                giocaBtn.Visible = false;
                label1.Visible = false;
                label2.Visible = false;

                // Vengono mostrati i punteggi dei due giocatori
                punti1Lbl.Text = $"Punteggio {utente1}: {punteggio1}";
                punti2Lbl.Text = $"Punteggio {utente2}: {punteggio2}";
                punti1Lbl.Visible = true;
                punti2Lbl.Visible = true;

                turno = turnoRnd.Next(1, 3);

                // Viene segnato di chi è il turno, se del giocatore 1 o 2
                if (turno == 1)
                    turnoLbl.Text += $"{utente1}";
                else
                    turnoLbl.Text += $"{utente2}";

                // Vengono create le immagini
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

            PictureBox cartaCliccata = sender as PictureBox; // Viene salvata la carta cliccata 

            if (cartaCliccata == null)
            {
                return;
            }
            
            if (primoClick == null) // Se il primo click non corrisponde a niente allora viene salvato il primo click
            {
                primoClick = cartaCliccata;
                primoClick.BackColor = Color.CadetBlue;
                primoClick.Enabled = false;
                primoClick.Image = cartaCliccata.Image;
                primoClick.Padding = new Padding(10, 10, 10, 10);
                return;
            }

            secondoClick = cartaCliccata; // Viene salvato il primo click
            secondoClick.BackColor = Color.CadetBlue;
            secondoClick.Image = cartaCliccata.Image;       
            secondoClick.Padding = new Padding(10, 10, 10, 10);

            if (primoClick.Name == secondoClick.Name) 
            {
                // Se le carte sono uguali viene assegnato il punteggio a seconda del turno, quindi se il turno era uguale a 1 viene incrementato di uno il punteggio del giocatore1 altrimenti del secondo
                if (turno == 1) 
                    punteggio1++;
                else
                    punteggio2++;               
                    
                primoClick.Enabled = false;
                secondoClick.Enabled = false;
                punti1Lbl.Text = $"Punteggio {utente1}: {punteggio1}";
                punti2Lbl.Text = $"Punteggio {utente2}: {punteggio2}";
                MessageBox.Show("Complimenti, hai trovato una coppia");

                if (punteggio1 + punteggio2 == memory.Length / 2) // Nel momento in cui tutte le coppie sono state trovate viene controllato chi è il giocatore vincitore
                {
                    controlloVincitore(punteggio1, punteggio2, utente1, utente2);
                    for (int i = 0; i < memory.Length; i++)
                    {
                        this.Controls.Remove(memory[i]);
                    }
                }
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
            giocaBtn.Visible = true;
        }
    }
}
