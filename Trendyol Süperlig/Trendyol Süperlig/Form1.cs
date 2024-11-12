using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trendyol_Süperlig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        Random rast = new Random();
        int fbPuan = 0;
        int gsPuan = 0;
        int tsPuan = 0;
        int bjkPuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int fb, gs, ts, bjk;
            fb = rast.Next(0, 6);
            gs = rast.Next(0, 6);
            ts = rast.Next(0, 6);
            bjk = rast.Next(0, 6);
            label2.Text = fb.ToString();
            label4.Text = gs.ToString();
            label7.Text = ts.ToString();
            label9.Text = bjk.ToString();
            button1.Enabled = false;
            if (fb > gs) 
            {
                fbPuan = fbPuan + 3;
            }
            else if (fb == gs) 
            {
                fbPuan = fbPuan + 1;
                gsPuan = gsPuan + 1;
            }
            else if (fb < gs) 
            {
                gsPuan = gsPuan + 3;
            }
            if (bjk > ts)
            {
                bjkPuan = bjkPuan + 3;
            }
            else if (bjk == ts) 
            {
                bjkPuan = bjkPuan + 1;
                tsPuan = tsPuan + 1;
            }
            else if (bjk < ts) 
            {
                tsPuan = tsPuan + 3;
            }
            label31.Text = fbPuan.ToString();
            label34.Text = gsPuan.ToString();
            label35.Text = bjkPuan.ToString();
            label38.Text = tsPuan.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fb, gs, ts, bjk;
            fb = rast.Next(0, 6);
            gs = rast.Next(0, 6);
            ts = rast.Next(0, 6);
            bjk = rast.Next(0, 6);
            label19.Text = fb.ToString();
            label17.Text = gs.ToString();
            label12.Text = ts.ToString();
            label14.Text = bjk.ToString();
            button2.Enabled = false;
            if (fb > bjk)
            {
                fbPuan = fbPuan + 3;
            }
            else if (fb == bjk)
            {
                fbPuan = fbPuan + 1;
                bjkPuan = bjkPuan + 1;
            }
            else if (fb < bjk)
            {
                bjkPuan = bjkPuan + 3;
            }
            if (gs > ts)
            {
                gsPuan = gsPuan + 3;
            }
            else if (gs == ts)
            {
                gsPuan = gsPuan + 1;
                tsPuan = tsPuan + 1;
            }
            else if (gs < ts)
            {
                tsPuan = tsPuan + 3;
            }
            label31.Text = fbPuan.ToString();
            label34.Text = gsPuan.ToString();
            label35.Text = bjkPuan.ToString();
            label38.Text = tsPuan.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fb, gs, ts, bjk;
            fb = rast.Next(0, 6);
            gs = rast.Next(0, 6);
            ts = rast.Next(0, 6);
            bjk = rast.Next(0, 6);
            label29.Text = fb.ToString();
            label27.Text = gs.ToString();
            label22.Text = ts.ToString();
            label24.Text = bjk.ToString();
            button3.Enabled = false;
            if (fb > ts)
            {
                fbPuan = fbPuan + 3;
            }
            else if (fb == ts)
            {
                fbPuan = fbPuan + 1;
                tsPuan = tsPuan + 1;
            }
            else if (fb < ts)
            {
                tsPuan = tsPuan + 3;
            }
            if (gs > bjk)
            {
                gsPuan = gsPuan + 3;
            }
            else if (gs == bjk)
            {
                gsPuan = gsPuan + 1;
                bjkPuan = bjkPuan + 1;
            }
            else if (gs < bjk)
            {
                bjkPuan = bjkPuan + 3;
            }
            label31.Text = fbPuan.ToString();
            label34.Text = gsPuan.ToString();
            label35.Text = bjkPuan.ToString();
            label38.Text = tsPuan.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fbPuan > gsPuan && fbPuan > bjkPuan && fbPuan > tsPuan) 
            {
                pictureBox1.Image=Image.FromFile("C:/Users/user/Desktop/10-M/Trendyol Süperlig/Fener.jpg");
                label40.Text = ("Fenerbahçe");
            }
            if (gsPuan > fbPuan && gsPuan > bjkPuan && gsPuan > tsPuan)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/Trendyol Süperlig/gs.png");
                label40.Text = ("Galatasaray");
            }
            if (bjkPuan > fbPuan && bjkPuan > gsPuan && bjkPuan > tsPuan)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/Trendyol Süperlig/bjk.png");
                label40.Text = ("Beşiktaş");
            }
            if (tsPuan > fbPuan && tsPuan > bjkPuan && tsPuan > gsPuan)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/user/Desktop/10-M/Trendyol Süperlig/ts.png");
                label40.Text = ("Trabzonspor");
            }
        }
    }
}
