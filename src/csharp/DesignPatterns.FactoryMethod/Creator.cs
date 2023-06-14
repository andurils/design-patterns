using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    // The Creator class declares the factory method that is supposed to return
    // an object of a Product class. The Creator's subclasses usually provide
    // the implementation of this method.
    // 创建者类声明的工厂方法必须返回一个产品类的对象。创建者的子类通常会提供该方法的实现。
    public abstract class Creator
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        // 创建者还可提供一些工厂方法的默认实现。
        public abstract IProduct FactoryMethod();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        // 请注意，创建者的主要职责并非是创建产品。其中通常会包含一些核心业务
        // 逻辑，这些逻辑依赖于由工厂方法返回的产品对象。子类可通过重写工厂方
        // 法并使其返回不同类型的产品来间接修改业务逻辑。
        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            // 调用工厂方法创建一个产品对象。
            var product = FactoryMethod();
            // Now, use the product.
            // 现在使用产品。
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }

    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    // 具体创建者将重写工厂方法以改变其所返回的产品类型。
    public class ConcreteCreator1 : Creator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes. 
        // 返回类型必须遵循通用的产品接口，这样创建者可以独立于具体产品类。
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    public class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
