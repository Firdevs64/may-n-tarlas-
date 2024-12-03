using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList mayinlar = new ArrayList();


        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            gPuan = 0;
            int oMayin = 100;  //Kaç tane mayın oluşturduğunu yazdırıyor.
            int oTarla = 900;
            tableLayoutPanel1.ColumnCount = 30;
            label2.Text = "Mayın : " + oMayin;
            label3.Text = "Boyut : " + tableLayoutPanel1.ColumnCount + " x " + tableLayoutPanel1.ColumnCount;
            Random rast = new Random();
            int sayi = 0;
            for(int i = 0; i < oMayin; i++)
            {
                uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }
            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(26, 26);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 4);
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
            


        }
        int gPuan = 0;
        private void button_Click(object sender, EventArgs e)
        {
            
            Button tiklanan = (Button)sender;
            if (tiklanan.Text == "")
            {
                if (int.Parse(tiklanan.Tag.ToString()) == -1)
                {
                    tiklanan.BackgroundImage = Image.FromFile("mayin.png");
                    tiklanan.BackColor = Color.Red;

                    for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                    {
                        if (int.Parse(tableLayoutPanel1.Controls[i].Tag.ToString()) == -1)
                        {
                            tableLayoutPanel1.Controls[i].BackgroundImage = Image.FromFile("mayin.png");
                            tableLayoutPanel1.Controls[i].Enabled = false;
                        }
                        else
                        {
                            tableLayoutPanel1.Controls[i].Enabled = false;
                            tableLayoutPanel1.Controls[i].Text = tableLayoutPanel1.Controls[i].Tag.ToString();
                        }
                    }
                }
                else
                {
                    tiklanan.Text = tiklanan.Tag.ToString();
                    gPuan += int.Parse(tiklanan.Tag.ToString());
                    label1.Text = "Puan: " + gPuan;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            gPuan = 0;
            int oMayin = 200;  //Kaç tane mayın oluşturduğunu yazdırıyor.
            int oTarla = 900;
            tableLayoutPanel1.ColumnCount = 30;
            label2.Text = "Mayın : " + oMayin;
            label3.Text = "Boyut : " + tableLayoutPanel1.ColumnCount + " x " + tableLayoutPanel1.ColumnCount;
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < oMayin; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }
            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(30, 30);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 4);
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);

            }
            
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinlar.Clear();
            tableLayoutPanel1.Controls.Clear();
            gPuan = 0;
            int oMayin = 300;  //Kaç tane mayın oluşturduğunu yazdırıyor.
            int oTarla = 900;
            tableLayoutPanel1.ColumnCount = 30;
            label2.Text = "Mayın : " + oMayin;
            label3.Text = "Boyut : " + tableLayoutPanel1.ColumnCount + " x " + tableLayoutPanel1.ColumnCount;
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < oMayin; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinlar.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinlar.Add(sayi);
                }
            }
            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(30, 30);
                if (mayinlar.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 4);
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);

            }
            
        }
    }
}
