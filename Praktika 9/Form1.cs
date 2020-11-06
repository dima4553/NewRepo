using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_9
{
  public partial class Form1 : Form
  {
    Random rnd = new Random();
    Point tmp_location;
    int _w = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
    int _h = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
      /*Переводим координату Х в строку и записывает в поля в поля ввода*/
      textBox1.Text = e.X.ToString();
      /*Переводим координату Y в строку и записывает в поля ввода*/
      textBox2.Text = e.Y.ToString();

      /*если координата по оси Х и по оси У лежит в очерчиваемом вокруг кнопки "да, конечно"*/
      if (e.X > 80 && e.X < 195 && e.Y > 100 && e.Y < 135)
      {
        /*запоминаем текущее положение окна*/
        tmp_location = this.Location;

        /*генерируем перемещения по осям Х и У и прибавляем их к хранимому значению текущего положеня окна
         числа генерируются в диапазоне от -100 до 100*/
        tmp_location.X += rnd.Next(-150, 150);
        tmp_location.Y += rnd.Next(-150, 150);

        /*если окно вылезло за пределы экрана по одной из осей*/
        if (tmp_location.X < 0 || tmp_location.X > (_w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (_h - this.Height / 2))
        {
          /*новыми координатами станет центр окна*/
          tmp_location.X = _w / 2;
          tmp_location.Y = _h / 2;
        }

        /*объявляем положение окна, на новое сгенерированное*/
        this.Location = tmp_location;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      /*Вывести сообщение с текстом*/
      MessageBox.Show("Вы усердны!!!");
      /*Завершить приложение*/
      Application.Exit();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      /*Вывести сообщение, с текстом "Мы не сомневались в вашем безразличии"
       второй параметр - заголовок окна сообщения "Внимание"
       MessageBoxIcon.Information - тип сообщения - будет иметь иконку "информация" и соответсвующий звуковой сигнал*/
      MessageBox.Show("Мы не сомневались в вашем безразличии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

  }
}
