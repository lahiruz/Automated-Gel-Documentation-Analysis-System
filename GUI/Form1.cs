using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GelWrapper;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GelWrapper.Wrapper wrap=new GelWrapper.Wrapper();
            //wrap.wrapExecute();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string FilePath = opd.FileName;

                if (!backgroundWorker2.IsBusy)
                {          
                    backgroundWorker2.RunWorkerAsync(FilePath);
                }


            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = (string)e.Argument;           
            GelWrapper.Wrapper wrap = new GelWrapper.Wrapper();
            wrap.wrapExecute(path);
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // handle the error
            }
            else if (e.Cancelled)
            {
                // handle cancellation
            }
            else
            {                

            }
        }



    }
}