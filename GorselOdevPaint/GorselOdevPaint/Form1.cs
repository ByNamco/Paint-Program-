using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GorselOdevPaint
{
    public partial class frmPaint : Form
    {
        int deger = 0;
        Point ilkNokta;
        Point sonNokta;
        bool down = false;
        Color secilirenk1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        Color secilirenk2 = SystemColors.Control, paintcolor;
        int kayıtkontrol=0;
        public frmPaint()
        {
            InitializeComponent();
        }

        void seciliDeger(int deger)
        {
            this.deger = deger;
        }

        void veriAyarla(ref int v1, int v2)
        {
            if (v1 > v2)
                v1 = v2;
        }

        private bool veriHesap(bool ctrl, out int x, out int y, out int genislik, out int yukseklik)
        {
            x = ilkNokta.X;
            y = ilkNokta.Y;
            genislik = Math.Abs(ilkNokta.X - sonNokta.X);
            yukseklik = Math.Abs(ilkNokta.Y - sonNokta.Y);
            if (x == sonNokta.X || y == sonNokta.Y)
                ctrl = true;
            veriAyarla(ref x, sonNokta.X);
            veriAyarla(ref y, sonNokta.Y);
            return ctrl;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.White;
        }
        private void btn17_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
        }
        private void btn46_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
        }
        private void btn22_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        }
        private void btn43_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        }
        private void btn40_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
        }
        private void btn36_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }
        private void btn20_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }
        private void btn24_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
        }
        private void btn44_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Silver;
        }
        private void btn21_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Yellow;
        }
        private void btn39_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Blue;
        }
        private void btn19_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }
        private void btn48_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
        }
        private void btn42_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        }
        private void btn27_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Lime;
        }
        private void btn16_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Black;
        }
        private void btn37_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        }
        private void btn26_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }
        private void btn23_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Olive;
        }
        private void btn30_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
        }
        private void btn34_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        }
        private void btn45_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Fuchsia;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Gray;
        }
        private void btn33_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Aqua;
        }
        private void btn13_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Red;
        }
        private void btn31_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }
        private void btn29_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Green;
        }
        private void btn14_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
        }
        private void btn41_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Navy;
        }
        private void btn12_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }
        private void btn11_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Maroon;
        }
        private void btn47_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Purple;
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }
        private void btn15_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        }
        private void btn28_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        }
        private void btn32_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }
        private void btn38_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
        }
        private void btn25_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }
        private void btn18_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }
        private void btn35_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = System.Drawing.Color.Teal;
        }

        private void pbResim_MouseMove(object sender, MouseEventArgs e)
        {
            int kalinlik = trbKalinlik.Value;
            txtXY.Text = Convert.ToString("X: " + e.X + ", Y: " + e.Y + " px");
            sonNokta = e.Location;
            Refresh();
            SolidBrush paintBrush = new SolidBrush(btnRenk.BackColor);
            Pen kalem;
            if (btnSilgi.Enabled == false)
                kalem = new Pen(Color.White, trbKalinlik.Value + 12);          
            else
                kalem = new Pen(btnRenk.BackColor, trbKalinlik.Value);
            Graphics g = Graphics.FromImage(pbResim.Image);

            switch (deger)
            {
                case 1:
                    if (down)
                    {
                        g.DrawLine(kalem, e.X, e.Y, ilkNokta.X, ilkNokta.Y);
                        ilkNokta.X = e.X; ilkNokta.Y = e.Y;
                    }
                    break;
                case 7: 
                     if (down)
                    {
                        g.FillEllipse(paintBrush, new Rectangle(e.Location.X - 3, e.Location.Y - 3, kalinlik+10,kalinlik+10));
                        Refresh();
                    }
                    break;
                default:
                    break;
            }
            g.Dispose();
        }

        private void pbResim_MouseDown(object sender, MouseEventArgs e)
        {
            down = true;
            ilkNokta = e.Location;
            switch (deger)
            {
                case 1:
                    {
                        ilkNokta.X = e.X;
                        ilkNokta.Y = e.Y;
                    }
                    break;  
            }
        }

        private void pbResim_MouseUp(object sender, MouseEventArgs e)
        {
            bool ctrl = false;
            int x;
            int y;
            int genislik;
            int yukseklik;
            ctrl = veriHesap(ctrl, out x, out y, out genislik, out yukseklik);
            down = false;
            Pen kalem = new Pen(btnRenk.BackColor, trbKalinlik.Value);
            Graphics g = Graphics.FromImage(pbResim.Image);
            SolidBrush paintBrush = new SolidBrush(btnRenk.BackColor);

            switch (deger)
            {
                case 2:
                    {
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta, sonNokta);
                        Refresh();
                    }
                    break;
                case 3:
                    {
                        if (ctrl)
                            break;
                        g.DrawRectangle(kalem, new Rectangle(x, y, genislik, yukseklik));
                        Refresh(); 
                    }
                    break;
                case 4: 
                    {
                        if (ctrl)
                            break;
                        g.FillRectangle(paintBrush, new Rectangle(x, y, genislik, yukseklik));
                        Refresh(); 
                    }
                    break;
                case 5: 
                    {
                        if (ctrl)
                            break;
                        g.DrawEllipse(kalem, new Rectangle(x, y, genislik, yukseklik));
                        Refresh(); 
                    }
                    break;
                case 6: 
                    {
                        if (ctrl)
                            break;
                        g.FillEllipse(paintBrush, new Rectangle(x, y, genislik, yukseklik));
                        Refresh(); 
                    }
                    break;
                case 8:
                    {
                        if (ctrl)
                            break;
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta, sonNokta);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, sonNokta.Y,sonNokta.X,sonNokta.Y);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, ilkNokta.Y, ilkNokta.X, sonNokta.Y);
                        Refresh();
                    }
                    break;
                case 9:
                    {
                        if (ctrl)
                            break;
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta, sonNokta);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), sonNokta.X-(sonNokta.X-ilkNokta.X)*2, sonNokta.Y, sonNokta.X, sonNokta.Y);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, ilkNokta.Y, sonNokta.X - (sonNokta.X - ilkNokta.X) * 2, sonNokta.Y);
                        Refresh();
                    }
                    break;
                case 10:
                    {
                        using (Font myFont = new Font(tsmFont.Text, Convert.ToInt16(tsmFontKalinlik.Text)))
                        {
                            g.DrawString(tsmMetinEkleText.Text, myFont, paintBrush, new Point(ilkNokta.X, ilkNokta.Y));
                        }
                    }
                    break;
                case 11:
                    {
                        if (ctrl)
                            break;
                        int ax,ay,bx,by,cx,cy;
                        cx = (ilkNokta.X + sonNokta.X) / 2;
                        cy= (ilkNokta.Y + sonNokta.Y) / 2;
                        bx = cx + (sonNokta.X - ilkNokta.X);
                        by = cy;
                        ax = cx - (sonNokta.X - ilkNokta.X);
                        ay = cy;
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, ilkNokta.Y, sonNokta.X, ilkNokta.Y);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, sonNokta.Y, sonNokta.X, sonNokta.Y);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), sonNokta.X, ilkNokta.Y, bx, by);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), bx, by, sonNokta.X, sonNokta.Y);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, ilkNokta.Y, ax, ay);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ax, ay, ilkNokta.X, sonNokta.Y);
                        Refresh();
                    }
                    break;
                case 13:
                    {
                        if (ctrl)
                            break;
                        g.DrawRectangle(kalem, new Rectangle(x, y, genislik, yukseklik));
                        g.DrawRectangle(kalem, new Rectangle(x + genislik/2, y +yukseklik/2, genislik, yukseklik));
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), x+genislik, y, x + genislik / 2+genislik, y + yukseklik / 2);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), x, y+yukseklik, x + genislik / 2, y + yukseklik / 2+yukseklik);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), x, y, x + genislik / 2, y + yukseklik / 2);
                        g.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), x+genislik, y+yukseklik, x + genislik / 2+genislik, y + yukseklik / 2+yukseklik);
                        Refresh();
                    }
                    break;
                default:
                    break;                   
            }
            g.Dispose();
        }

        private void pbResim_Paint(object sender, PaintEventArgs e)
        {
            bool ctrl = false;
            int x;
            int y;
            int genislik;
            int yukseklik;
            ctrl = veriHesap(ctrl, out x, out y, out genislik, out yukseklik);
            SolidBrush paintBrush = new SolidBrush(btnRenk.BackColor);
            Pen kalem = new Pen(btnRenk.BackColor, trbKalinlik.Value);

            switch (deger)
            {
                case 2:
                    {
                        if (!down)
                            break;
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta, sonNokta);                      
                    }
                    break;
                case 3:
                    {
                        if (!down)
                            break;
                        if (ctrl)
                            break;
                        e.Graphics.DrawRectangle(kalem, new Rectangle(x, y, genislik, yukseklik));
                    }
                    break;
                case 4: 
                    {
                        if (!down)
                            break;
                        if (ctrl)
                            break;
                        e.Graphics.FillRectangle(paintBrush, new Rectangle(x, y, genislik, yukseklik));
                    } break;
                case 5: 
                    {
                        if (!down)
                            break;
                        if (ctrl)
                            break;
                        e.Graphics.DrawEllipse(kalem, new Rectangle(x, y, genislik, yukseklik));
                    }
                    break;
                case 6: 
                    {
                        if (!down)
                            break;
                        if (ctrl)
                            break;
                        e.Graphics.FillEllipse(paintBrush, new Rectangle(x, y, genislik, yukseklik));
                    }
                    break;
                case 8:
                    {
                        if (!down)
                            break;
                        if (ctrl)
                            break;
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta, sonNokta);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, sonNokta.Y, sonNokta.X, sonNokta.Y);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, ilkNokta.Y, ilkNokta.X, sonNokta.Y);
                    }
                    break;
                case 9:
                    {
                        if (!down)
                            break;
                        if (ctrl)
                            break;
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta, sonNokta);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), sonNokta.X - (sonNokta.X - ilkNokta.X) * 2, sonNokta.Y, sonNokta.X, sonNokta.Y);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, ilkNokta.Y, sonNokta.X - (sonNokta.X - ilkNokta.X) * 2, sonNokta.Y);
                    }
                    break;
                case 11:
                    {
                        if (!down)
                            break;
                        if (ctrl)
                            break;
                        int ax, ay, bx, by, cx, cy;
                        cx = (ilkNokta.X + sonNokta.X) / 2;
                        cy = (ilkNokta.Y + sonNokta.Y) / 2;
                        bx = cx + (sonNokta.X - ilkNokta.X);
                        by = cy;
                        ax = cx - (sonNokta.X - ilkNokta.X);
                        ay = cy;
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, ilkNokta.Y, sonNokta.X, ilkNokta.Y);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, sonNokta.Y, sonNokta.X, sonNokta.Y);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), sonNokta.X, ilkNokta.Y, bx, by);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), bx, by, sonNokta.X, sonNokta.Y);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ilkNokta.X, ilkNokta.Y, ax, ay);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), ax, ay, ilkNokta.X, sonNokta.Y);
                    }
                    break;
                case 13:
                    {
                        if (!down)
                            break;
                        if (ctrl)
                            break;
                        e.Graphics.DrawRectangle(kalem, new Rectangle(x, y, genislik, yukseklik));
                        e.Graphics.DrawRectangle(kalem, new Rectangle(x + genislik / 2, y + yukseklik / 2, genislik, yukseklik));
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), x + genislik, y, x + genislik / 2 + genislik, y + yukseklik / 2);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), x, y + yukseklik, x + genislik / 2, y + yukseklik / 2 + yukseklik);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), x, y, x + genislik / 2, y + yukseklik / 2);
                        e.Graphics.DrawLine(new Pen(btnRenk.BackColor, trbKalinlik.Value), x + genislik, y + yukseklik, x + genislik / 2 + genislik, y + yukseklik / 2 + yukseklik);
                    }
                    break;
                default:
                    break;
            }
        }

        void butonRenkKontrol(int deger) {
            btnKalem.Enabled = true; btnKalem.BackColor = secilirenk2;
            btnCizgi.Enabled = true; btnCizgi.BackColor = secilirenk2;
            btnKare.Enabled = true; btnKare.BackColor = secilirenk2;
            btnDoluKare.Enabled = true; btnDoluKare.BackColor = secilirenk2;
            btnFirca.Enabled = true; btnFirca.BackColor = secilirenk2;
            btnRenkAl.Enabled = true; btnRenkAl.BackColor = secilirenk2;
            btnYuvarlak.Enabled = true; btnYuvarlak.BackColor = secilirenk2;
            btnDoluYuvarlak.Enabled = true; btnDoluYuvarlak.BackColor = secilirenk2;
            btnSilgi.Enabled = true; btnSilgi.BackColor = secilirenk2;
            btnDikUcgen.Enabled = true; btnDikUcgen.BackColor = secilirenk2;
            btnUcgen.Enabled = true; btnUcgen.BackColor = secilirenk2;
            btnDikPrizma.Enabled = true; btnDikPrizma.BackColor = secilirenk2;
            btnAltigen.Enabled = true; btnAltigen.BackColor = secilirenk2;

            switch (deger)
            {
                case 1:
                    { btnKalem.Enabled = false; btnKalem.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 2:
                    { btnCizgi.Enabled = false; btnCizgi.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 3:
                    { btnKare.Enabled = false; btnKare.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 4:
                    { btnDoluKare.Enabled = false; btnDoluKare.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 5:
                    { btnFirca.Enabled = false; btnFirca.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 6:
                    { btnRenkAl.Enabled = false; btnRenkAl.BackColor = secilirenk1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 7:
                    { btnYuvarlak.Enabled = false; btnYuvarlak.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 8:
                    { btnDoluYuvarlak.Enabled = false; btnDoluYuvarlak.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 9:
                    { btnSilgi.Enabled = false; btnSilgi.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = false;
                    }
                    break;
                case 10:
                    { btnDikUcgen.Enabled = false; btnDikUcgen.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 11:
                    { btnUcgen.Enabled = false; btnUcgen.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 12:
                    { btnDikPrizma.Enabled = false; btnDikPrizma.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                case 13:
                    { btnAltigen.Enabled = false; btnAltigen.BackColor = secilirenk1;
                    kayıtkontrol = 1;
                    gbRenk.Enabled = true;
                    }
                    break;
                default:
                    break;           
            }
        }

        void temizleYeni()
        {
            seciliDeger(0);
            btnEn.Left = 1352;
            btnBoy.Top = 687;
            pbResim.Cursor = Cursors.Default;
            tsmMetinEkleText.Text = "Metni Buraya Yazıp Ekranda Metni Eklemek İstediğiniz Yere Tıklayın...";
            Bitmap bmp = new Bitmap(1245, 620);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
            pbResim.Image = bmp;
            g.Dispose();         
            tsmKaydet.Enabled = false;
            tsmKayıt.Enabled = false;
            gbRenk.Enabled = true;
            trbKalinlik.Value = 1;
            pbResim.Width = 1245;
            pbResim.Height = 620;
            btnEn.Location = new Point(107 + pbResim.Width, pbResim.Height / 2 + 67);
            btnBoy.Location = new Point(107 + pbResim.Width / 2, 67 + pbResim.Height);
            butonRenkKontrol(0);
            txtBoyut.Text = "   " + pbResim.Width + " x " + pbResim.Height + "px";
            kayıtkontrol = 0;
            btnRenk.BackColor = Color.Black;
            tsmFontKalinlik.Text = "20";
            tsmFont.Text = "Arial";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizleYeni();
        }

        private void tsmYeni_Click(object sender, EventArgs e)
        {
            if (tsmKaydet.Enabled == false)
            {
            }
            else
            {
                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show("Dosyanızda Yapılan Değişiklikleri Kaydetmek İster misiniz?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cikis == DialogResult.Yes)
                {
                    kaydet();
                }
                else if (cikis == DialogResult.No)
                {
                }
            }
            temizleYeni();
        }

        private void btnSilgi_Click(object sender, EventArgs e)
        {
            try{
            Cursor myCursor = new Cursor("cursor (5).cur");
            pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(1);           
            butonRenkKontrol(9);
        }

        private void btnRTAblo(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            btnRenk.BackColor = dlg.Color;
        }

        private void btnKalem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor myCursor = new Cursor("cursor_pencil.cur");
                pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(1);            
            butonRenkKontrol(1);
        }

        private void btnYuvarlak_Click(object sender, EventArgs e)
        {
            try{
            Cursor myCursor = new Cursor("ellipse-pro.cur");
            pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(5);
            butonRenkKontrol(7);
        }

        private void btnDoluYuvarlak_Click(object sender, EventArgs e)
        {
            try{
            Cursor myCursor = new Cursor("ellipse-pro.cur");
            pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(6);
            butonRenkKontrol(8);
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            try{
            Cursor myCursor = new Cursor("rect-pro.cur");
            pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(3);
            butonRenkKontrol(3);       
        }

        private void btnDoluKare_Click(object sender, EventArgs e)
        {
            try{
            Cursor myCursor = new Cursor("rect-pro.cur");
            pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(4);
            butonRenkKontrol(4);
        }

        private void btnFirca_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor myCursor = new Cursor("cursor (9).cur");
                pbResim.Cursor = myCursor;           
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(7);
            butonRenkKontrol(5);
        }

        private void btnRenkAl_Click(object sender, EventArgs e)
        {try{
            Cursor myCursor = new Cursor("color-pro.cur");
            pbResim.Cursor = myCursor;
        }
        catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(0);
            butonRenkKontrol(6);
        }

        private void btnCizgi_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor myCursor = new Cursor("cross.cur");
                pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(2);
            butonRenkKontrol(2);
        }

        private void btnDikUcgen_Click(object sender, EventArgs e)
        {
            try{
            Cursor myCursor = new Cursor("cross.cur");
            pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(8);
            butonRenkKontrol(10);
        }

        private void btnUcgen_Click_1(object sender, EventArgs e)
        {
            try{
            Cursor myCursor = new Cursor("cross.cur");
            pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(9);
            butonRenkKontrol(11);
        }

        private void btnDikPrizma_Click(object sender, EventArgs e)
        {
            try{
            Cursor myCursor = new Cursor("cross.cur");
            pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(13);
            butonRenkKontrol(12);
        }

        private void btnAltigen_Click(object sender, EventArgs e)
        {
            try{
            Cursor myCursor = new Cursor("cross.cur");
            pbResim.Cursor = myCursor;
            }
            catch { pbResim.Cursor = Cursors.Default; }
            seciliDeger(11);
            butonRenkKontrol(13);
        }
        

        private void tsmMetinEkleText_TextChanged(object sender, EventArgs e)
        {
            pbResim.Cursor = Cursors.Default;
            seciliDeger(10);
            butonRenkKontrol(0);
            kayıtkontrol = 1;
        }

        private void tsmMetinEkleText_Click(object sender, EventArgs e)
        {
            if (tsmMetinEkleText.Text == "Metni Buraya Yazıp Ekranda Metni Eklemek İstediğiniz Yere Tıklayın...")
                tsmMetinEkleText.Text = "";
            pbResim.Cursor = Cursors.Default;
            seciliDeger(10);
            gbRenk.Enabled = true;
            butonRenkKontrol(0);
            kayıtkontrol = 1;

        }
        void kaydet() 
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";
            sfd.Title = "Kayıt";
            sfd.FileName = "resim";
            DialogResult sonuç = sfd.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                pbResim.Image.Save(sfd.FileName);
            }
        }

        private void tsmKaydet_Click(object sender, EventArgs e)
        {
            tsmKaydet.Enabled = false;
            tsmKayıt.Enabled = false;
            kaydet();
           
        }

        private void tsmResimYukle_Click(object sender, EventArgs e)
        {
            pbResim.Cursor = Cursors.Default;
            tsmKaydet.Enabled = true;
            tsmKayıt.Enabled = true;
            seciliDeger(0);
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(ofd.FileName);
                    Bitmap newBmp = new Bitmap(pbResim.Width, pbResim.Height);
                    Graphics g = Graphics.FromImage(newBmp);
                    g.DrawImage(bmp, new Rectangle(0, 0, newBmp.Width, newBmp.Height));
                    g.Dispose();
                    bmp.Dispose();
                    pbResim.Image = newBmp;
                }
            }
        }

        private void frmPaint_Load(object sender, EventArgs e)
        {

            txtBoyut.Text ="   " + pbResim.Width + " x " + pbResim.Height + "px";
            Bitmap bmp = new Bitmap(pbResim.Width, pbResim.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
            g.Dispose();
            pbResim.Image = bmp;
        }

        private void frmPaint_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tsmKaydet.Enabled==false)
            {
            }
           else
            {
                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show("Dosyanızda Yapılan Değişiklikleri Kaydetmek İster misiniz?", "Emin Misiniz?", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (cikis == DialogResult.No)
                {
                }
                else if (cikis == DialogResult.Yes)
                {
                    kaydet();
                }
                else if (cikis == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }           
        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            bool ctrl = false;
            int x;
            int y;
            int genislik;
            int yukseklik;
            ctrl = veriHesap(ctrl, out x, out y, out genislik, out yukseklik);
            if (kayıtkontrol == 1)
            {
                tsmKaydet.Enabled = true;
                tsmKayıt.Enabled = true;
            }
            if (btnRenkAl.Enabled == false)
            {
                Bitmap bmap = new Bitmap(pbResim.Image);
                paintcolor = bmap.GetPixel(x, y);
                btnRenk.BackColor = paintcolor;
            }
        }

        bool suruklenmedurumu = false;
        Point ilkkonum;

        private void btnEn_MouseUp(object sender, MouseEventArgs e)
        {
            label5.Visible = false;
            suruklenmedurumu = false;
            int x = pbResim.Width;
            pbResim.Width = btnEn.Left - 107;
            Bitmap bmp = new Bitmap(pbResim.Width, pbResim.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImageUnscaled(pbResim.Image, new Rectangle(0, 0, bmp.Width, bmp.Height));
            g.FillRectangle(new SolidBrush(Color.White), x, 0, bmp.Width, bmp.Height);
            g.Dispose();
            pbResim.Image = bmp;
            txtBoyut.Text = "   " + pbResim.Width + " x " + pbResim.Height + "px";
            btnBoy.Location = new Point(107 + pbResim.Width / 2, 67 + pbResim.Height);
        } 
      
        private void btnEn_MouseDown(object sender, MouseEventArgs e)
        {
            ilkkonum = e.Location;
            suruklenmedurumu = true;
            label5.Visible = true;
            label5.Size = new System.Drawing.Size(1, pbResim.Height);
            tsmKaydet.Enabled = true;
            tsmKayıt.Enabled = true;
            kayıtkontrol = 1;
        }   
 
        private void btnEn_MouseMove(object sender, MouseEventArgs e)
        {           
            if (btnEn.Left > 1352) { btnEn.Left = 1352; suruklenmedurumu = false; }
            else if (btnEn.Left < 257) { btnEn.Left = 257; suruklenmedurumu = false; }
            else
            {
                if (suruklenmedurumu)
                {
                    btnEn.Left = e.X + btnEn.Left - (ilkkonum.X);
                    label5.Left = e.X + btnEn.Left - (ilkkonum.X);
                    txtBoyut.Text = "   " + (btnEn.Left - 107) + " x " + pbResim.Height + "px";
                }
            }
        } 
      
        private void btnBoy_MouseUp(object sender, MouseEventArgs e)
        {
            label6.Visible = false;
            suruklenmedurumu = false;
            int y = pbResim.Height;
            pbResim.Height = btnBoy.Top - 67;
            Bitmap bmp = new Bitmap(pbResim.Width, pbResim.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImageUnscaled(pbResim.Image, new Rectangle(0, 0, bmp.Width, bmp.Height));
            g.FillRectangle(new SolidBrush(Color.White), 0, y, bmp.Width, bmp.Height);
            g.Dispose();
            pbResim.Image = bmp;
            txtBoyut.Text = "   " + pbResim.Width + " x " + pbResim.Height + "px";
            btnEn.Location = new Point(107 + pbResim.Width, pbResim.Height / 2 + 67);
        }   
    
        private void btnBoy_MouseDown(object sender, MouseEventArgs e)
        {
            ilkkonum = e.Location;
            suruklenmedurumu = true;
            label6.Visible = true;
            label6.Size = new System.Drawing.Size(pbResim.Width, 1);
            tsmKaydet.Enabled = true;
            tsmKayıt.Enabled = true;
            kayıtkontrol = 1;
            
        }   
    
        private void btnBoy_MouseMove(object sender, MouseEventArgs e)
        {
            int ey = e.Y;
            if (btnBoy.Top > 687) { btnBoy.Top = 687; suruklenmedurumu = false; }
            else if (btnBoy.Top < 217) { btnBoy.Top = 217; suruklenmedurumu = false; }
            else
            {
                if (suruklenmedurumu)
                {
                    btnBoy.Top = e.Y + btnBoy.Top - (ilkkonum.Y);
                    label6.Top = e.Y + btnBoy.Top - (ilkkonum.Y);
                    txtBoyut.Text = "   " + pbResim.Width + " x " + (btnBoy.Top - 67) + "px";
                }
            }
        }

        private void frmPaint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                tsmYeni.PerformClick();

            }
            if (e.Control == true && e.KeyCode == Keys.O)
            {
                tsmAc.PerformClick();

            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                tsmKayıt.PerformClick();
            }
        }
    }
}
