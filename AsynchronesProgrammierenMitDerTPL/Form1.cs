using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronesProgrammierenMitDerTPL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonThread_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(MachEtwasLangsam);
            Thread t2 = new Thread(MachEtwasSchnell);

            t1.Start();
            t2.Start();
        }

        private void MachEtwasSchnell()
        {
            for (int i = 0; i < 100; i++)
            {

            }
        }

        private void MachEtwasLangsam()
        {
            for (int i = 0; i < 100; i++)
            {
                progressBarSchnell.Value = i;
                Thread.Sleep(1000);
            }
        }
    }
}
