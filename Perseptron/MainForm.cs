using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perseptron
{
    public partial class MainForm : Form
    {
        double class1Select = 0, class2Select = 0, class3Select = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreateTableMain_Click(object sender, EventArgs e)
        {
            Controller.CreateDataMain(dataGridViewMain);
            Controller.ChangeLamda(dataGridViewMain, dataGridViewClass1);
            Controller.ChangeLamda(dataGridViewMain, dataGridViewClass2);
            Controller.ChangeLamda(dataGridViewMain, dataGridViewClass3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            class1Select = class1Select / 3;
            class2Select = class2Select / 3;
            class3Select = class3Select / 3;
        }

        private void buttonOpenLearn_Click(object sender, EventArgs e)
        {
            dataGridViewLearning.Rows.Clear();
            dataGridViewLearning.Columns.Clear();
            Controller.CreateDataLearning(dataGridViewLearning, pictureBoxLearning);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Controller.CreateLamdaStart(dataGridViewClass1);
            Controller.CreateLamdaStart(dataGridViewClass2);
            Controller.CreateLamdaStart(dataGridViewClass3);
        }

        private void buttonRaspozn_Click(object sender, EventArgs e)
        {
            dataGridViewRaspozn.Rows.Clear();
            dataGridViewRaspozn.Columns.Clear();
            Controller.CreateDataLearning(dataGridViewRaspozn, pictureBoxRaspozn);
        }

        private void buttonClass1_Click(object sender, EventArgs e)
        {
            class1Select += Controller.classSelect(dataGridViewLearning, dataGridViewClass1);
        }

        private void buttonFullRasponz_Click(object sender, EventArgs e)
        {
            Controller.Raspoznavanie(dataGridViewRaspozn, dataGridViewClass1, label1, label2, class1Select, class2Select, class3Select);
        }

        private void buttonClass2_Click(object sender, EventArgs e)
        {
            class2Select += Controller.classSelect(dataGridViewLearning, dataGridViewClass2);
        }

        private void buttonClass3_Click(object sender, EventArgs e)
        {
            class3Select += Controller.classSelect(dataGridViewLearning, dataGridViewClass3);
        }
    }
}
