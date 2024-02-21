using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Yarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kazanilanPuan = 0;
        int yolHizi = 10;
        int arabaHizi = 10;

        bool solYon = false;
        bool sagYon = false;

        int digerArabaHizi = 10;

        Random rnd = new Random();



        public void oyunBaslat()
        {
            buttonOyunuBaslat.Enabled = false;
            carpma.Visible = false;

            arabaHizi = 10;
            digerArabaHizi = 10;
            kazanilanPuan = 0;

            BizimAraba.Left = 160;
            BizimAraba.Top = 300;

            // Araba1'in rastgele başlangıç konumu
            Araba1.Left = rnd.Next(20, panel1.Width - Araba1.Width);
            Araba1.Top = rnd.Next(-200, -100);

            // Araba2'nin rastgele başlangıç konumu, Araba1'den en az 50 birim uzaklıkta olacak şekilde belirlenir
            do
            {
                Araba2.Left = rnd.Next(20, panel1.Width - Araba2.Width);
                Araba2.Top = rnd.Next(-200, -100) + 50; // Araba1'den 50 birim uzaklıkta olması için 50 eklenir
            } while (Math.Abs(Araba2.Left - Araba1.Left) < 50 && Math.Abs(Araba2.Top - Araba1.Top) < 50);

            solYon = false;
            sagYon = false;

            carpma.Left = 165;
            carpma.Top = 294;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kazanilanPuan++;
            labelPuan.Text = kazanilanPuan.ToString();

            Yol.Top += yolHizi;
            if (Yol.Top > 400)
            {
                Yol.Top = -100;
            }

            if (solYon) { BizimAraba.Left -= arabaHizi; }
            if (sagYon) { BizimAraba.Left += arabaHizi; }

            if (BizimAraba.Left < 1) { solYon = false; }
            else if (BizimAraba.Left + BizimAraba.Width > 510) { sagYon = false; }


            Araba1.Top += arabaHizi;
            Araba2.Top += arabaHizi;

            if (Araba1.Top > panel1.Height)
            {
                Araba1Degistir();
                // Araba1'in rastgele başlangıç konumu, Araba2'den en az 20 birim uzaklıkta olacak şekilde belirlenir
                do
                {
                    Araba1.Left = rnd.Next(20, panel1.Width - Araba1.Width);
                    Araba1.Top = rnd.Next(70, 140) * -1;
                } while (Math.Abs(Araba1.Left - Araba2.Left) < 20 && Math.Abs(Araba1.Top - Araba2.Top) < 20);
            }

            if (Araba2.Top > panel1.Height)
            {
                Araba2Degistir();
                // Araba2'nin rastgele başlangıç konumu, Araba1'den en az 20 birim uzaklıkta olacak şekilde belirlenir
                do
                {
                    Araba2.Left = rnd.Next(20, panel1.Width - Araba2.Width);
                    Araba2.Top = rnd.Next(50, 180) * -1;
                } while (Math.Abs(Araba2.Left - Araba1.Left) < 20 && Math.Abs(Araba2.Top - Araba1.Top) < 20);
            }


            if (BizimAraba.Bounds.IntersectsWith(Araba1.Bounds) || BizimAraba.Bounds.IntersectsWith(Araba2.Bounds))
            {
                oyunBitti();
            }


        }


        private void Araba1Degistir()
        {
            int sira = rnd.Next(1, 7);

            switch (sira)
            {
                case 1:
                    Araba1.Image = Properties.Resources.araba5;
                    break;
                case 2:
                    Araba1.Image = Properties.Resources.araba7;
                    break;
                case 3:
                    Araba1.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    Araba1.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    Araba1.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    Araba1.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    Araba1.Image = Properties.Resources.araba7;
                    break;


            }
        }

        private void Araba2Degistir()
        {
            int sira = rnd.Next(1, 7);

            switch (sira)
            {
                case 1:
                    Araba2.Image = Properties.Resources.araba5;
                    break;
                case 2:
                    Araba2.Image = Properties.Resources.araba7;
                    break;
                case 3:
                    Araba2.Image = Properties.Resources.araba3;
                    break;
                case 4:
                    Araba2.Image = Properties.Resources.araba4;
                    break;
                case 5:
                    Araba2.Image = Properties.Resources.araba5;
                    break;
                case 6:
                    Araba2.Image = Properties.Resources.araba6;
                    break;
                case 7:
                    Araba2.Image = Properties.Resources.araba7;
                    break;

            }
        }

        private void oyunBitti()
        {
            timer1.Stop();
            buttonOyunuBaslat.Enabled = true;
            carpma.Visible = true;
            BizimAraba.Controls.Add(carpma);
            carpma.Location = new Point(7, -5);
            carpma.BringToFront();
            carpma.BackColor = Color.Transparent;
            MessageBox.Show("tebrikler kazandığınız puan: " + labelPuan.Text, "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Yol_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunBaslat();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && BizimAraba.Left>0 )
            {
                solYon=true;
            }


            if(e.KeyCode == Keys.Right && BizimAraba.Left + BizimAraba.Width < panel1.Width)
            {
                sagYon=true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solYon=false;
            }
            if(e.KeyCode == Keys.Right)
            {
                sagYon=false;
            }
        }
    }
}