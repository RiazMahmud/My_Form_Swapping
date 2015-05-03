using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BO
{
    public class BO_Class
    {
        public int x1 = 96;
        public int y1 = 128;
        public int x2 = 484;
        public int y2 = 128;
        public int x3 = 96;
        public int y3 = 380;
        public int x4 = 484;
        public int y4 = 380;

        DAL_Class dal_class = new DAL_Class();
        public void soundPlay()
        {
            dal_class.soundPlay();
        }
        //Start panel1
        public bool panel1Right(int x,int y, int x2,int x3,int x4)
        {
            if (((x + 304) >= 484 && y <= 338 && x2 == 484 && x3 == 96 && x4 == 484) || ((x + 304) >= 484 && y >= 338 && x2 == 96 && x3 == 484 && x4 == 484))
            {
                return true;
            }
            else
                return false;
        }
       
        public bool panel1Left(int x,int y, int x2, int x3,int x4)
        {
            if ((x <= 400 && y <= 338 && x2 == 96 && x3 == 96 && x4 == 484 ) || (x <= 400 && y >= 338 && x2 == 96 && x3 == 484 && x4 == 96))
            {
                return true;
            }
            else
                return false;
        }
        
        public bool panel1Down(int x,int y, int x2,int x3,int x4)
        {
            if (((y + 108) >= 380 && (x + 304)<= 440 && x2 == 484 && x3 == 96 && x4 == 484) || ((y + 108) >= 380 && x >= 440 && x2 == 96 && x3 == 96 && x4 == 484))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel1Up(int x,int y, int x2, int x3, int x4)
        {
            if ((y <= 236 && (x + 304) <= 440 && x2 == 96 && x3 == 484 && x4 == 484) || (y <= 236 && x >= 440 && x2 == 96 && x3 == 484 && x4 == 96))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel1CrossUpToRight(int x, int y,int x2, int x3, int x4)
        {
            if ((x >= 484 && y >= 380 && x2 == 484 && x3 == 96 && x4 == 484) || ((x <= 96 && y <= 128 && x2 == 96 && x3 == 484 && x4 == 96)))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel1CrossUpToLeft(int x, int y, int x2, int x3, int x4)
        {
            if ((x <= 96 && y >= 380 && x2 == 96 && x3 == 96 && x4 == 484) || (((x + 308) >= 788 && y <= 128 && x2 == 96 && x3 == 484 && x4 == 484)))
            {
                return true;
            }
            else
                return false;
        }
        //End panel1

        //Start panel2
        public bool panel2Left(int x2, int y2, int x, int x3, int x4)
        {
            if ((x2 <= 400 && y2 <= 338 && x == 96 && x3 == 96 && x4 == 484) || (x2 <= 400 && y2 >= 338 && x == 96 && x3 == 484 && x4 == 96))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel2Right(int x2, int y2, int x, int x3, int x4)
        {
            if (((x2 + 304) >= 484 && y2 <= 338 && x == 484 && x3 == 96 && x4 == 484) || ((x2 + 304) >= 484 && y2 >= 338 && x == 96 && x3 == 484 && x4 == 484))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel2Down(int x2, int y2, int x, int x3, int x4)
        {
            if (((y2 + 108) >= 380 && (x2 + 304) <= 440 && x == 484 && x3 == 96 && x4 == 484) || ((y2 + 108) >= 380 && x2 >= 440 && x == 96 && x3 == 96 && x4 == 484))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel2Up(int x2, int y2, int x, int x3, int x4)
        {
            if ((y2 <= 236 && (x2 + 304) <= 440 && x == 96 && x3 == 484 && x4 == 484) || (y2 <= 236 && x2 >= 440 && x == 96 && x3 == 484 && x4 == 96))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel2CrossUpToLeft(int x2, int y2, int x, int x3, int x4)
        {
            if ((x2 >= 484 && y2 <= 128 && x == 96 && x3 == 484 && x4 == 484) || ((x2 <= 96 && y2 >= 380 && x == 96 && x3 == 96 && x4 == 484)))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel2CrossUpToRight(int x2, int y2, int x, int x3, int x4)
        {
            if ((x2 >= 484 && y2 >= 380 && x == 484 && x3 == 96 && x4 == 484) || ((x2 <= 96 && y2 <= 128 && x == 96 && x3 == 484 && x4 == 96)))
            {
                return true;
            }
            else
                return false;
        }
        //End panel2

        //Start panel3
        public bool panel3Right(int x3, int y3, int x, int x2, int x4)
        {
            if (((x3 + 304) >= 484 && y3 <= 338 && x == 484 && x2 == 96 && x4 == 484) || ((x3 + 304) >= 484 && y3 >= 338 && x == 96 && x2 == 484 && x4 == 484))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel3Left(int x3, int y3, int x, int x2, int x4)
        {
            if ((x3 <= 400 && y3 <= 338 && x == 96 && x2 == 96 && x4 == 484) || (x3 <= 400 && y3 >= 338 && x == 96 && x2 == 484 && x4 == 96))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel3Up(int x3, int y3, int x, int x2, int x4)
        {
            if ((y3 <= 236 && (x3 + 304) <= 440 && x == 96 && x2 == 484 && x4 == 484) || (y3 <= 236 && x3 >= 440 && x == 96 && x2 == 484 && x4 == 96))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel3Down(int x3, int y3, int x, int x2, int x4)
        {
            if (((y3 + 108) >= 380 && (x3 + 304) <= 440 && x == 484 && x2 == 96 && x4 == 484) || ((y3 + 108) >= 380 && x3 >= 440 && x == 96 && x2 == 96 && x4 == 484))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel3CrossUpToLeft(int x3, int y3, int x, int x2, int x4)
        {
            if ((x3 <= 96 && y3 >= 380 && x == 96 && x2 == 96 && x4 == 484) || (((x3 + 308) >= 788 && y3 <= 128 && x == 96 && x2 == 484 && x4 == 484)))
            {
                return true;
            }
            else
                return false;
        }
        public bool panel3CrossUpToRight(int x3, int y3, int x, int x2, int x4)
        {
            if ((x3 >= 484 && y3 >= 380 && x== 484 && x2 == 96 && x4 == 484) || ((x3 <= 96 && y3 <= 128 && x == 96 && x2 == 484 && x4 == 96)))
            {
                return true;
            }
            else
                return false;
        }
        //End panel3

        //Start panel4
        public bool panel4Left(int x4, int y4, int x, int x2, int x3)
        {
            if ((x4 <= 400 && y4 <= 338 && x == 96 && x2 == 96 && x3 == 484) || (x4 <= 400 && y4 >= 338 && x == 96 && x3 == 96 && x2 == 484))
            {
                return true;
            }
            else
                return false;
        }
       public bool panel4Right(int x4, int y4, int x, int x2, int x3)
        {
            if (((x4 + 304) >= 484 && y4 <= 338 && x == 484 && x2 == 96 && x3 == 484) || ((x4 + 304) >= 484 && y4 >= 338 && x == 96 && x2 == 484 && x3 == 484))
            {
                return true;
            }
            else
                return false;
        }
       public bool panel4Down(int x4, int y4, int x, int x2, int x3)
       {
           if (((y4 + 108) >= 380 && (x4 + 304) <= 440 && x == 484 && x2 == 96 && x3 == 484) || ((y4 + 108) >= 380 && x4 >= 440 && x == 96 && x2 == 96 && x3 == 484))
           {
               return true;
           }
           else
               return false;
       }
       public bool panel4Up(int x4, int y4, int x, int x2, int x3)
       {
           if ((y4 <= 236 && (x4 + 304) <= 440 && x == 96 && x2 == 484 && x3 == 484) || (y4 <= 236 && x4 >= 440 && x == 96 && x2 == 484 && x3 == 96))
           {
               return true;
           }
           else
               return false;
       }
       public bool panel4CrossUpToLeft(int x4, int y4, int x, int x2, int x3)
       {
           if ((x4 >= 484 && y4 <= 128 && x == 96 && x2 == 484 && x3 == 484) || ((x4 <= 96 && y4 >= 380 && x == 96 && x2 == 96 && x3 == 484)))
           {
               return true;
           }
           else
               return false;
       }
       public bool panel4CrossUpToRight(int x4, int y4, int x, int x2, int x3)
       {
           if ((x4 >= 484 && y4 >= 380 && x == 484 && x2 == 96 && x3 == 484) || ((x4 <= 96 && y4 <= 128 && x == 96 && x2 == 484 && x3 == 96)))
           {
               return true;
           }
           else
               return false;
       }
       //End panel4
    }
        
}

