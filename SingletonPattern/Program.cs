using System;
/*Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует, 
  что для определенного класса будет создан только один объект,
  а также предоставит к этому объекту точку доступа.

Когда надо использовать Синглтон? Когда необходимо, чтобы для класса существовал только один экземпляр*/
namespace SingletonPattern
{// варианты:
 // использованием типа Lazy
 // полностью ленивая загрузка
 // защита с lock
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);

            // у нас не получится изменить ОС, так как объект уже создан    
            comp.OS = OS.GetInstance("Windows 10");
            Console.WriteLine(comp.OS.Name);

            Console.ReadLine();
        }
    }  
}
