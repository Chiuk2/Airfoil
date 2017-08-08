using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Airfoil
{
    class Math3D
    {
        const double PIOVER180 = Math.PI / 180.0;
        public class Vector3D
        {
            public float x;
            public float y;
            public float z;

            public Vector3D(int _x, int _y, int _z)
            {
                x = _x;
                y = _y;
                z = _z;
            }

            public Vector3D(double _x, double _y, double _z)
            {
                x = (float)_x;
                y = (float)_y;
                z = (float)_z;
            }

            public Vector3D(float _x, float _y, float _z)
            {
                x = _x;
                y = _y;
                z = _z;
            }

            public Vector3D()
            {
            }

            public override string ToString()
            {
                return "(" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ")";
            }
        }

        internal class Camera
        {
            public Vector3D position = new Vector3D();
        }

       

        public class Wing
        {
            internal class Slice : IComparable<Slice>
            {
                Wing a_instance;
                public Slice(Wing b_instance)
                {
                    a_instance = b_instance;
                }

                public PointF[] Corners2D;
                public Vector3D[] Corners3D;
                public Vector3D Center;

                public Slice()
                {
                }

                public int CompareTo(Slice otherSlice)
                {
                    return (int)(this.Center.z - otherSlice.Center.z); //In order of which is closest to the screen
                }

            }

            public bool lEdge;
            public bool center;
            public bool tEdge;
            public float[] xu, xl, yu, yl;
            public float scale;
            public int num_slice;

            float xRotation = 0.0f;
            float yRotation = 0.0f;
            float zRotation = 0.0f;

            bool drawWires = true;
            bool showSlices = true;

            Vector3D sliceOrigin;
            Slice[] slices;

            public float RotateX
            {
                get { return xRotation; }
                set
                {
                    //rotate the difference between this rotation and last rotation
                    RotateSlicesX(value - xRotation);
                    xRotation = value;
                }
            }

            public float RotateY
            {
                get { return yRotation; }
                set
                {
                    RotateSlicesY(value - yRotation);
                    yRotation = value;
                }
            }

            public float RotateZ
            {
                get { return zRotation; }
                set
                {
                    RotateSlicesZ(value - zRotation);
                    zRotation = value;
                }
            }

            public bool DrawWires
            {
                get { return drawWires; }
                set { drawWires = value; }
            }

            public bool ShowSlices
            {
                get { return showSlices; }
                set { showSlices = value; }
            }

            #region Initializers

            public Wing(bool edgel, bool edgec, bool edget, float[] lx, float[] ly, float[] ux, float[] uy, int n_slice, float scal)
            {
                lEdge = edgel;
                center = edgec;
                tEdge = edget;
                scale = scal;
                num_slice = n_slice;
                xl = lx;
                xu = ux;
                yu = uy;
                yl = ly;
                sliceOrigin = new Math3D.Vector3D((int)(((800 * xl[100])) / 2), 800 / 2, (num_slice * 20 + 100) / 2);

                InitializeSlices();
            }


            #endregion

            private void InitializeSlices()
            {


                int xl1, yl1, xu1, yu1, yc1, xl2, yl2, xu2, yu2, yc2, xc1, xc2;

                xl1 = 0;
                yl1 = 200;
                xu1 = 0;
                yu1 = 200;
                yc1 = 200;
                xc1 = 0;

                if (lEdge == true)
                {
                    slices = new Slice[num_slice];
                    for (int i = 0; i < num_slice; i++)
                    {
                        slices[i] = new Slice();
                        slices[i].Corners3D = new Vector3D[14];
                        slices[i].Corners3D[0] = new Vector3D(xl1, yl1 + 200, i * 20 + 100);
                        slices[i].Corners3D[1] = new Vector3D((int)(800 * xl[2] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yl[2] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[2] = new Vector3D((int)(800 * xl[10] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yl[10] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[3] = new Vector3D((int)(800 * xl[20] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yl[20] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[4] = new Vector3D((int)(800 * xl[40] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yl[40] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[5] = new Vector3D((int)(800 * xl[60] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yl[60] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[6] = new Vector3D((int)(800 * xl[80] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yl[80] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[7] = new Vector3D((int)(800 * xu[100] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yu[100] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[8] = new Vector3D((int)(800 * xu[80] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yu[80] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[9] = new Vector3D((int)(800 * xu[60] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yu[60] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[10] = new Vector3D((int)(800 * xu[40] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yu[40] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[11] = new Vector3D((int)(800 * xu[20] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yu[20] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[12] = new Vector3D((int)(800 * xu[10] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yu[10] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[13] = new Vector3D((int)(800 * xu[2] * Math.Pow(scale * .01f, i)), 400 - (int)(800 * yu[2] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Center = new Vector3D((int)((800 * xu[100] * Math.Pow(scale * .01f, i)) - xl1)/2, 400, i * 20 + 100);
                    }

                    /*if (i+1 < num_slice - 1)
                      {
                          g.DrawLine(System.Drawing.Pens.Black, new Point(xl1 + 40, yl1 + 600), new Point(xl1 + 40, yl1 + 600));
                          g.DrawLine(System.Drawing.Pens.Black, new Point((int)(800 * xl[2] * Math.Pow(scale * .01f, i)) + 40, 800 - (int)(800 * yl[2] * Math.Pow(scale * .01f, i))), new Point((int)(800 * xl[2] * Math.Pow(scale * .01f, i + 1)) + 40, 800 - (int)(800 * yl[2] * Math.Pow(scale * .01f, i + 1))));
                      }*/

                }

                else if (tEdge == true)
                {
                    slices = new Slice[num_slice];
                    for (int i = 0; i < num_slice; i++)
                    {
                        int translation;
                        translation = (int)((800 * xl[100]) - ((800 * xl[100] * Math.Pow(scale * .01f, i))));
                        slices[i] = new Slice();
                        slices[i].Corners3D = new Vector3D[14];
                        slices[i].Corners3D[0] = new Vector3D(xl1 + translation, yl1 + 200, i * 20 + 100);
                        slices[i].Corners3D[1] = new Vector3D((int)(800 * xl[2] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[2] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[2] = new Vector3D((int)(800 * xl[10] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[10] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[3] = new Vector3D((int)(800 * xl[20] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[20] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[4] = new Vector3D((int)(800 * xl[40] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[40] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[5] = new Vector3D((int)(800 * xl[60] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[60] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[6] = new Vector3D((int)(800 * xl[80] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[80] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[7] = new Vector3D((int)(800 * xu[100] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[100] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[8] = new Vector3D((int)(800 * xu[80] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[80] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[9] = new Vector3D((int)(800 * xu[60] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[60] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[10] = new Vector3D((int)(800 * xu[40] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[40] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[11] = new Vector3D((int)(800 * xu[20] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[20] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[12] = new Vector3D((int)(800 * xu[10] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[10] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[13] = new Vector3D((int)(800 * xu[2] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[2] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Center = new Vector3D((int)(((800 * xu[100] * Math.Pow(scale * .01f, i)) - xl1)/2) + translation, 400, i * 20 + 100);
                    }
                }

                else if (center == true)
                {
                    slices = new Slice[num_slice];
                    int halfOrig = (int)(((800 * xl[100]) - (xl1)) / 2);
                    for (int i = 0; i < num_slice; i++)
                    {
                        int translation, halfCurr;
                        halfCurr = (int)(((800 * xl[100] * Math.Pow(scale * .01f, i)) - (xl1)) / 2);
                        translation = (halfOrig - halfCurr);
                        slices[i] = new Slice();
                        slices[i].Corners3D = new Vector3D[14];
                        slices[i].Corners3D[0] = new Vector3D(xl1 + translation, yl1 + 200, i * 20 + 100);
                        slices[i].Corners3D[1] = new Vector3D((int)(800 * xl[2] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[2] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[2] = new Vector3D((int)(800 * xl[10] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[10] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[3] = new Vector3D((int)(800 * xl[20] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[20] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[4] = new Vector3D((int)(800 * xl[40] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[40] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[5] = new Vector3D((int)(800 * xl[60] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[60] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[6] = new Vector3D((int)(800 * xl[80] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yl[80] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[7] = new Vector3D((int)(800 * xu[100] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[100] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[8] = new Vector3D((int)(800 * xu[80] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[80] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[9] = new Vector3D((int)(800 * xu[60] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[60] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[10] = new Vector3D((int)(800 * xu[40] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[40] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[11] = new Vector3D((int)(800 * xu[20] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[20] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[12] = new Vector3D((int)(800 * xu[10] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[10] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Corners3D[13] = new Vector3D((int)(800 * xu[2] * Math.Pow(scale * .01f, i)) + translation, 400 - (int)(800 * yu[2] * Math.Pow(scale * .01f, i)), i * 20 + 100);
                        slices[i].Center = new Vector3D((int)(((800 * xu[100] * Math.Pow(scale * .01f, i)) - xl1) / 2), 400, i * 20 + 100);

                    }
                }
            }
            //Calculates the 2D points of each face
            private void Update2DPoints(Point drawOrigin)
            {
                //Update the 2D points of all the faces
                for (int i = 0; i < slices.Length; i++)
                {
                    Update2DPoints(drawOrigin, i);
                }
            }

            private void Update2DPoints(Point drawOrigin, int sliceIndex)
            {
                //Calculates the projected coordinates of the 3D points in a cube face
                PointF[] point2D = new PointF[14];
                float zoom = (float)Screen.PrimaryScreen.Bounds.Width / 1.5f;
                Point tmpOrigin = new Point(0, 0);

                //Convert 3D Points to 2D
                Math3D.Vector3D vec;
                for (int i = 0; i < point2D.Length; i++)
                {
                    vec = slices[sliceIndex].Corners3D[i];
                    point2D[i] = Get2D(vec, drawOrigin);
                }

                //Update face
                slices[sliceIndex].Corners2D = point2D;
            }

            private void RotateSlicesX(float deltaX)
            {
                for (int i = 0; i < slices.Length; i++)
                {
                    //Apply rotation
                    //------Rotate points
                    Vector3D point0 = new Vector3D(0, 0, 0);
                    slices[i].Corners3D = Math3D.Translate(slices[i].Corners3D, sliceOrigin, point0); //Move corner to origin
                    slices[i].Corners3D = Math3D.RotateX(slices[i].Corners3D, deltaX);
                    slices[i].Corners3D = Math3D.Translate(slices[i].Corners3D, point0, sliceOrigin); //Move back

                    //-------Rotate center
                    slices[i].Center = Math3D.Translate(slices[i].Center, sliceOrigin, point0);
                    slices[i].Center = Math3D.RotateX(slices[i].Center, deltaX);
                    slices[i].Center = Math3D.Translate(slices[i].Center, point0, sliceOrigin);
                }
            }

            private void RotateSlicesY(float deltaY)
            {
                for (int i = 0; i < slices.Length; i++)
                {
                    //Apply rotation
                    //------Rotate points
                    Vector3D point0 = new Vector3D(0, 0, 0);
                    slices[i].Corners3D = Math3D.Translate(slices[i].Corners3D, sliceOrigin, point0); //Move corner to origin
                    slices[i].Corners3D = Math3D.RotateY(slices[i].Corners3D, deltaY);
                    slices[i].Corners3D = Math3D.Translate(slices[i].Corners3D, point0, sliceOrigin); //Move back

                    //-------Rotate center
                    slices[i].Center = Math3D.Translate(slices[i].Center, sliceOrigin, point0);
                    slices[i].Center = Math3D.RotateY(slices[i].Center, deltaY);
                    slices[i].Center = Math3D.Translate(slices[i].Center, point0, sliceOrigin);
                }
            }

            private void RotateSlicesZ(float deltaZ)
            {
                for (int i = 0; i < slices.Length; i++)
                {
                    //Apply rotation
                    //------Rotate points
                    Vector3D point0 = new Vector3D(0, 0, 0);
                    slices[i].Corners3D = Math3D.Translate(slices[i].Corners3D, sliceOrigin, point0); //Move corner to origin
                    slices[i].Corners3D = Math3D.RotateZ(slices[i].Corners3D, deltaZ);
                    slices[i].Corners3D = Math3D.Translate(slices[i].Corners3D, point0, sliceOrigin); //Move back

                    //-------Rotate center
                    slices[i].Center = Math3D.Translate(slices[i].Center, sliceOrigin, point0);
                    slices[i].Center = Math3D.RotateZ(slices[i].Center, deltaZ);
                    slices[i].Center = Math3D.Translate(slices[i].Center, point0, sliceOrigin);
                }
            }

            public Bitmap DrawSlices(Point drawOrigin)
            {
                //Get the corresponding 2D
                Update2DPoints(drawOrigin);

                //Get the bounds of the final bitmap
                Rectangle bounds = getDrawingBounds();
                bounds.Width += drawOrigin.X;
                bounds.Height += drawOrigin.Y;

                Bitmap finalBmp = new Bitmap(bounds.Width, bounds.Height);
                Graphics g = Graphics.FromImage(finalBmp);

                g.SmoothingMode = SmoothingMode.AntiAlias;

                Array.Sort(slices); //sort faces from closets to farthest
                //message();
                for (int i = 0; i < slices.Length; i++) //draw faces from back to front
                {
                    Color red = Color.White;
                    if (showSlices)
                    {
                        g.FillClosedCurve(new SolidBrush(red), slices[i].Corners2D);
                    }
                    if (drawWires)
                    {
                        for (int j = 0; j < 14; j++)
                        {
                            if (i + 1 < slices.Length)
                            {
                                g.DrawLine(Pens.Red, slices[i].Corners2D[j], slices[i + 1].Corners2D[j]);
                            }
                        }
                        g.DrawClosedCurve(System.Drawing.Pens.Red, slices[i].Corners2D); 
                    }
                }

                g.Dispose();

                return finalBmp;
            }

            private PointF Get2D(Vector3D vec, Point drawOrigin)
            {
                PointF point2D = Get2D(vec);
                return new PointF(point2D.X + drawOrigin.X, point2D.Y + drawOrigin.Y);
            }

            private PointF Get2D(Vector3D vec)
            {
                PointF returnPoint = new PointF();

                float zoom = (float)Screen.PrimaryScreen.Bounds.Width / 1.5f;
                Camera tempCam = new Camera();

                tempCam.position.x = sliceOrigin.x;
                tempCam.position.y = sliceOrigin.y;
                tempCam.position.z = (sliceOrigin.x * zoom) / sliceOrigin.x;

                float zValue = -vec.z - tempCam.position.z;

                returnPoint.X = (tempCam.position.x - vec.x) / zValue * zoom;
                returnPoint.Y = (tempCam.position.y - vec.y) / zValue * zoom;

                return returnPoint;
            }
            private Rectangle getDrawingBounds()
            {
                //Find the farthest most points to calculate the size of the returning bitmap
                float left = float.MaxValue;
                float right = float.MinValue;
                float top = float.MaxValue;
                float bottom = float.MinValue;

                for (int i = 0; i < slices.Length; i++)
                {
                    for (int j = 0; j < slices[i].Corners2D.Length; j++)
                    {
                        if (slices[i].Corners2D[j].X < left)
                            left = slices[i].Corners2D[j].X;
                        if (slices[i].Corners2D[j].X > right)
                            right = slices[i].Corners2D[j].X;
                        if (slices[i].Corners2D[j].Y < top)
                            top = slices[i].Corners2D[j].Y;
                        if (slices[i].Corners2D[j].Y > bottom)
                            bottom = slices[i].Corners2D[j].Y;
                    }
                }

                return new Rectangle(0, 0, (int)Math.Round(right - left), (int)Math.Round(bottom - top));
            }
        }
        public static Vector3D RotateX(Vector3D point3D, float degrees)
        {
            //[ a  b  c ] [ x ]   [ x*a + y*b + z*c ]
            //[ d  e  f ] [ y ] = [ x*d + y*e + z*f ]
            //[ g  h  i ] [ z ]   [ x*g + y*h + z*i ]

            //[ 1    0        0   ]
            //[ 0   cos(x)  sin(x)]
            //[ 0   -sin(x) cos(x)]

            double cDegrees = degrees * PIOVER180;
            double cosDegrees = Math.Cos(cDegrees);
            double sinDegrees = Math.Sin(cDegrees);

            double y = (point3D.y * cosDegrees) + (point3D.z * sinDegrees);
            double z = (point3D.y * -sinDegrees) + (point3D.z * cosDegrees);

            return new Vector3D(point3D.x, y, z);
        }

        public static Vector3D RotateY(Vector3D point3D, float degrees)
        {
            //[ cos(x)   0    sin(x)]
            //[   0      1      0   ]
            //[-sin(x)   0    cos(x)]

            double cDegrees = degrees * PIOVER180;
            double cosDegrees = Math.Cos(cDegrees);
            double sinDegrees = Math.Sin(cDegrees);

            double x = (point3D.x * cosDegrees) + (point3D.z * sinDegrees);
            double z = (point3D.x * -sinDegrees) + (point3D.z * cosDegrees);

            return new Vector3D(x, point3D.y, z);
        }

        public static Vector3D RotateZ(Vector3D point3D, float degrees)
        {
            //[ cos(x)  sin(x) 0]
            //[ -sin(x) cos(x) 0]
            //[    0     0     1]

            double cDegrees = degrees * PIOVER180;
            double cosDegrees = Math.Cos(cDegrees);
            double sinDegrees = Math.Sin(cDegrees);

            double x = (point3D.x * cosDegrees) + (point3D.y * sinDegrees);
            double y = (point3D.x * -sinDegrees) + (point3D.y * cosDegrees);

            return new Vector3D(x, y, point3D.z);
        }

        public static Vector3D Translate(Vector3D points3D, Vector3D oldOrigin, Vector3D newOrigin)
        {
            Vector3D difference = new Vector3D(newOrigin.x - oldOrigin.x, newOrigin.y - oldOrigin.y, newOrigin.z - oldOrigin.z);
            points3D.x += difference.x;
            points3D.y += difference.y;
            points3D.z += difference.z;
            return points3D;
        }

        public static Vector3D[] RotateX(Vector3D[] points3D, float degrees)
        {
            for (int i = 0; i < points3D.Length; i++)
            {
                points3D[i] = RotateX((Vector3D)points3D[i], degrees);
            }
            return points3D;
        }

        public static Vector3D[] RotateY(Vector3D[] points3D, float degrees)
        {
            for (int i = 0; i < points3D.Length; i++)
            {
                points3D[i] = RotateY((Vector3D)points3D[i], degrees);
            }
            return points3D;
        }

        public static Vector3D[] RotateZ(Vector3D[] points3D, float degrees)
        {
            for (int i = 0; i < points3D.Length; i++)
            {
                points3D[i] = RotateZ((Vector3D)points3D[i], degrees);
            }
            return points3D;
        }

        public static Vector3D[] Translate(Vector3D[] points3D, Vector3D oldOrigin, Vector3D newOrigin)
        {
            for (int i = 0; i < points3D.Length; i++)
            {
                points3D[i] = Translate(points3D[i], oldOrigin, newOrigin);
            }
            return points3D;
        }
    }
}

