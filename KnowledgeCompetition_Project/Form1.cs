using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeCompetition_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnDigerSoru.Enabled = true;

            lblVerilenCevap.Text = btnB.Text;
            if (lblDogruCevap.Text == lblVerilenCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnDigerSoru.Enabled = true;

            lblVerilenCevap.Text = btnC.Text;
            if (lblDogruCevap.Text == lblVerilenCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnDigerSoru.Enabled = true;

            lblVerilenCevap.Text = btnD.Text;
            if (lblDogruCevap.Text == lblVerilenCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnDigerSoru.Enabled = true;


            lblVerilenCevap.Text = btnA.Text;
            if (lblVerilenCevap == lblDogruCevap)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                
            }
        }

        private void btnDigerSoru_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnDigerSoru.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            lblSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "1 Metre kaç milimetredir?";
                btnA.Text = "A:100";
                btnB.Text = "B:1000";
                btnC.Text = "C:10.000";
                btnD.Text = "D:10";
                lblDogruCevap.Text = "B:1000";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Bir elektrik devresinde direnç hangi harfle gösterilir?";
                btnA.Text = "A:A";
                btnB.Text = "B:D";
                btnC.Text = "C:R";
                btnD.Text = "D:K";
                lblDogruCevap.Text = "C:R";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Osmanlı'da Lale Devri hangi padişah döneminde yaşanmıştır?";
                btnA.Text = "A:III.Ahmet";
                btnB.Text = "B:IV.Murat";
                btnC.Text = "C:III.Selim";
                btnD.Text = "D:IV.Osman";
                lblDogruCevap.Text = "A:III.Ahmet";
          
            }
            if(soruno == 4)
            {
                richTextBox1.Text = "Magna Carta hangi ülkenin kralıyla yapılmış bir sözleşmedir?";
                btnA.Text = "A:Fransa";
                btnB.Text = "B:İspanya";
                btnC.Text = "C:İngiltere";
                btnD.Text = "D:Rusya";
                lblDogruCevap.Text = "C:İngiltere";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Kıbrıs Barış Harekatı hangi tarihte gerçekleşmiştir?";
                btnA.Text = "A:1970";
                btnB.Text = "B:1972";
                btnC.Text = "C:1974";
                btnD.Text = "D:1976";
                lblDogruCevap.Text = "C:1974";
                btnDigerSoru.Text = "Sonuçlar";
            }
            if (soruno == 6)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnDigerSoru.Enabled = false;
                MessageBox.Show("Doğru:" + dogru + "\n" + "Yanlış:" + yanlis);
                   
            }


        }
    }
}
