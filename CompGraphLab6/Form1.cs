using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CompGraphLab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Задаем серебряный цвет для города
            SolidBrush myCity = new SolidBrush(Color.Silver);
            // Задаем желтый и оранжевый цвет для пламени
            SolidBrush mySun = new SolidBrush(Color.Yellow);
            // Задаем белый для облачка
            SolidBrush myCloud = new SolidBrush(Color.White);

            // Бахнул городецкий
            g.FillRectangle(myCity, 10, 300, 20, 30);
            g.FillRectangle(myCity, 50, 300, 20, 60);
            g.FillRectangle(myCity, 80, 300, 20, 40);
            g.FillRectangle(myCity, 120, 300, 20, 70);
            g.FillRectangle(myCity, 150, 300, 20, 30);
            g.FillRectangle(myCity, 200, 300, 20, 30);
            g.FillRectangle(myCity, 250, 300, 20, 60);
            g.FillRectangle(myCity, 280, 300, 20, 40);
            g.FillRectangle(myCity, 320, 300, 20, 70);
            g.FillRectangle(myCity, 350, 300, 20, 30);
            g.FillRectangle(myCity, 10, 400, 20, 30);
            g.FillRectangle(myCity, 50, 400, 20, 60);
            g.FillRectangle(myCity, 80, 400, 20, 40);
            g.FillRectangle(myCity, 120, 400, 20, 70);
            g.FillRectangle(myCity, 150, 400, 20, 30);
            g.FillRectangle(myCity, 200, 400, 20, 30);
            g.FillRectangle(myCity, 250, 400, 20, 60);
            g.FillRectangle(myCity, 280, 400, 20, 40);
            g.FillRectangle(myCity, 320, 400, 20, 70);
            g.FillRectangle(myCity, 350, 400, 20, 30);

            // Рисуем солнце
            g.FillEllipse(mySun, 10, 10, 70, 70);
            g.DrawEllipse(Pens.Yellow, 10, 10, 70, 70);
            
            //Рисуем облачко
            g.FillEllipse(myCloud, 30, 10, 70, 30);
        }
    
    }
}
