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
	internal class CCircle
	{
		private bool selected;//Переменная для понимания, выделен ли круг
		private int coord_X, coord_Y;//Кординаты circle
		private const int R = 50;//Радиус круга
		private const int sqRad = R*R;//Бокс круга
		public CCircle(int x, int y)
		{
			this.coord_X = x;
			this.coord_Y = y;
		}
		public Boolean Equal(int x, int y)//Проверка координат
		{
			return (x == this.coord_X) && (y == this.coord_Y);
		}
		public Boolean Poss(int x, int y)//Проверка на попадния кликом мышки в бокс круга
		{
			return (Math.Pow(this.coord_X - x, 2) + Math.Pow(this.coord_Y - y, 2) <= sqRad);
		}
		public void Paint(Graphics g)//Отрисовываем круги в соответсвующий цвет, в зависимости от выбранности 
		{
			if (selected)
			{
				g.FillEllipse(Brushes.Blue, coord_X - R, coord_Y - R, 2 * R, 2 * R);//Выбран, рисуем синим
			}
			else
			{
				g.FillEllipse(Brushes.Black, coord_X - R, coord_Y - R, 2 * R, 2 * R);//Иначе - черным
			}
		}
		public void Select()//Установка выбранности 
		{
			selected = true;
		}
		public void Unselect()//Установка невыбранности 
		{
			selected = false;
		}
		public Boolean Selected()//Проверка выбранности
		{
			return selected;
		}
	}
}
