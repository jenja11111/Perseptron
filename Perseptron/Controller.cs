using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perseptron
{
    public static class Controller
    {
        private static Random random = new Random();
        private static int value = random.Next(0, 449);
        // Бесполезный класс, можн опридумать лучше
        private static int[] class123 = new int[450];

        // Основная таблица
        public static void CreateDataMain(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            for (int i = 0; i < 450; i++)
            {
                dataGridView.Columns.Add("A" + (int)(i + 1), "A" + (int)(i + 1));
            }
            for (int i = 0; i < 4900; i++)
            {
                dataGridView.RowHeadersVisible = true;
                dataGridView.Rows.Add();
                dataGridView.Rows[i].HeaderCell.Value = ("X" + (int)(i + 1)).ToString();
            }
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (i == j)
                        dataGridView.Rows[i].Cells[j].Value = 1;
                    else
                        dataGridView.Rows[i].Cells[j].Value = 0;
                }
                if (i > dataGridView.Columns.Count && i < 2500)
                {
                    dataGridView.Rows[i].Cells[value].Value = -1;
                    value = random.Next(0, 449);
                }
                if (i > 2500 && i < dataGridView.Rows.Count)
                {
                    dataGridView.Rows[i].Cells[value].Value = 1;
                    value = random.Next(0, 449);
                }
            }
            dataGridView.RowHeadersVisible = true;
            dataGridView.Rows.Add();
            int sum = 0;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < dataGridView.Rows.Count - 2; j++)
                {
                    sum += (int)dataGridView.Rows[j].Cells[i].Value;                    
                }
                if(sum >= 4)
                {
                    dataGridView.Rows[dataGridView.Rows.Count - 2].Cells[i].Value = sum;
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[i].Value = 1;
                }
                else
                {
                    dataGridView.Rows[dataGridView.Rows.Count - 2].Cells[i].Value = sum;
                    dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[i].Value = 0;
                }
            }
        }

        // Таблица для обучения и распознования
        public static void CreateDataLearning(DataGridView dataGridView, PictureBox pictureBox)
        {            
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox.Image = Image.FromFile(ofd.FileName);
            Bitmap img = (Bitmap)Image.FromFile(ofd.FileName);
            int[,] array = new int[img.Height, img.Width];
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    if (img.GetPixel(j, i) == Color.FromArgb(255, 0, 0, 0)) array[i, j] = 1;
                    else array[i, j] = 0;
                }
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            for (int i = 0; i < img.Width; i++)
            {
                dataGridView.Columns.Add("",((int)(i+1)).ToString());
            }
            for (int i = 0; i < img.Height; i++)
            {
                dataGridView.Rows.Add();
            }

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = array[i,j];
                }
            }

            dataGridView.Rows.Add();
            int sum = 0;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                sum = 0;
                for (int j = 0; j < dataGridView.Rows.Count - 2; j++)
                {
                    sum += (int)dataGridView.Rows[j].Cells[i].Value;
                }
                dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[i].Value = sum;
            }

        }

        // Запись всех 1 в лямда 3 классов
        public static void CreateLamdaStart(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            for (int i = 0; i < 450; i++)
            {
                dataGridView.Columns.Add("", ((int)(i + 1)).ToString());
            }
                dataGridView.Rows.Add();
            for (int i = 0; i < 450; i++)
            {
                 dataGridView.Rows[0].Cells[i].Value = 1;
            }
        }

        // С этого момента какая-то белеберда
        public static void ChangeLamda(DataGridView dataGridViewMain, DataGridView dataGridViewClass)
        {
            for (int i = 0; i < 450; i++)
            {
                if((int)dataGridViewMain.Rows[4901].Cells[i].Value == 1)
                {
                    dataGridViewClass.Rows[0].Cells[i].Value = 1;
                }
                else
                {
                    dataGridViewClass.Rows[0].Cells[i].Value = 0;
                }    
            }

        }
        
        // Никому не нужное умножение
        private static int[] Multiplication(DataGridView dataGridViewLearning, DataGridView dataGridViewClass)
        {
            int[] multi = new int[470];

            for (int i = 0; i < 70; i++)
            {
                multi[i] = (int)dataGridViewClass.Rows[0].Cells[i].Value * (int)dataGridViewLearning.Rows[dataGridViewLearning.Rows.Count - 1].Cells[i].Value;
            }

            return multi;
        }

        // Выбор через суммы элементов и их среднего арифметического
        public static double classSelect(DataGridView dataGridViewLearning, DataGridView dataGridViewClass)
        {
            double classSelect = 0;
            class123 = Multiplication(dataGridViewLearning, dataGridViewClass);

            for (int i = 0; i < 70; i++)
            {
                classSelect += class123[i];
            }
            classSelect = classSelect / 70;

            return classSelect;
        }

        // Имитация
        public static void Raspoznavanie(DataGridView dataGridViewRaspozn, DataGridView dataGridViewClass, Label label, Label label1, double class1,double class2, double class3)
        {
            double classSelect = 0;
            class123 = Multiplication(dataGridViewRaspozn, dataGridViewClass);
            for (int i = 0; i < 70; i++)
            {
                classSelect += class123[i];
            }
            classSelect = classSelect / 70;
            switch ((int)classSelect)
            {
                case 1:
                    label.Text = "Класс: 2";
                    label1.Text = "К";
                    break;
                case 2:
                    if ((int)class2 == 2)
                    {
                        label.Text = "Класс: 2";
                        label1.Text = "К";
                    }
                    else
                    {
                        label.Text = "Класс: 3";
                        label1.Text = "М";
                    }
                    break;
                case 3:
                    if ((int)class3 == 3)
                    {
                        label.Text = "Класс: 3";
                        label1.Text = "М";
                    }
                    else
                    {
                        label.Text = "Класс: 1";
                        label1.Text = "Д";
                    }
                    break;
                case 4:
                    if ((int)class1 == 4)
                    {
                        label.Text = "Класс: 1";
                        label1.Text = "Д";
                    }
                    else
                    {
                        label.Text = "Класс: 3";
                        label1.Text = "М";
                    }
                    break;
                case 5:
                    label.Text = "Класс: 3";
                    label1.Text = "М";
                    break;                
            }

        }
    }
}
