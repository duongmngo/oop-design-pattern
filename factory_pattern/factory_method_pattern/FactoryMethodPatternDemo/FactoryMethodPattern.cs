using System;
namespace FactoryMethodPatternDemo
{
    public abstract class Position
    {
        public abstract string Title {get; }
    }

    public class Manager : Position
    {
        public override string Title
        {
            get
            {
                return "Manager";
            }
        }
    }

    public class Clerk : Position
    {
        public override string Title
        {
            get
            {
                return "Clerk";
            }
        }
    }

    public class Programmer : Position
    {
        public override string Title
        {
            get
            {
                return "Programmer";
            }
        }
    }
    
    public enum PositionType
    {
        Manager,
        Clerk,
        Programmer,
    }

    public static class PositionFactory
    {
        public static Position CreateNewPosition(PositionType positionType)
        {
            switch (positionType)
            {
                case PositionType.Manager:
                    return new Manager();
                case PositionType.Clerk:
                    return new Clerk();
                case PositionType.Programmer:
                    return new Programmer();
                default:
                    return null;
            }
        }
    }
}
