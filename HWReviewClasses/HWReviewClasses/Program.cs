using System;

namespace HWReviewClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your car color");
            string myColor = Console.ReadLine();
            Console.WriteLine("Type your car year");
            int myYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type your car's model");
            string myModel = Console.ReadLine();

            Car myCar = new Car(myColor, myYear, myModel);

            myCar.start();
        }
    }

    public class Car
    {
        public string _color { set; get; }
        public int _year { set; get; }
        public string _model { set; get; }
        public float _HP { set; get; }

        public Car(string col, int yr, string md)
        {
            _color = col;
            _year = yr;
            _model = md;
            _HP = 248.3f;
            Console.WriteLine("Color: {0}, Year: {1}, Model: {2}, HorsePower: {3}",
                _color, _year, _model, _HP);
        }

        public void start()
        {
            Console.WriteLine("Vroom Vroom goes the {0} horsepower engine", _HP);
        }

        public void drive(bool drift)
        {
            if (!drift)
            {
                Console.WriteLine("You are driving like Miss Daisy");
            } else
            {
                Console.WriteLine("Time to party");
            }
        }
    }

}
