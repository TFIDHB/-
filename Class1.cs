using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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

        public static void Add(Form currentForm, Form1 mainForm)
        {
            Form addObj = new Form5(2, mainForm);
            addObj.Show();
            currentForm.Hide();
        }

        public static void Back(Form currentForm, Form1 mainForm)
        {
            currentForm.Close();
            mainForm.Show();
        }

        public static void Remove(Form currentForm, List<PictureBox> pictureBoxes, List<Point> pictureBoxLocations, int callingFormId, Label instruction, List<Button> otherButtons)
        {
            foreach (var button in otherButtons)
            {
                button.Visible = false;
            }
            instruction.Visible = true;

            currentForm.MouseClick += (s, args) =>
            {
                for (int i = pictureBoxes.Count - 1; i >= 0; i--)
                {
                    if (pictureBoxes[i].Bounds.Contains(args.Location))
                    {
                        currentForm.Controls.Remove(pictureBoxes[i]);
                        pictureBoxes.RemoveAt(i);
                        pictureBoxLocations.RemoveAt(i);

                        foreach (var button in otherButtons)
                        {
                            button.Visible = true;
                        }
                        instruction.Visible = false;

                        break;
                    }
                }

                Form5.cachedPictureBoxes[callingFormId] = pictureBoxes;
                Form5.cachedLocations[callingFormId] = pictureBoxLocations;
            };
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