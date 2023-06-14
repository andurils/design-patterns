using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    // The Abstract Factory interface declares a set of methods that return
    // different abstract products. These products are called a family and are
    // related by a high-level theme or concept. Products of one family are
    // usually able to collaborate among themselves. A family of products may
    // have several variants, but the products of one variant are incompatible
    // with products of another.
    // 抽象工厂接口声明了一组能返回不同抽象产品的方法。这些产品属于同一个系列
    // 且在高层主题或概念上具有相关性。同系列的产品通常能相互搭配使用。系列产
    // 品可有多个变体，但不同变体的产品不能搭配使用。
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }

    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    // 具体工厂可生成属于同一变体的系列产品。工厂会确保其创建的产品能相互搭配
    // 使用。具体工厂方法签名会返回一个抽象产品，但在方法内部则会对具体产品进
    // 行实例化。
    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    // Each Concrete Factory has a corresponding product variant.
    // 每个具体工厂中都会包含一个相应的产品变体。
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }

    



}
