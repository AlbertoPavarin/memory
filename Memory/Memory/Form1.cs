using System;
using System.Drawing;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {

        int nChitarra, nAmp, nBatteria, nMetronomo = 0;

        int punteggio = 0;

        PictureBox primoClick, secondoClick;

        PictureBox[] memory = new PictureBox[8];

        int xImg = 100;
        int yImg = 110;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            
            creazioneImg();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                    memory[i].BackColor = Color.Black;
                    memory[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    memory[i].Padding = new Padding(5, 5, 5, 5);
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

            primoClick.BackColor = Color.Black;
            secondoClick.BackColor = Color.Black;

            primoClick = null;
            secondoClick = null;

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
                primoClick.BackColor = Color.Transparent;
                primoClick.Image = cartaCliccata.Image;
                return;
            }

            secondoClick = cartaCliccata;
            secondoClick.BackColor = Color.Transparent;
            secondoClick.Image = cartaCliccata.Image;                

            if (primoClick.Name == secondoClick.Name)
            { 
                punteggio++;
                controlloVincitore(punteggio);
                PunteggioLbl.Text = "Punteggio:" + punteggio;
                primoClick = null;
                secondoClick = null;
            }
            else
                timer1.Start();

        }

        public void controlloVincitore(int punti)
        {
            if (punteggio == memory.Length / 2)
            {
                VincitoreLbl.Visible = true;
                VincitoreLbl.Text = "Complimenti hai vinto";
            }
        }
    }
}
