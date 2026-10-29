namespace Kobyzeva_Tumakov_hw6.Class
{
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
        public Building(float high, byte floors, int apartaments, byte entrances)
        {
            number0++;
            number = number0;
            High = high;
            Floors = floors;
            Apartaments = apartaments;
            Entrances = entrances;
        }

        public void PrintOnConsole()
        {
            Console.WriteLine($"Уникальный номер: {number}, высота: {High}, этажность: {Floors}, количество квартир: {Apartaments}, подъездов: {Entrances}");
        }

        public float FLoorHeight()
        {
            return (float)High / Floors;
        }

        public float AppartamentsPerEntrance()
        {
            return (float)Apartaments / Entrances;
        }

        public float ApartamentsPerFloor()
        {
            return (float)Apartaments / Floors;
        }
        public float AppartamentsPerLanding()
        {
            return (float)Apartaments / Floors / Entrances;
        }
    }
}
