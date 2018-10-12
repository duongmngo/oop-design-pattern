using System;

namespace AbstractFactoryPatternDemo
{
    class Program
    {
        static void BuildNewKingdom(IKingdomFactory kingdomFactory)
        {
            Castle createdCastle = kingdomFactory.CreateCastle();
            King createdKing = kingdomFactory.CreateKing();
            Army createdArmy = kingdomFactory.CreateArmy();
            
            Console.WriteLine(createdCastle.Title);
            Console.WriteLine(createdKing.Title);
            Console.WriteLine(createdArmy.Title);   
        }

        static void Main(string[] args)
        {
            IKingdomFactory elfKingdomFactory = KingdomFactoryMaker.CreateKingdomFactory(KingdomType.Elf);
            IKingdomFactory orcishKingdomFactory = KingdomFactoryMaker.CreateKingdomFactory(KingdomType.Orcish);
            IKingdomFactory humanKingdomFactory = KingdomFactoryMaker.CreateKingdomFactory(KingdomType.Human);

            BuildNewKingdom(elfKingdomFactory);
            BuildNewKingdom(orcishKingdomFactory);
            BuildNewKingdom(humanKingdomFactory);
        }
    }
}
