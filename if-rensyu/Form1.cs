using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



 

namespace if_rensyu
{
    public partial class Form1 : Form
    {
        int vx = 25;
        int vy = 25;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -vx;
            vy = -vy;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

         if (button1.Left <= 0)
         {
             vx = -vx;
         }
         else if(button1.Left >= ClientSize.Width - 200)
         {
             vx = -vx;
         }
         if (button1.Top <= 0)
         {
             vy = -vy;
         }
         else if (button1.Top >= ClientSize.Height - 170)
         {
             vy = -vy;
         }
         button1.Left = button1.Left + vx;
         button1.Top = button1.Top + vy;
        }
        
    }
}
