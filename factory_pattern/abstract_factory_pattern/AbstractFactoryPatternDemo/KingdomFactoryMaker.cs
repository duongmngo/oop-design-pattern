using System;

namespace AbstractFactoryPatternDemo
{
    public enum KingdomType
    {
        Elf,
        Orcish,
        Human,
    }

    public static class KingdomFactoryMaker
    {
        public static IKingdomFactory CreateKingdomFactory(KingdomType kingdomType)
        {
            switch (kingdomType)
            {
                case KingdomType.Elf:
                    return new ElfKingdomFactory();
                case KingdomType.Orcish:
                    return new OrcishKingdomFactory();
                case KingdomType.Human:
                    return new HumanKingdomFactory();
                default:
                    return null;
            }
        }
    }
}
