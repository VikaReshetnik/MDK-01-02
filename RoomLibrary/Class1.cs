using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength; //длина комнтаы
        double roomWidth; //ширина комнтаы
        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// Метод вычисляет перимитр комнаты
        /// </summary>
        /// <returns></returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }
        /// <summary>
        /// Метод вычисляет площадь комнаты
        /// </summary>
        /// <returns></returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        /// Метод вычисляет число квадратных метров
        /// на одного человека
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>Возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }

}