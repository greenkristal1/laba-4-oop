using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_4_oop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Storage st = new Storage(100);
        Graphics gr;


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (st.countRealObjects() != 0)
            {
                for(int i = 0; i < st.countRealObjects(); i++)
                {
                    gr.DrawEllipse(Pens.White, (st.getObject(i) as Circle).LX, (st.getObject(i) as Circle).LY, (st.getObject(i) as Circle).Radius, (st.getObject(i) as Circle).Radius);
                }
                for (int i = 0; i < st.countRealObjects(); i++)
                {
                    int x = ((st.getObject(i) as Circle).LX);
                    int y = ((st.getObject(i) as Circle).LY);
                    if ((e.X >= x && e.X <= x + 50) && (e.Y >= y && e.Y <= y + 50))
                    {
                        gr.DrawEllipse(Pens.Blue, (st.getObject(i) as Circle).LX, (st.getObject(i) as Circle).LY, (st.getObject(i) as Circle).Radius, (st.getObject(i) as Circle).Radius);
                        return;
                    }
                }
            }
                st.setObject(st.countRealObjects(), new Circle(50, e.X -25 , e.Y - 25));
            this.Refresh();
            
            

        }

        private void PrintFigures(object sender, PaintEventArgs e)
        {

            gr = CreateGraphics();

            if (st.countRealObjects() != 0)
            {
                for (int i = 0; i < st.countRealObjects(); i++)
                {
                    gr.FillEllipse(Brushes.Red, (st.getObject(i) as Circle).LX, (st.getObject(i) as Circle).LY, (st.getObject(i) as Circle).Radius, (st.getObject(i) as Circle).Radius);
                    }

                gr.DrawEllipse(Pens.Blue, (st.getObject(st.countRealObjects()-1) as Circle).LX, (st.getObject(st.countRealObjects() - 1) as Circle).LY, (st.getObject(st.countRealObjects() - 1) as Circle).Radius, (st.getObject(st.countRealObjects() - 1) as Circle).Radius);
            }
            
        }
    
        }
    }

