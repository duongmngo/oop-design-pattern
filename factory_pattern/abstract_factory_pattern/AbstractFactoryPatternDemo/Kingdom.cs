using System;

namespace AbstractFactoryPatternDemo
{
    public interface IKingdomFactory
    {
        Castle CreateCastle();
        King CreateKing();
        Army CreateArmy();

    }

    public class ElfKingdomFactory : IKingdomFactory
    {
        public Castle CreateCastle()
        {
            return new ElfCastle();
        }

        public King CreateKing()
        {
            return new ElfKing();
        }

        public Army CreateArmy()
        {
            return new ElfArmy();
        }
    }

    public class OrcishKingdomFactory : IKingdomFactory
    {
        public Castle CreateCastle()
        {
            return new OrcishCastle();
        }

        public King CreateKing()
        {
            return new OrcishKing();
        }

        public Army CreateArmy()
        {
            return new OrcishArmy();
        }
    }

    public class HumanKingdomFactory : IKingdomFactory
    {
        public Castle CreateCastle()
        {
            return new HumanCastle();
        }

        public King CreateKing()
        {
            return new HumanKing();
        }

        public Army CreateArmy()
        {
            return new HumanArmy();
        }
    }
}
