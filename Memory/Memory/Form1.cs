﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {

        int nChitarra, nAmp, nBatteria, nMetronomo = 0;

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
                memory[i] = new PictureBox();
                memory[i].Size = new Size(100, 100);
                memory[i].Location = new Point(xImg, yImg);
                memory[i].Image = assegnazioneCarta(nCarta);
                memory[i].SizeMode = PictureBoxSizeMode.StretchImage;
                memory[i].Padding = new Padding(5, 5, 5, 5);
                memory[i].BorderStyle = BorderStyle.FixedSingle;
                if (controlloNCarte(nCarta) > 2)
                {
                    this.Controls.Remove(memory[i]);
                    i--;
                }
                this.Controls.Add(memory[i]);

                xImg += memory[i].Width + 10;

                if (xImg >= 440)
                {
                    yImg += 120;
                    xImg = 100;
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
    }
}
