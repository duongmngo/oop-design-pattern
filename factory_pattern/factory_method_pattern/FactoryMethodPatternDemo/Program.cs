using System;

namespace FactoryMethodPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Position newManager = PositionFactory.CreateNewPosition(PositionType.Manager);
            Position newClerk = PositionFactory.CreateNewPosition(PositionType.Clerk);
            Position newProgrammer = PositionFactory.CreateNewPosition(PositionType.Programmer);

            Console.WriteLine(newManager.Title);
            Console.WriteLine(newClerk.Title);
            Console.WriteLine(newProgrammer.Title);
        }
    }
}
