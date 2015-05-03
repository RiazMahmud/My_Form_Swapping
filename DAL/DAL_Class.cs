using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DAL_Class
    {
        public void soundPlay()
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = "C:\\Sound1\\Baseball Bat Swing-SoundBible.com-1511319491.wav";

                player.Load();
                player.Play();
            }
            catch (Win32Exception ex)
            {
            }
        }
    }
}
