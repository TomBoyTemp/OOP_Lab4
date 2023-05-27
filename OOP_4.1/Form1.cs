using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_4._1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}

		//int coord_x, coord_y;//Переменные для сохранения координат
		Boolean checkCtrl = false;// Переменная для проверки нажатия ctrl
		List<CCircle> circles = new List<CCircle>(0); //Контейнер

		private void Form1_KeyDown(object sender, KeyEventArgs e)//Проверяем нажатие кнопок
		{
			if (e.KeyCode == Keys.ControlKey)
			{
				checkCtrl = true;
			}
		}

		private void chckBxCtrl_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void PaintBox_MouseClick(object sender, MouseEventArgs e)//Рисуем круги
		{
			if (e.Button == MouseButtons.Right)//Правой рисуем
			{
				for (int i = 0; i < circles.Count; i++)//но проверяем на уже существующий круг в данной координате
				{
					if (circles[i].Equal(e.X, e.Y))
					{
						return;
					}
				}
				for (int i = 0; i < circles.Count; i++)//При создании нового круга, делаем другие круги невыделенными
				{
					circles[i].Unselect();
				}
				CCircle tmp = new CCircle(e.X, e.Y);//Если удалось создать то создаемый как выбранный и сохраняем в контейнере
				tmp.Select();
				circles.Add(tmp);
			}
			else if (e.Button == MouseButtons.Left && circles.Count > 0)//Левой выделаем
			{
				if (checkCtrl || chckBxCtrl.Checked)//Проверяем наличие нажатия кнтрл или чекбокса
				{
					//select
					if (chckBxMode.Checked)//Если чекбокс  то выбираем выделяем все кргуи попавшие в координату клика
					{
						for (int i = 0; i < circles.Count; i++)
						{
							if (circles[i].Poss(e.X, e.Y))
							{
								circles[i].Select();
							}
						}
					}
					else
					{
						for (int i = 0; i < circles.Count; i++)//Иначе выбираем верхний
						{
							if (circles[i].Poss(e.X, e.Y))
							{
								circles[i].Select();
								break;
							}
						}
					}
				}
				else
				{
					Boolean lastSelected = true;
					//unselect
					for (int i = 0; i < circles.Count; i++)//иначе просто выделяем единственный попавший в координату клика, остальные делаем не выбранные
					{
						circles[i].Unselect();
					}
					//select
					if (chckBxMode.Checked)
					{
						for (int i = 0; i < circles.Count; i++)
						{
							if (circles[i].Poss(e.X, e.Y))
							{
								circles[i].Select();
								lastSelected = false;
							}
						}
					}
					else
					{
						for (int i = circles.Count - 1; i >=  0; i--)
						{
							if (circles[i].Poss(e.X, e.Y))
							{
								circles[i].Select();
								lastSelected = false;
								break;
							}
						}
						
					}
					if (lastSelected)
					{
						circles[circles.Count - 1].Select();
					}
				}
			}
			PaintBox.Invalidate();
		}

		private void PaintBox_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			for (int i = 0; i < circles.Count; i++)
			{
				circles[i].Paint(g);
			}
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.ControlKey)
			{
				checkCtrl = false;
			}
			else if (e.KeyCode == Keys.Delete)
			{
				for (int i = 0; i < circles.Count; ++i)
				{
					if (circles[i].Selected())
					{
						circles.RemoveAt(i--);
					}
				}
				if (circles.Count > 0)
				{
					circles[circles.Count - 1].Select();
				}
				PaintBox.Invalidate();
			}
		}

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
			this.Close();
		}

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
			viewController newForm = new viewController();
			newForm.Show();
		}
    }
}
