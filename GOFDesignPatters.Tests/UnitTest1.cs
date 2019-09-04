using GOFDesignPatterns.Behavioral.ChainOfResponsability;
using GOFDesignPatterns.Behavioral.Command;
using GOFDesignPatterns.Behavioral.Interpreter;
using GOFDesignPatterns.Behavioral.Iterator;
using GOFDesignPatterns.Behavioral.Mediator;
using GOFDesignPatterns.Behavioral.Memento;
using GOFDesignPatterns.Behavioral.Observer;
using GOFDesignPatterns.Behavioral.State;
using GOFDesignPatterns.Behavioral.TemplateMethod;
using GOFDesignPatterns.Behavioral.Visitor;
using GOFDesignPatterns.Creational.AbstractFactory;
using GOFDesignPatterns.Creational.Builder;
using GOFDesignPatterns.Creational.FactoryMethod;
using GOFDesignPatterns.Creational.Prototype;
using GOFDesignPatterns.Creational.Singleton;
using GOFDesignPatterns.Structural.Adapter;
using GOFDesignPatterns.Structural.Bridge;
using GOFDesignPatterns.Structural.Composite;
using GOFDesignPatterns.Structural.Decorator;
using GOFDesignPatterns.Structural.Facade;
using GOFDesignPatterns.Structural.Flyweight;
using GOFDesignPatterns.Structural.Proxy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GOFDesignPatterns.Tests
{
    [TestClass]
    public class UnitTest1
    {
        

        

        

        

        

        

        

        

        

        

        

        

        [TestMethod]
        public void TestChainOfResponsability()
        {
            var handlerOne = new ConcreteHandler();
            var handlerTwo = new ConcreteHandler();

            handlerOne.SetSuccessor(handlerTwo);

            handlerOne.HandleRequest(1);
        }

        [TestMethod]
        public void TestCommand()
        {
            var receiver = new Receiver();
            var command = new Command(receiver)
            {
                Message = "Test message"
            };
            var invoker = new Invoker(command);

            invoker.Execute();
        }

        [TestMethod]
        public void TestInterpreter()
        {
            var root = new NontTerminalExpression
            {
                ExpressionOne = new TerminalExpression(),
                ExpressionTwo = new TerminalExpression()
            };

            root.Interpret("Context");
        }

        [TestMethod]
        public void TestIterator()
        {
            var aggregate = new ConcreteAggregateB();

            aggregate.Add("Item 1");
            aggregate.Add("Item 2");
            aggregate.Add("Item 3");

            IIterator iterator = aggregate.GetIterator();

            while(!iterator.IsDone())
            {
                var currentItem = iterator.Current();
                
                currentItem = iterator.Next();
            }
        }

        [TestMethod]
        public void TestMediator()
        {
            ConcreteMediator mediator = new ConcreteMediator();

            ITranciever trancieverOne = new TrancieverOne(mediator);
            ITranciever trancieverTwo = new TrancieverTwo(mediator);

            mediator.TrancieverOne = trancieverOne;
            mediator.TrancieverTwo = trancieverTwo;


            trancieverOne.SendMessage("Question");
            trancieverTwo.SendMessage("Answer");
        }

        [TestMethod]
        public void TestMemento()
        {
            var state = new
            {
                FirstName = "Stefan",
                LastName = "Milivojevic"
            };

            var originator = new Originator(state);

            var memento = originator.CreateMemento();

            var savedState = memento.State;
        }

        [TestMethod]
        public void TestObserver()
        {
            var subject = new Subject();
            var observerOne = new Observer(subject);
            var observerTwo = new Observer(subject);
            var observerThree = new Observer(subject);

            subject.Attach(observerOne);
            subject.Attach(observerTwo);
            subject.Attach(observerThree);

            subject.State = "Mrk";
        }

        [TestMethod]
        public void TestState()
        {
            Context context = new Context(new StateOne());

            context.Request();
            context.Request();
            context.Request();
        }

        [TestMethod]
        public void TestTemplateMethod()
        {
            TemplateBase template = new AlgorithmOne();

            template.CallAlgorithm();

            template = new AlgorithmTwo();

            template.CallAlgorithm();
        }

        [TestMethod]
        public void TestVisitor()
        {
            var context = new VisitorContext();

            var concreteElementOne = new ConcreteElementOne();

            var visitor = new ConcreteVisitor();

            context.AddElement(concreteElementOne);
            context.Accept(visitor);
        }
    }
}
