namespace Perseptron
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMainTable = new System.Windows.Forms.TabPage();
            this.buttonCreateTableMain = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.tabPageLearning = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClass3 = new System.Windows.Forms.Button();
            this.buttonClass2 = new System.Windows.Forms.Button();
            this.buttonClass1 = new System.Windows.Forms.Button();
            this.pictureBoxLearning = new System.Windows.Forms.PictureBox();
            this.buttonOpenLearn = new System.Windows.Forms.Button();
            this.dataGridViewLearning = new System.Windows.Forms.DataGridView();
            this.tabPageD = new System.Windows.Forms.TabPage();
            this.dataGridViewClass1 = new System.Windows.Forms.DataGridView();
            this.tabPageK = new System.Windows.Forms.TabPage();
            this.dataGridViewClass2 = new System.Windows.Forms.DataGridView();
            this.tabPageM = new System.Windows.Forms.TabPage();
            this.dataGridViewClass3 = new System.Windows.Forms.DataGridView();
            this.tabPageRaspoznavanie = new System.Windows.Forms.TabPage();
            this.buttonFullRasponz = new System.Windows.Forms.Button();
            this.pictureBoxRaspozn = new System.Windows.Forms.PictureBox();
            this.buttonRaspozn = new System.Windows.Forms.Button();
            this.dataGridViewRaspozn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageMainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.tabPageLearning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLearning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLearning)).BeginInit();
            this.tabPageD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass1)).BeginInit();
            this.tabPageK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass2)).BeginInit();
            this.tabPageM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass3)).BeginInit();
            this.tabPageRaspoznavanie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaspozn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaspozn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMainTable);
            this.tabControlMain.Controls.Add(this.tabPageLearning);
            this.tabControlMain.Controls.Add(this.tabPageD);
            this.tabControlMain.Controls.Add(this.tabPageK);
            this.tabControlMain.Controls.Add(this.tabPageM);
            this.tabControlMain.Controls.Add(this.tabPageRaspoznavanie);
            this.tabControlMain.Location = new System.Drawing.Point(1, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1087, 758);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMainTable
            // 
            this.tabPageMainTable.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMainTable.Controls.Add(this.buttonCreateTableMain);
            this.tabPageMainTable.Controls.Add(this.dataGridViewMain);
            this.tabPageMainTable.Location = new System.Drawing.Point(4, 25);
            this.tabPageMainTable.Name = "tabPageMainTable";
            this.tabPageMainTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMainTable.Size = new System.Drawing.Size(1079, 729);
            this.tabPageMainTable.TabIndex = 0;
            this.tabPageMainTable.Text = "Основная таблица";
            // 
            // buttonCreateTableMain
            // 
            this.buttonCreateTableMain.Location = new System.Drawing.Point(883, 281);
            this.buttonCreateTableMain.Name = "buttonCreateTableMain";
            this.buttonCreateTableMain.Size = new System.Drawing.Size(190, 146);
            this.buttonCreateTableMain.TabIndex = 1;
            this.buttonCreateTableMain.Text = "Заполнить";
            this.buttonCreateTableMain.UseVisualStyleBackColor = true;
            this.buttonCreateTableMain.Click += new System.EventHandler(this.buttonCreateTableMain_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(4, 20);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 25;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(876, 699);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // tabPageLearning
            // 
            this.tabPageLearning.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLearning.Controls.Add(this.button1);
            this.tabPageLearning.Controls.Add(this.buttonClass3);
            this.tabPageLearning.Controls.Add(this.buttonClass2);
            this.tabPageLearning.Controls.Add(this.buttonClass1);
            this.tabPageLearning.Controls.Add(this.pictureBoxLearning);
            this.tabPageLearning.Controls.Add(this.buttonOpenLearn);
            this.tabPageLearning.Controls.Add(this.dataGridViewLearning);
            this.tabPageLearning.Location = new System.Drawing.Point(4, 25);
            this.tabPageLearning.Name = "tabPageLearning";
            this.tabPageLearning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLearning.Size = new System.Drawing.Size(1079, 729);
            this.tabPageLearning.TabIndex = 1;
            this.tabPageLearning.Text = "Обучение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(916, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClass3
            // 
            this.buttonClass3.Location = new System.Drawing.Point(621, 577);
            this.buttonClass3.Name = "buttonClass3";
            this.buttonClass3.Size = new System.Drawing.Size(452, 142);
            this.buttonClass3.TabIndex = 5;
            this.buttonClass3.Text = "Класс 3";
            this.buttonClass3.UseVisualStyleBackColor = true;
            this.buttonClass3.Click += new System.EventHandler(this.buttonClass3_Click);
            // 
            // buttonClass2
            // 
            this.buttonClass2.Location = new System.Drawing.Point(621, 416);
            this.buttonClass2.Name = "buttonClass2";
            this.buttonClass2.Size = new System.Drawing.Size(452, 142);
            this.buttonClass2.TabIndex = 4;
            this.buttonClass2.Text = "Класс 2";
            this.buttonClass2.UseVisualStyleBackColor = true;
            this.buttonClass2.Click += new System.EventHandler(this.buttonClass2_Click);
            // 
            // buttonClass1
            // 
            this.buttonClass1.Location = new System.Drawing.Point(621, 255);
            this.buttonClass1.Name = "buttonClass1";
            this.buttonClass1.Size = new System.Drawing.Size(453, 142);
            this.buttonClass1.TabIndex = 3;
            this.buttonClass1.Text = "Класс 1";
            this.buttonClass1.UseVisualStyleBackColor = true;
            this.buttonClass1.Click += new System.EventHandler(this.buttonClass1_Click);
            // 
            // pictureBoxLearning
            // 
            this.pictureBoxLearning.Location = new System.Drawing.Point(621, 6);
            this.pictureBoxLearning.Name = "pictureBoxLearning";
            this.pictureBoxLearning.Size = new System.Drawing.Size(197, 220);
            this.pictureBoxLearning.TabIndex = 2;
            this.pictureBoxLearning.TabStop = false;
            // 
            // buttonOpenLearn
            // 
            this.buttonOpenLearn.Location = new System.Drawing.Point(836, 42);
            this.buttonOpenLearn.Name = "buttonOpenLearn";
            this.buttonOpenLearn.Size = new System.Drawing.Size(238, 132);
            this.buttonOpenLearn.TabIndex = 1;
            this.buttonOpenLearn.Text = "Открыть для обучения";
            this.buttonOpenLearn.UseVisualStyleBackColor = true;
            this.buttonOpenLearn.Click += new System.EventHandler(this.buttonOpenLearn_Click);
            // 
            // dataGridViewLearning
            // 
            this.dataGridViewLearning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLearning.Location = new System.Drawing.Point(7, 6);
            this.dataGridViewLearning.Name = "dataGridViewLearning";
            this.dataGridViewLearning.RowHeadersWidth = 51;
            this.dataGridViewLearning.RowTemplate.Height = 24;
            this.dataGridViewLearning.Size = new System.Drawing.Size(591, 713);
            this.dataGridViewLearning.TabIndex = 0;
            // 
            // tabPageD
            // 
            this.tabPageD.Controls.Add(this.dataGridViewClass1);
            this.tabPageD.Location = new System.Drawing.Point(4, 25);
            this.tabPageD.Name = "tabPageD";
            this.tabPageD.Size = new System.Drawing.Size(1079, 729);
            this.tabPageD.TabIndex = 2;
            this.tabPageD.Text = "Класс 1";
            this.tabPageD.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClass1
            // 
            this.dataGridViewClass1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass1.Location = new System.Drawing.Point(7, 3);
            this.dataGridViewClass1.Name = "dataGridViewClass1";
            this.dataGridViewClass1.RowHeadersWidth = 51;
            this.dataGridViewClass1.RowTemplate.Height = 24;
            this.dataGridViewClass1.Size = new System.Drawing.Size(1066, 484);
            this.dataGridViewClass1.TabIndex = 0;
            // 
            // tabPageK
            // 
            this.tabPageK.Controls.Add(this.dataGridViewClass2);
            this.tabPageK.Location = new System.Drawing.Point(4, 25);
            this.tabPageK.Name = "tabPageK";
            this.tabPageK.Size = new System.Drawing.Size(1079, 729);
            this.tabPageK.TabIndex = 3;
            this.tabPageK.Text = "Класс 2";
            this.tabPageK.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClass2
            // 
            this.dataGridViewClass2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass2.Location = new System.Drawing.Point(7, 3);
            this.dataGridViewClass2.Name = "dataGridViewClass2";
            this.dataGridViewClass2.RowHeadersWidth = 51;
            this.dataGridViewClass2.RowTemplate.Height = 24;
            this.dataGridViewClass2.Size = new System.Drawing.Size(1066, 484);
            this.dataGridViewClass2.TabIndex = 1;
            // 
            // tabPageM
            // 
            this.tabPageM.Controls.Add(this.dataGridViewClass3);
            this.tabPageM.Location = new System.Drawing.Point(4, 25);
            this.tabPageM.Name = "tabPageM";
            this.tabPageM.Size = new System.Drawing.Size(1079, 729);
            this.tabPageM.TabIndex = 4;
            this.tabPageM.Text = "Класс 3";
            this.tabPageM.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClass3
            // 
            this.dataGridViewClass3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass3.Location = new System.Drawing.Point(7, 3);
            this.dataGridViewClass3.Name = "dataGridViewClass3";
            this.dataGridViewClass3.RowHeadersWidth = 51;
            this.dataGridViewClass3.RowTemplate.Height = 24;
            this.dataGridViewClass3.Size = new System.Drawing.Size(1066, 484);
            this.dataGridViewClass3.TabIndex = 1;
            // 
            // tabPageRaspoznavanie
            // 
            this.tabPageRaspoznavanie.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRaspoznavanie.Controls.Add(this.label2);
            this.tabPageRaspoznavanie.Controls.Add(this.label1);
            this.tabPageRaspoznavanie.Controls.Add(this.buttonFullRasponz);
            this.tabPageRaspoznavanie.Controls.Add(this.pictureBoxRaspozn);
            this.tabPageRaspoznavanie.Controls.Add(this.buttonRaspozn);
            this.tabPageRaspoznavanie.Controls.Add(this.dataGridViewRaspozn);
            this.tabPageRaspoznavanie.Location = new System.Drawing.Point(4, 25);
            this.tabPageRaspoznavanie.Name = "tabPageRaspoznavanie";
            this.tabPageRaspoznavanie.Size = new System.Drawing.Size(1079, 729);
            this.tabPageRaspoznavanie.TabIndex = 5;
            this.tabPageRaspoznavanie.Text = "Распознавание";
            // 
            // buttonFullRasponz
            // 
            this.buttonFullRasponz.Location = new System.Drawing.Point(621, 587);
            this.buttonFullRasponz.Name = "buttonFullRasponz";
            this.buttonFullRasponz.Size = new System.Drawing.Size(453, 132);
            this.buttonFullRasponz.TabIndex = 5;
            this.buttonFullRasponz.Text = "Распознавание";
            this.buttonFullRasponz.UseVisualStyleBackColor = true;
            this.buttonFullRasponz.Click += new System.EventHandler(this.buttonFullRasponz_Click);
            // 
            // pictureBoxRaspozn
            // 
            this.pictureBoxRaspozn.Location = new System.Drawing.Point(621, 21);
            this.pictureBoxRaspozn.Name = "pictureBoxRaspozn";
            this.pictureBoxRaspozn.Size = new System.Drawing.Size(197, 220);
            this.pictureBoxRaspozn.TabIndex = 4;
            this.pictureBoxRaspozn.TabStop = false;
            // 
            // buttonRaspozn
            // 
            this.buttonRaspozn.Location = new System.Drawing.Point(836, 57);
            this.buttonRaspozn.Name = "buttonRaspozn";
            this.buttonRaspozn.Size = new System.Drawing.Size(238, 132);
            this.buttonRaspozn.TabIndex = 3;
            this.buttonRaspozn.Text = "Открыть для распознавания";
            this.buttonRaspozn.UseVisualStyleBackColor = true;
            this.buttonRaspozn.Click += new System.EventHandler(this.buttonRaspozn_Click);
            // 
            // dataGridViewRaspozn
            // 
            this.dataGridViewRaspozn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaspozn.Location = new System.Drawing.Point(7, 6);
            this.dataGridViewRaspozn.Name = "dataGridViewRaspozn";
            this.dataGridViewRaspozn.RowHeadersWidth = 10;
            this.dataGridViewRaspozn.RowTemplate.Height = 24;
            this.dataGridViewRaspozn.Size = new System.Drawing.Size(591, 713);
            this.dataGridViewRaspozn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(657, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Класс: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(794, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 135);
            this.label2.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 758);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMainTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.tabPageLearning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLearning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLearning)).EndInit();
            this.tabPageD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass1)).EndInit();
            this.tabPageK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass2)).EndInit();
            this.tabPageM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass3)).EndInit();
            this.tabPageRaspoznavanie.ResumeLayout(false);
            this.tabPageRaspoznavanie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaspozn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaspozn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMainTable;
        private System.Windows.Forms.TabPage tabPageLearning;
        private System.Windows.Forms.TabPage tabPageD;
        private System.Windows.Forms.TabPage tabPageK;
        private System.Windows.Forms.TabPage tabPageM;
        private System.Windows.Forms.TabPage tabPageRaspoznavanie;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonClass3;
        private System.Windows.Forms.Button buttonClass2;
        private System.Windows.Forms.Button buttonClass1;
        private System.Windows.Forms.PictureBox pictureBoxLearning;
        private System.Windows.Forms.Button buttonOpenLearn;
        private System.Windows.Forms.DataGridView dataGridViewLearning;
        private System.Windows.Forms.Button buttonCreateTableMain;
        private System.Windows.Forms.DataGridView dataGridViewClass1;
        private System.Windows.Forms.DataGridView dataGridViewClass2;
        private System.Windows.Forms.DataGridView dataGridViewClass3;
        private System.Windows.Forms.Button buttonFullRasponz;
        private System.Windows.Forms.PictureBox pictureBoxRaspozn;
        private System.Windows.Forms.Button buttonRaspozn;
        private System.Windows.Forms.DataGridView dataGridViewRaspozn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

