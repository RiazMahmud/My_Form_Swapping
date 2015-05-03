using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
namespace MyFormSwaping
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }
        int i1 = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        BO_Class bo_class = new BO_Class();
        //Start panel1
        int flag1;
        private void reset()
        {
            panel1.Location = new Point(bo_class.x1, bo_class.y1);
            panel2.Location = new Point(bo_class.x2, bo_class.y2);
            panel3.Location = new Point(bo_class.x3, bo_class.y3);
            panel4.Location = new Point(bo_class.x4, bo_class.y4);
            i1 = 0;
            i2 = 0;
            i3 = 0;
            i4 = 0;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag1 == 1)
            {
                panel1.Location = new Point(Cursor.Position.X - 220, Cursor.Position.Y - 220);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            flag1 = 1;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            flag1 = 0;
            i2 = 1;
            i3 = 1;
            i4 = 1;
            bo_class.soundPlay();
            if (i1 == 1)
            {
                reset();
            }
            if (bo_class.panel1Left(panel1.Location.X,panel1.Location.Y, panel2.Location.X,panel3.Location.X, panel4.Location.X))
            {
                if (panel1.Location.Y <= 338)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                }
                else
                {
                    panel1.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }
            }
            else if (bo_class.panel1Right(panel1.Location.X,panel1.Location.Y, panel2.Location.X,panel3.Location.X,panel4.Location.X))
            {
                if (panel1.Location.Y <= 338)
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x1, bo_class.y1);

                }
                else
                {
                    panel1.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                }
            }
            else if (bo_class.panel1Down(panel1.Location.X,panel1.Location.Y, panel2.Location.X, panel3.Location.X,panel4.Location.X))
            {
                if (panel1.Location.X <= 440)
                {
                    panel1.Location = new Point(bo_class.x3, bo_class.y3);
                    panel2.Location = new Point(bo_class.x1, bo_class.y1);
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);
                }
                else
                {
                    panel1.Location = new Point(bo_class.x4, bo_class.y4);
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                }


            }
            else if (bo_class.panel1Up(panel1.Location.X,panel1.Location.Y,panel2.Location.X,panel3.Location.X,panel4.Location.X))
            {
                if (panel1.Location.X <= 440)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                }
                else
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }
                
            }
            else if(bo_class.panel1CrossUpToRight(panel1.Location.X,panel1.Location.Y,panel2.Location.X,panel3.Location.X,panel4.Location.X))
            {
                if (panel2.Location.Y <= 338 && panel3.Location.Y >= 338)
                {
                    panel1.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x1, bo_class.y1);
                }
                else
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }
            }
            else if (bo_class.panel1CrossUpToLeft(panel1.Location.X, panel1.Location.Y, panel2.Location.X, panel3.Location.X, panel4.Location.X))
            {
                if (panel2.Location.Y <= 338 && panel3.Location.Y >= 338)
                {
                    panel1.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);
                    
                }
                else
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                   
                }
            }
        }
        //End panel1

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void UI_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
        //start panel2
        int flag2;
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            flag2 = 0;
            i1 = 1;
            i3 = 1;
            i4 = 1;
            if (i2 == 1)
            {
                reset();
            }
            bo_class.soundPlay();
            if (bo_class.panel2Left(panel2.Location.X, panel2.Location.Y, panel1.Location.X, panel3.Location.X, panel4.Location.X))
            {
                if (panel2.Location.Y <= 338)
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x1, bo_class.y1);
                }
                else
                {
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }
            }
            else if (bo_class.panel2Right(panel2.Location.X, panel2.Location.Y, panel1.Location.X, panel3.Location.X, panel4.Location.X))
            {
                if (panel2.Location.Y <= 338)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                }
                else
                {
                    panel2.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                }
            }
            else if (bo_class.panel2Down(panel2.Location.X, panel2.Location.Y, panel1.Location.X, panel3.Location.X, panel4.Location.X))
            {
                if (panel2.Location.X <= 440)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);
                }
                else
                {
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                }


            }
            else if (bo_class.panel2Up(panel2.Location.X, panel2.Location.Y, panel1.Location.X, panel3.Location.X, panel4.Location.X))
            {
                if (panel2.Location.X <= 440)
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x1, bo_class.y1);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                }
                else
                {
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }

            }
            else if (bo_class.panel2CrossUpToLeft(panel2.Location.X, panel2.Location.Y, panel1.Location.X, panel3.Location.X, panel4.Location.X))
            {
                if (panel1.Location.Y <= 338 && panel3.Location.Y >= 338)
                {
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);

                }
                else
                {
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);

                }
            }
            else if (bo_class.panel1CrossUpToRight(panel2.Location.X, panel2.Location.Y, panel1.Location.X, panel3.Location.X, panel4.Location.X))
            {
                if (panel1.Location.Y <= 338 && panel3.Location.Y >= 338)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x4, bo_class.y4);
                }
                else
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x1, bo_class.y1);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }
            }


        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag2 == 1)
            {
                panel2.Location = new Point(Cursor.Position.X - 220, Cursor.Position.Y - 220);
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            flag2 = 1;
        }
        //end panel2

        //Start panel3
        int flag3;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            flag3 = 1;
        }
        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            flag3 = 0;
            i2 = 1;
            i1 = 1;
            i4 = 1;
            if (i3 == 1)
            {
                reset();
            }
            bo_class.soundPlay();
            if (bo_class.panel3Right(panel3.Location.X,panel3.Location.Y, panel1.Location.X,panel2.Location.X,panel4.Location.X))
            {
                if (panel3.Location.Y <= 338)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);

                }
                else
                {
                    panel3.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                }
            }
            if (bo_class.panel3Left(panel3.Location.X, panel3.Location.Y, panel1.Location.X, panel2.Location.X, panel4.Location.X))
            {
                if (panel3.Location.Y <= 338)
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x1, bo_class.y1);

                }
                else
                {
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }
            }
            else if (bo_class.panel3Up(panel3.Location.X, panel3.Location.Y, panel1.Location.X, panel2.Location.X, panel4.Location.X))
            {
                if (panel3.Location.X <= 440)
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x1, bo_class.y1);
                }
                else
                {
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }

            }
            else if (bo_class.panel3Down(panel3.Location.X, panel3.Location.Y, panel1.Location.X, panel2.Location.X, panel4.Location.X))
            {
                if (panel3.Location.X <= 440)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                }
                else
                {
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                }


            }
            else if (bo_class.panel3CrossUpToLeft(panel3.Location.X, panel3.Location.Y, panel1.Location.X, panel2.Location.X, panel4.Location.X))
            {
                if (panel2.Location.Y <= 338)
                {
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x2, bo_class.y2);
                }
                else
                {
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);

                }
            }
            else if (bo_class.panel3CrossUpToRight(panel3.Location.X, panel3.Location.Y, panel1.Location.X, panel2.Location.X, panel4.Location.X))
            {
                if (panel1.Location.Y <= 338 && panel2.Location.Y >= 338)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel3.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                }
                else
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x1, bo_class.y1);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }
            }
            
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag3 == 1)
            {
                panel3.Location = new Point(Cursor.Position.X - 220, Cursor.Position.Y - 220);
            }
        }
        //End panel3

        //Start panel4
        int flag4;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            flag4 = 1;
        }
        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag4 == 1)
            {
                panel4.Location = new Point(Cursor.Position.X - 220, Cursor.Position.Y - 220);
            }

        }
        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            flag4 = 0;
            i2 = 1;
            i3 = 1;
            i1 = 1;
            if (i4 == 1)
            {
                reset();
            }
            bo_class.soundPlay();
            if (bo_class.panel4Left(panel4.Location.X, panel4.Location.Y, panel1.Location.X, panel2.Location.X, panel3.Location.X))
            {
                if (panel4.Location.Y >= 338)
                {
                    panel3.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                }
                else
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel4.Location = new Point(bo_class.x1, bo_class.y1);
                }
            }
           else if (bo_class.panel4Right(panel4.Location.X, panel4.Location.Y, panel1.Location.X, panel2.Location.X, panel3.Location.X))
            {
                if (panel4.Location.Y >= 338)
                {
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }
                else
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel4.Location = new Point(bo_class.x2, bo_class.y2);
                }
            }
            else if (bo_class.panel4Down(panel4.Location.X, panel4.Location.Y, panel1.Location.X, panel2.Location.X, panel3.Location.X))
            {
                if (panel4.Location.X <= 440)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);
                }
                else
                {
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                }


            }
            else if (bo_class.panel4Up(panel4.Location.X, panel4.Location.Y, panel1.Location.X, panel2.Location.X, panel3.Location.X))
            {
                if (panel4.Location.X <= 440)
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x1, bo_class.y1);
                }
                else
                {
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x2, bo_class.y2);
                }

            }
            else if (bo_class.panel4CrossUpToLeft(panel4.Location.X, panel4.Location.Y, panel1.Location.X, panel2.Location.X, panel3.Location.X))
            {
                if (panel1.Location.Y <= 338 && panel2.Location.Y >= 338)
                {
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                    panel4.Location = new Point(bo_class.x3, bo_class.y3);

                }
                else
                {
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel4.Location = new Point(bo_class.x2, bo_class.y2);

                }
            }
            else if (bo_class.panel4CrossUpToRight(panel4.Location.X, panel4.Location.Y, panel1.Location.X, panel2.Location.X, panel3.Location.X))
            {
                if (panel1.Location.Y <= 338 && panel2.Location.Y >= 338)
                {
                    panel1.Location = new Point(bo_class.x1, bo_class.y1);
                    panel4.Location = new Point(bo_class.x4, bo_class.y4);
                    panel3.Location = new Point(bo_class.x3, bo_class.y3);
                    panel2.Location = new Point(bo_class.x2, bo_class.y2);
                }
                else
                {
                    panel1.Location = new Point(bo_class.x2, bo_class.y2);
                    panel2.Location = new Point(bo_class.x3, bo_class.y3);
                    panel3.Location = new Point(bo_class.x4, bo_class.y4);
                    panel4.Location = new Point(bo_class.x1, bo_class.y1);
                }
            }
        }
        //End panel4
               
    }
}
