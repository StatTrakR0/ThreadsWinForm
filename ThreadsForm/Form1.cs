using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Max(object ara)
        {
            int[] arr = (int[])ara;
            txtFirstThread.Invoke((MethodInvoker)delegate {
                pBar1.Visible = true;
                pBar1.Value = 0;
                pBar1.Maximum = arr.Length;
                pBar1.Step = 1;
            });

            int value = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (value < arr[i])
                {
                    value = arr[i];
                }
                txtFirstThread.Invoke((MethodInvoker)delegate { pBar1.PerformStep();
                    Thread.Sleep(100);
                }); 
            }
            txtFirstThread.Invoke((MethodInvoker)delegate { txtFirstThread.Text = Convert.ToString(value); });
            
        }
        private void Avg(object ara)
        {
            int[] arr = (int[])ara;
            txtSecondThread.Invoke((MethodInvoker)delegate {
                pBar2.Visible = true;
                pBar2.Maximum = arr.Length;
                pBar2.Value = 0;
                pBar2.Step = 1;
            });
            int value = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                value += arr[i];
                txtSecondThread.Invoke((MethodInvoker)delegate { pBar2.PerformStep();
                    Thread.Sleep(100);
                });
            }
            value = value / 9;
            txtSecondThread.Invoke((MethodInvoker)delegate { txtSecondThread.Text = Convert.ToString(value); });
        }
        private void Min(object ara)
        {

            
            int[] arr = (int[])ara;
            txtThirdThread.Invoke((MethodInvoker)delegate {
                pBar3.Visible = true;
                pBar3.Maximum = arr.Length;
                pBar3.Value = 0;
                pBar3.Step = 1;
            });
            int value = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (value > arr[i])
                {
                    value = arr[i];
                }
                txtThirdThread.Invoke((MethodInvoker)delegate {
                    Thread.Sleep(100);
                    pBar3.PerformStep();

                });
            }
            txtThirdThread.Invoke((MethodInvoker)delegate { txtThirdThread.Text = Convert.ToString(value); });
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for(int i = 0; i  <arr.Length;i++)
            {
                arr[i] = rnd.Next(-200,200);
            }
            if(CheckMax.Checked)
            {
                Thread t1 = new Thread(new ParameterizedThreadStart(Max));
                t1.Start(arr);
            }
            else
            {
                txtFirstThread.Text = "";
                pBar1.Value = 0;
            }

            if(CheckAvg.Checked)
            {
                Thread t2 = new Thread(new ParameterizedThreadStart(Avg));
                t2.Start(arr);
            }
            else
            {
                txtSecondThread.Text = "";
                pBar2.Value = 0;
            }

            if(CheckMin.Checked)
            {
                Thread t3 = new Thread(new ParameterizedThreadStart(Min));
                t3.Start(arr);
            }
            else
            {
                txtThirdThread.Text = "";
                pBar3.Value = 0;
            }
        }

        private void grpBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
