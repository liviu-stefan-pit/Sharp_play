using Advanced_cs.CreationalPatterns.AbstractFactory;
using Advanced_cs.CreationalPatterns.Builder;
using Advanced_cs.CreationalPatterns.FactoryMethod;
using Advanced_cs.CreationalPatterns.Prototype;
using Advanced_cs.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegates

            //ComputerSystem computerSystem = new ComputerSystem();

            //OperationDelegate operationDelegate = new OperationDelegate(computerSystem.StartApp);
            //Console.WriteLine($"Result: {operationDelegate("test start")}");

            //operationDelegate = new OperationDelegate(computerSystem.StopApp);
            //Console.WriteLine($"Result: {operationDelegate("test stop")}");

            //computerSystem.Operation("test", operationDelegate);

            //Console.WriteLine("\n\n");

            //OperationDelegateMulticast operationDelegateMulticast = new OperationDelegateMulticast(computerSystem.MulticastTest1);
            //operationDelegateMulticast += new OperationDelegateMulticast(computerSystem.MulticastTest2);

            //operationDelegateMulticast("test multicast");

            //Console.WriteLine("\n\n");

            //EventSender sender = new EventSender();
            //EventReceiver receiver = new EventReceiver();

            //sender.Eventvar += new EventDelegate(receiver.EventHandlerReceiver);
            //sender.RaiseEvent();

            #endregion Delegates

            #region Abstract factory
            //ContinentFactory africa = new AfricaFactory();
            //AnimalWorld world = new AnimalWorld(africa);
            //world.RunFoodChain();

            //ContinentFactory america = new AmericaFactory();
            //world = new AnimalWorld(america);
            //world.RunFoodChain();
            #endregion Abstract factory

            #region Builder
            //VehicleBuilder builder;

            //Shop shop = new Shop();

            //builder = new ScooterBuilder();
            //shop.Construct(builder);
            //builder.Vehicle.Show();
            //builder = new CarBuilder();
            //shop.Construct(builder);
            //builder.Vehicle.Show();
            #endregion

            #region Factory method
            //Document[] documents = new Document[1];
            //documents[0] = new Resume();

            //foreach (Document document in documents)
            //{
            //    Console.WriteLine("\n" + document.GetType().Name + "--");
            //    foreach (Page page in document.Pages)
            //    {
            //        Console.WriteLine(" " + page.GetType().Name);
            //    }
            //}
            #endregion

            #region Prototype
            //ColorManager colorManager = new ColorManager();

            //colorManager["red"] = new Color(255, 0, 0);
            //colorManager["blue"] = new Color(0, 0, 255);

            //Color color1 = colorManager["red"].Clone() as Color;
            //Color color2 = colorManager["blue"].Clone() as Color;
            #endregion

            Console.ReadKey();
        }
    }
}
