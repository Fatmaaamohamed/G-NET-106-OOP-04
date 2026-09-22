namespace G_NET_106_OOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01

            /*
             
             a) Abstraction hides complex implementation details and exposes only essential features.
                It focuses on what an object does rather than how it does it .
             
             b) Reduces Complexity: Shields developers from unnecessary code details.
                Enhances Maintainability: Internal implementation can change without breaking dependent code.
                Security: Prevents direct access to internal state and logic.
             
             */

            #endregion


            #region Question02
            /*
             
            a) An abstract class defines an "is-a" relationship for related classes, while an interface defines a "can-do" capability for unrelated classes.
               Abstract classes can contain implemented methods and instance state; interfaces only declare method signatures without state.
               Abstract classes support constructors; interfaces do not.
               A class can inherit from only one abstract class, but it can implement multiple interfaces.
             
            
            b) Defining capabilities across unrelated classes, Needing multiple inheritance of roles, Creating a lightweight contract without sharing state or code.


            c) Multiple Abstract Classes: No. A class can inherit from only one base class.
               Multiple Interfaces: Yes. A class can implement multiple interfaces.
             
             */

            #endregion

            #region Question08

            DeliveryAddress destination = new DeliveryAddress("123 Main St", "Cairo", 11511);

            StandardShipment standard = new StandardShipment("SH001", "Laptop", 2.5m, 95.0m, destination);

            ExpressShipment express = new ExpressShipment("SH002", "Fragile Item", 1.5m, 70.0m, destination, 30.0m);

            InternationalShipment international = new InternationalShipment("SH003", "Documents", 3.0m, 200.0m, destination, "Germany", 60.0m);

            DeliveryCenter center = new DeliveryCenter("Delivery Center");

            center.AddShipment(standard);

            center.AddShipment(express);

            center.AddShipment(international);

            Console.WriteLine("==========================================");
            center.PrintAllShipments();

            Console.WriteLine("==========================================");

            center.PrintTrackingStatuses();

            Console.WriteLine("==========================================");

            center.PrintInsurancePolicies();

            Console.WriteLine("==========================================");
            Console.WriteLine("\nInterface Polymorphism Demonstrated Successfully.");


            #endregion
        }
    }
}
