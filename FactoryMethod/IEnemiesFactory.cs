using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// Каждая конкретная фабрика должна реализовывать свой способ создания объекта
    interface IEnemiesFactory
    {
        IEnemies Create();
    }
}
