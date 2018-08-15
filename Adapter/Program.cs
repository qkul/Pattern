using System;
// допустим, у нас есть путешественник который передвигается на машине.
//Но машина проедет не везде, поэтому ему нужна лошадь, но использование класса лошадь не предусмотрено
// поэтому нужно использовать адаптер.
namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);
            // надо использовать лошадь
            Horse horse = new Horse();
            // используем адаптер
            var horseTransport = new Adapter(horse);
            // продолжаем путь 
            driver.Travel(horseTransport);

            Console.Read();
        }
    }
 
    // класс машины
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Едем на машине");
        }
    }
    class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
    // класс лошадь
    class Horse : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Едем на лошади ^_^");
        }
    }
    // Адаптер от Horse к ITransport
    class Adapter : ITransport
    {    
        Horse horse;
        public Adapter(Horse c)
        {
            horse = c;
        }
        public void Drive()
        {
            horse.Move();
        }
    }
}