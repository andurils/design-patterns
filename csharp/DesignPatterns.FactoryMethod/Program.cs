// See https://aka.ms/new-console-template for more information

using DesignPatterns.FactoryMethod;


Console.WriteLine("App: Launched with the ConcreteCreator1.");
var creator1 = new ConcreteCreator1();
ClientCode(creator1);

Console.WriteLine("");

Console.WriteLine("App: Launched with the ConcreteCreator2.");
var creator2 = new ConcreteCreator2();
ClientCode(creator2);


// The client code works with an instance of a concrete creator, albeit
// through its base interface. As long as the client keeps working with
// the creator via the base interface, you can pass it any creator's
// subclass.
void ClientCode(Creator creator)
{
    // ...
    Console.WriteLine("Client: I'm not aware of the creator's class," +
        "but it still works.\n" + creator.SomeOperation());
    // ...
}