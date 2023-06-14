using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.  
    // 生成器接口声明了创建产品对象不同部件的方法。
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }

    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    // 具体生成器类将遵循生成器接口并提供生成步骤的具体实现。你的程序中可能会
    // 有多个以不同方式实现的生成器变体。
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        // 一个新的生成器实例必须包含一个在后续组装过程中使用的空产品对象。
        public ConcreteBuilder()
        {
            this.Reset();
        }
        // reset（重置）方法可清除正在生成的对象。
        public void Reset()
        {
            this._product = new Product();
        }

        // All production steps work with the same product instance.
        // 所有的生产步骤都会使用同一个产品实例。
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }

        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        // 具体生成器需要自行提供获取结果的方法。这是因为不同类型的生成器可能
        // 会创建不遵循相同接口的、完全不同的产品。所以也就无法在生成器接口中
        // 声明这些方法（至少在静态类型的编程语言中是这样的）。
        //
        // 通常在生成器实例将结果返回给客户端后，它们应该做好生成另一个产品的
        // 准备。因此生成器实例通常会在 `getProduct（获取产品）`方法主体末尾
        // 调用重置方法。但是该行为并不是必需的，你也可让生成器等待客户端明确
        // 调用重置方法后再去处理之前的结果。
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
