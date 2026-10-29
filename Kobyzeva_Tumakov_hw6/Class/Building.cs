namespace Kobyzeva_Tumakov_hw6.Class
{
    /// <summary>
    /// Здания с методами для расчета его параметров
    /// </summary>
    public class Building
    {
        private static int number0 = 0;
        private int number;
        private float high;
        private byte floors;
        private int apartaments;
        private byte entrances;

        public float High
        {
            get { return high; }
            set { high = value; }
        }
        public byte Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public int Apartaments
        {
            get { return apartaments; }
            set { apartaments = value; }
        }
        public byte Entrances
        {
            get { return entrances; }
            set { entrances = value; }
        }

        /// <summary>
        /// Инициализирует экземпляр класса и присваивает ему уникальный порядковый номер
        /// </summary>
        /// <param name="high">Высота здания</param>
        /// <param name="floors">Количество этажей</param>
        /// <param name="apartaments">Количество квартир</param>
        /// <param name="entrances">Количество подъездов</param>
        public Building(float high, byte floors, int apartaments, byte entrances)
        {
            number0++;
            number = number0;
            High = high;
            Floors = floors;
            Apartaments = apartaments;
            Entrances = entrances;
        }

        /// <summary>
        /// Вывод информации о здании в консоль
        /// </summary>
        public void PrintOnConsole()
        {
            Console.WriteLine($"Уникальный номер: {number}, высота: {High}, этажность: {Floors}, количество квартир: {Apartaments}, подъездов: {Entrances}");
        }

        /// <summary>
        /// Вычисление примерной высоты одного этажа
        /// </summary>
        public float FLoorHeight()
        {
            return (float)High / Floors;
        }

        /// <summary>
        /// Вычисление среднего количества квартир в одном подъезде.
        /// </summary>
        public float AppartamentsPerEntrance()
        {
            return (float)Apartaments / Entrances;
        }

        /// <summary>
        /// Вычисление среднего количества квартир на одном этаже
        /// </summary>
        public float ApartamentsPerFloor()
        {
            return (float)Apartaments / Floors;
        }

        /// <summary>
        /// Вычисление среднего количества квартир на одной лестничной площадке
        /// </summary>
        public float AppartamentsPerLanding()
        {
            return (float)Apartaments / Floors / Entrances;
        }
    }
}
