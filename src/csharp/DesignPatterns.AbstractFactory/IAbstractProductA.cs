using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    // Each distinct product of a product family should have a base interface.
    // All variants of the product must implement this interface.
    // 系列产品中的特定产品必须有一个基础接口。所有产品变体都必须实现这个接口。
    public interface IAbstractProductA
    {
        string UsefulFunctionA();
    }

    // Concrete Products are created by corresponding Concrete Factories.
    // 具体产品由相应的具体工厂创建。
    class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }

    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
