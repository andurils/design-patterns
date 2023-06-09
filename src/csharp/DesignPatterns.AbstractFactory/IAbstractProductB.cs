﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{

    // Here's the the base interface of another product. All products can
    // interact with each other, but proper interaction is possible only between
    // products of the same concrete variant.
    // 这是另一个产品的基础接口。所有产品都可以互动，但是只有相同具体变体的产
    // 品之间才能够正确地进行交互。
    public interface IAbstractProductB
    {
        // Product B is able to do its own thing... 产品B能够自己的事情
        string UsefulFunctionB();

        // ...but it also can collaborate with the ProductA.  可以与ProductA合作。
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        // 抽象工厂确保它创建的所有产品都是同一变体，因此是兼容的。
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }

    // Concrete Products are created by corresponding Concrete Factories.
    // 具体产品由相应的具体工厂创建。
    class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        // 变体 Product B1只能与变体 Product A1 正确地工作。
        // 但是，它接受任何AbstractProductA的实例作为参数。 
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
    }

    class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }

        // The variant, Product B2, is only able to work correctly with the
        // variant, Product A2. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        // 变体 Product B2只能与变体 Product A2 正确地工作。
        // 但是，它接受任何AbstractProductA的实例作为参数。 
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}
