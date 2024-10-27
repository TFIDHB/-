using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модель_леса
{
    public abstract class World
    {
        public string Species { get; set; }
        public int Amount { get; set; }
        public string Behavior { get; set; }

        public World(string species, int amount, string behavior)
        {
            Species = species;
            Amount = amount;
            Behavior = behavior;
        }
    }

    public class Predators : World
    {
        public static string[] PredatorNames = { "Волк", "Лиса", "Медведь" };

        public Predators(string species, int amount, string behavior)
            : base(species, amount, behavior) { }
    }

    public class Herbivores : World
    {
        public static string[] HerbivoreNames = { "Олень", "Заяц", "Лось" };

        public Herbivores(string species, int amount, string behavior)
            : base(species, amount, behavior) { }
    }

    public class Plants : World
    {
        public static string[] PlantNames = { "Ромашка", "Одуванчик", "Клевер" };

        public Plants(string species, int amount, string behavior)
            : base(species, amount, behavior) { }
    }

    public class Insects : World
    {
        public static string[] InsectNames = { "Муравей", "Пчела", "Бабочка" };

        public Insects(string species, int amount, string behavior)
            : base(species, amount, behavior) { }
    }

}

