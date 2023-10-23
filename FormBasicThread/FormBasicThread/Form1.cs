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

namespace FormBasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Console.WriteLine("-Thread Starts-");
            ThreadStart delThread1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart delThread2 = new ThreadStart(MyThreadClass.Thread2);


            Thread threadA = new Thread(delThread1);
            threadA.Name = "Thread A Process";
            Thread threadB = new Thread(delThread2);
            threadB.Name = "Thread B Process";
            Thread threadC = new Thread(delThread1);
            threadC.Name = "Thread C Process";
            Thread threadD = new Thread(delThread2);
            threadD.Name = "Thread D Process";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;  


            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End of Threads-");
            label1.Text = "- End of Threads -";

        }
    }
}



