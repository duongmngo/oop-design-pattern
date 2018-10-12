using System;

namespace AbstractFactoryPatternDemo
{
    public abstract class King
    {
        public abstract string Title {get; }
    }

    public class ElfKing : King
    {
        public override string Title
        {
            get => "Elf King";
        }
    }

    public class OrcishKing : King
    {
        public override string Title
        {
            get => "Orcish Warchief";
        }
    }

    public class HumanKing : King
    {
        public override string Title
        {
            get => "Human King";
        }
    }
}
