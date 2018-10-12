using System;

namespace AbstractFactoryPatternDemo
{
    public abstract class Castle
    {
        public abstract string Title {get; }
    }

    public class ElfCastle : Castle
    {
        public override string Title
        {
            get => "Elf Castle";
        }
    }

    public class OrcishCastle : Castle
    {
        public override string Title
        {
            get => "Orcish Citadel";
        }
    }

    public class HumanCastle : Castle
    {
        public override string Title
        {
            get => "Human Castle";
        }
    }
}
