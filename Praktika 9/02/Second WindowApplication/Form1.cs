using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_WindowApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Создаём переменную rsl, которая будет хранить результат вывода окна с вопросом*/
            DialogResult rsl = MessageBox.Show("Вы действительно хотите выйти из приложения?", "Внимание!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            /*если да, выходим*/
            if (rsl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /*JPG*/
        private void вФорматеJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage(true);
        }

        /*PNG*/
        private void вФорматеPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage(false);
        }

        /*PNG*/
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LoadImage(true);
        }

        /*JPG*/
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LoadImage(false);
        }

        Image MemForImage;
        /*метод загрузки изображения*/
        private void LoadImage(bool jpg)
        {
            openFileDialog1.InitialDirectory = "c:";  //начальная директория
            if (jpg)
            {
                openFileDialog1.Filter = "image (JPEG) files (*.jpg) |*.jpg|All files (*.*|*.*)";
            }
            else
            {
                openFileDialog1.Filter = "image (PNG) files (*.png) |*.png|All files (*.*)|*.*";
            }

            /*если выбрали файл и нажали ОК*/
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MemForImage = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = MemForImage;     //устанавливаем картинку в поле эл-та
                }
                catch (Exception ex)            //если загрузка не удалась
                {
                    MessageBox.Show("Не удалось загрузить файл: " + ex.Message);
                }
            }
        }

        /*Кнопка активации доп. диалогового окна*/
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form PreView = new Preview(MemForImage);
            PreView.ShowDialog();
        }
    }
}
