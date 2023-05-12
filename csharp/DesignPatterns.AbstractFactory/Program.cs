// See https://aka.ms/new-console-template for more information
using DesignPatterns.AbstractFactory;

// The client code can work with any concrete factory class.
Console.WriteLine("Client: Testing client code with the first factory type...");
ClientMethod(new ConcreteFactory1());
Console.WriteLine();

Console.WriteLine("Client: Testing the same client code with the second factory type...");
ClientMethod(new ConcreteFactory2());



// The client code works with factories and products only through abstract
// types: AbstractFactory and AbstractProduct. This lets you pass any
// factory or product subclass to the client code without breaking it.
// 客户端代码仅通过抽象类型（AbstractFactory、AbstractProduct）使用工厂
// 和产品。这让你无需修改任何工厂或产品子类就能将其传递给客户端代码。
void ClientMethod(IAbstractFactory factory)
{
    var productA = factory.CreateProductA();
    var productB = factory.CreateProductB();

    Console.WriteLine(productB.UsefulFunctionB());
    Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
}