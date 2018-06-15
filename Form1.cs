using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ensyu0608
{
    public partial class Form1 : Form
    {
        // const = 定数　/　初期化のみできて、実行中に変更できない
        const int LABEL_COUNT = 25;

        private static Random rand = new Random();
        int[] vx = new int[LABEL_COUNT];
        int[] vy = new int[LABEL_COUNT];
        //int vx1, vy1;
        //int vx2, vy2;
        //int vx3, vy3;

        Label[] labels = new Label[100];

        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < LABEL_COUNT; i++)
            {
                // 1
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (labels[i].Left > ClientSize.Width - labels[i].Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (labels[i].Top > ClientSize.Height - labels[i].Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                Point cpos;
                cpos = MousePosition;
                cpos = PointToClient(cpos);


               
            }

            /*// 2
            label2.Left += vx[1];
            label2.Top += vy[1];

            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            if (label2.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            if (label2.Left > ClientSize.Width - label2.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label2.Top > ClientSize.Height - label2.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }

            // 3
            label3.Left += vx[2];
            label3.Top += vy[2];

            if (label3.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label3.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            if (label3.Left > ClientSize.Width - label3.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label3.Top > ClientSize.Height - label3.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }*/

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < LABEL_COUNT; i++)
            {
             labels[i] = new Label();
             labels[i].AutoSize = true;
             labels[i].Text = "◆";
             Controls.Add(labels[i]);
             labels[i].Font = label1.Font;
             labels[i].ForeColor = label1.ForeColor;

             labels[i].Left = rand.Next(0, ClientSize.Width - labels[i].Width);
             labels[i].Top = rand.Next(0, ClientSize.Height - labels[i].Height);
             vx[i] = rand.Next(-10, 11);
             vy[i] = rand.Next(-10, 11);
            }
            /*
            // 1
            label1.Left = rand.Next(0, ClientSize.Width - label1.Width);
            label1.Top = rand.Next(0, ClientSize.Height - label1.Height);
            vx[0] = rand.Next(-10, 11);
            vy[0] = rand.Next(-10, 11);

            // 2
            label2.Left = rand.Next(0, ClientSize.Width - label2.Width);
            label2.Top = rand.Next(0, ClientSize.Height - label2.Height);
            vx[1] = rand.Next(-10, 11);
            vy[1] = rand.Next(-10, 11);

            // 3
            label3.Left = rand.Next(0, ClientSize.Width - label3.Width);
            label3.Top = rand.Next(0, ClientSize.Height - label3.Height);
            vx[2] = rand.Next(-10, 11);
            vy[2] = rand.Next(-10, 11);
             */

        }
    }
}
