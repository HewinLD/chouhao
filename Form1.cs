using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int 人数;
        ArrayList 数组 = new ArrayList();
        ArrayList 抽组 = new ArrayList();
        private void Form1_Load(object sender, EventArgs e)
        {
            人数 = 45;
            for (int i = 1; i <= 人数; i++)
                数组.Add(i);
            抽组 = new ArrayList(数组);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = new Random().Next(0, 抽组.Count);
            button1.Text = 抽组[i].ToString();
            抽组.RemoveAt(i);
            if (抽组.Count == 0)
                抽组 = new ArrayList(数组);
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
