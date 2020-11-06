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
    public partial class Preview : Form
    {
        Image ToView;
        public Preview(Image view)
        {
            ToView = view;
            InitializeComponent();
        }

        private void Preview_Load(object sender, EventArgs e)
        {
            if (ToView != null)
            {
                pictureBox1.Size = new Size(ToView.Width, ToView.Height);
                pictureBox1.Image = ToView;
            }
        }

        /*Кнопка Закрыть*/
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
