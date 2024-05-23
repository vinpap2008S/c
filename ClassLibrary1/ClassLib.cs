namespace ClassLib
{
    public class PC
    {
        // Поля
        public int id;
        public string name;
        public int price;
        private bool isTurnedOn;

        // Свойства
        public string Id
        {
            get { return Id; }
            set { Id = value; }
        }

        public int Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public bool Price
        {
            get { return Price; }
        }

        // Конструкторы
        public PC()
        {
            id = 0;
            name = "";
            price = 0;
            isTurnedOn = false;
        }

        public PC(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        // Методы
        public void TurnOn()
        {
            if (!isTurnedOn)
            {
                isTurnedOn = true;
                Console.WriteLine("The PC is turned on.");
            }
            else
            {
                Console.WriteLine("The PC is already turned on.");
            }
        }

        public void TurnOff()
        {
            if (isTurnedOn)
            {
                isTurnedOn = false;
                Console.WriteLine("The PC is turned off.");
            }
            else
            {
                Console.WriteLine("The PC is already turned off.");
            }
        }

        public void Overload()
        {
            if (isTurnedOn)
            {
                Console.WriteLine("The PC is overloaded. Restarting...");
                TurnOff();
                TurnOn();
            }
            else
            {
                Console.WriteLine("The PC is turned off. Cannot overload.");
            }
        }
    }
}
