using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Airfoil
{
    public partial class Form1 : Form
    {

      public bool gotPoints = false;
       public bool lEdge = false;
       public bool tEdge = false;
       public bool center = false;
        public double t, p, m;
        float x, c, yt, temp, ts, tt, tf, r, dycdx, theta, scale;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gotPoints == true)
            {
                Render();
            }
        }

        private void tX_Scroll(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tY_Scroll(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void tZ_Scroll(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void checkWires_CheckedChanged(object sender, EventArgs e)
        {
            mainWing.DrawWires = checkWires.Checked;
            this.Refresh();
        }

        private void checkSlices_CheckedChanged(object sender, EventArgs e)
        {
            mainWing.ShowSlices = checkSlices.Checked;
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tX.Value = 0;
            tY.Value = 0;
            tZ.Value = 0;
            checkWires.Checked = true;
            checkSlices.Checked = true;
            int naca, thick, camb, cambd, front;
            float mask;
            p = 0.0;
            t = 0.0;
            m = 0.0;
            naca = 2412;
            num_slice = 25;
            scale = 97;
            lEdge = true;
            mask = (float)naca;
            mask = (float)(mask / 100.0);
            front = naca / 100;
            mask = (float)((mask - front) * 100.0);
            thick = (int)mask;
            MaxThick.Text = thick.ToString() + " %";
            mask = (float)front;
            camb = front / 10;
            MaxCamber.Text = camb.ToString() + " %";
            mask = (float)(mask / 10.0);
            mask = (float)((mask - camb) * 10.0);
            cambd = (int)(mask + 0.01);
            t = (double)(thick) / 100.0;
            DisttoMaxCamb.Text = cambd.ToString() + "0%";
            t = (double)(thick) / 100.0;

            p = (double)(cambd) / 10;
            m = (double)(camb) / 100.0;
            //bl = true;

            textBox1.Text = p.ToString();
            textBox2.Text = m.ToString();
            // thick is the maximum thickness in per cent (%)
            // Camb is the maximum Camber in per cent
            // cambd is the distance of the maximum camber from the leading edge.
            xl = new float[101];
            yl = new float[101];
            xu = new float[101];
            yu = new float[101];
            yc = new float[101];
            c = 1.00f;
            // t = (double)(thick) / 100.0;

            //  p = (double)(cambd) / 10;
            //   m = (double)(camb) / 100.0;
            //  t = 0.12;
            //   p = 0.40;
            //   m = 0.02;
            int i;
            for (i = 0; i <= 100; i++)
            {

                x = i;
                x = x / (float)100.0;
                temp = x / c;
                ts = temp * temp;
                tt = ts * temp;
                tf = tt * temp;
                yt = (float)(5.0 * t * c * (0.2969 * Math.Sqrt(temp) - 0.1260 * (temp) - 0.3516 * ts + 0.2843 * tt - 0.1015 * tf));
                //cout << " x = " << x << "  yt= " << yt << "\n";
                if (p < 0.00001)
                {
                    yc[i] = (float)0.0;
                    dycdx = (float)0.0;
                    theta = (float)0.0;
                }
                else
                {
                    if (x <= p * c)
                    {
                        yc[i] = (float)(m * (x / (p * p)) * (2.0 * p - x / c));
                        dycdx = (float)((2.0 * m) / (p * p) * (p - x / c));
                    }
                    else
                    {
                        yc[i] = (float)(m * (c - x) / ((1 - p) * (1 - p)) * (1.0 + x / c - 2.0 * p));
                        dycdx = (float)((2.0 * m) / ((1 - p) * (1 - p)) * (p - x / c));
                    }
                    theta = (float)Math.Atan(dycdx);
                }
                xl[i] = (float)(x + yt * Math.Sin(theta));
                yl[i] = (float)(yc[i] - yt * Math.Cos(theta));
                xu[i] = (float)(x - yt * Math.Sin(theta));
                yu[i] = (float)(yc[i] + yt * Math.Cos(theta));
            }
            gotPoints = true;
            mainWing = new Math3D.Wing(lEdge, center, tEdge, xl, yl, xu, yu, num_slice, scale);
            drawOrigin = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
        }

        private void trailingEdge_CheckedChanged(object sender, EventArgs e)
        {
            lEdge = false;
            tEdge = true;
            center = false;
        }

        private void Center_CheckedChanged(object sender, EventArgs e)
        {
            lEdge = false;
            tEdge = false;
            center = true;
        }

        private void leadingEdge_CheckedChanged(object sender, EventArgs e)
        {
            lEdge = true;
            tEdge = false;
            center = false;
        }
 
        float[] xu, xl, yu, yl, yc;
        int num_slice;


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        public Form1()
        {
            InitializeComponent();
        }

        Math3D.Wing mainWing;
        Point drawOrigin;

        private void Start_Analysis_Click(object sender, EventArgs e)
        {
            int naca, thick, camb, cambd, front;
            float mask;
            p = 0.0;
            t = 0.0;
            m = 0.0;
            naca = int.Parse(nacas.Text);
            num_slice = int.Parse(num_slices.Text);
            scale = float.Parse(scalebox.Text);

            mask = (float)naca;
            mask = (float)(mask / 100.0);
            front = naca / 100;
            mask = (float)((mask - front) * 100.0);
            thick = (int)mask;
            MaxThick.Text = thick.ToString() + " %";
            mask = (float)front;
            camb = front / 10;
            MaxCamber.Text = camb.ToString() + " %";
            mask = (float)(mask / 10.0);
            mask = (float)((mask - camb) * 10.0);
            cambd = (int)(mask + 0.01);
            t = (double)(thick) / 100.0;
            DisttoMaxCamb.Text = cambd.ToString() + "0%";
            t = (double)(thick) / 100.0;

            p = (double)(cambd) / 10;
            m = (double)(camb) / 100.0;
            //bl = true;

            textBox1.Text = p.ToString();
            textBox2.Text = m.ToString();
            // thick is the maximum thickness in per cent (%)
            // Camb is the maximum Camber in per cent
            // cambd is the distance of the maximum camber from the leading edge.
            xl = new float[101];
            yl = new float[101];
            xu = new float[101];
            yu = new float[101];
            yc = new float[101];
            c = float.Parse(CLength.Text);
            // t = (double)(thick) / 100.0;

            //  p = (double)(cambd) / 10;
            //   m = (double)(camb) / 100.0;
            //  t = 0.12;
            //   p = 0.40;
            //   m = 0.02;
            int i;
            for (i = 0; i <= 100; i++)
            {

                x = i;
                x = x / (float)100.0;
                temp = x / c;
                ts = temp * temp;
                tt = ts * temp;
                tf = tt * temp;
                yt = (float)(5.0 * t * c * (0.2969 * Math.Sqrt(temp) - 0.1260 * (temp) - 0.3516 * ts + 0.2843 * tt - 0.1015 * tf));
                //cout << " x = " << x << "  yt= " << yt << "\n";
                if (p < 0.00001)
                {
                    yc[i] = (float)0.0;
                    dycdx = (float)0.0;
                    theta = (float)0.0;
                }
                else
                {
                    if (x <= p * c)
                    {
                        yc[i] = (float)(m * (x / (p * p)) * (2.0 * p - x / c));
                        dycdx = (float)((2.0 * m) / (p * p) * (p - x / c));
                    }
                    else
                    {
                        yc[i] = (float)(m * (c - x) / ((1 - p) * (1 - p)) * (1.0 + x / c - 2.0 * p));
                        dycdx = (float)((2.0 * m) / ((1 - p) * (1 - p)) * (p - x / c));
                    }
                    theta = (float)Math.Atan(dycdx);
                }
                xl[i] = (float)(x + yt * Math.Sin(theta));
                yl[i] = (float)(yc[i] - yt * Math.Cos(theta));
                xu[i] = (float)(x - yt * Math.Sin(theta));
                yu[i] = (float)(yc[i] + yt * Math.Cos(theta));
            }
            gotPoints = true;
            mainWing = new Math3D.Wing(lEdge, center, tEdge, xl, yl, xu, yu, num_slice, scale);
            drawOrigin = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            mainWing.DrawWires = checkWires.Checked;
            mainWing.ShowSlices = checkSlices.Checked;
            this.Refresh();
        }
        private void Render()
        {
            mainWing.RotateX = (float)tX.Value;
            mainWing.RotateY = (float)tY.Value;
            mainWing.RotateZ = (float)tZ.Value;

            pictureBox1.Image = mainWing.DrawSlices(drawOrigin);
        } 
              
    }
}

