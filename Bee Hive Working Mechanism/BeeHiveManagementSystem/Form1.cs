using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManagementSystem
{
    public partial class Form1 : Form
    {
        private Queen queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;

            Worker[] workers = new Worker[4];

            workers[0] = new Worker(new string[] { "Сбор нектара", "Создание меда" });
            workers[1] = new Worker(new string[] { "Забота о яйцах", "Обучение родившихся пчел" });
            workers[2] = new Worker(new string[] { "Обслуживание улья", "Патрулирование" });
            workers[3] = new Worker(new string[] { "Сбор нектара", "Создание меда", "Забота о яйцах", "Обучение родившихся пчел", "Обслуживание улья", "Патрулирование" });
           
            queen = new Queen(workers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
                MessageBox.Show("Для задания  " + workerBeeJob.Text + " рабочих нет, говорит королева");
            else
                MessageBox.Show("Задание " + workerBeeJob.Text + " будет окончено через " + shifts.Value + " смен, говорит королева");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = queen.WorkTheNextShift();
        }
    }
}
