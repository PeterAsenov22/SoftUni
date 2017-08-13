namespace _02.Blobs.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public static class BehaviorFactory
    {
        public static IBehavior CreateBehavior(string behaviorName)
        {
            Type behaviorType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == behaviorName);
            return (IBehavior) Activator.CreateInstance(behaviorType);
        }
    }
}
