using System;

namespace AbstractFactoryPatternDemo
{
    public abstract class Army
    {
        public abstract string Title {get; }
    }

    public class ElfArmy : Army
    {
        public override string Title
        {
            get => "Elf Army";
        }
    }

    public class OrcishArmy : Army
    {
        public override string Title
        {
            get => "Orcish Army";
        }
    }

    public class HumanArmy : Army
    {
        public override string Title
        {
            get => "Human Army";
        }
    }
}