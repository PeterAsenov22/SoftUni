namespace Inferno_Infinity.Factories
{
    using System;
    using Gems;
    using Interfaces;

    public static class GemFactory
    {
        public static IGem CreateGem(string type)
        {
            var typeArgs = type.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            switch (typeArgs[1])
            {
                case "Ruby":
                    return new Ruby(typeArgs[0]);
                case "Emerald":
                    return new Emerald(typeArgs[0]);
                case "Amethyst":
                    return new Amethyst(typeArgs[0]);
            }

            return null;
        }
    }
}
