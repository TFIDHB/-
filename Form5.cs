using System.Windows.Forms;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;

namespace Модель_леса
{

    public partial class Form5 : Form
    {
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private List<Point> pictureBoxLocations = new List<Point>();
        private Label amountLabel;

        private int callingFormId;
        private Form1 form1Instance;

        public static Dictionary<int, List<PictureBox>> cachedPictureBoxes = new Dictionary<int, List<PictureBox>>();
        public static Dictionary<int, List<Point>> cachedLocations = new Dictionary<int, List<Point>>();

        public Form5(int formId, Form1 form1)
        {
            InitializeComponent();
            callingFormId = formId;
            form1Instance = form1;

            if (!cachedPictureBoxes.ContainsKey(formId))
            {
                cachedPictureBoxes[formId] = new List<PictureBox>();
                cachedLocations[formId] = new List<Point>();
            }

            pictureBoxes = cachedPictureBoxes[formId];
            pictureBoxLocations = cachedLocations[formId];
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (amountLabel != null)
            {
                amountLabel.Text = numericUpDown1.Value.ToString();
            }
        }


        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Spec.Items.Clear();

            if (Type.SelectedItem.ToString() == "Хищник")
            {
                Spec.Items.AddRange(Predators.PredatorNames);
            }
            else if (Type.SelectedItem.ToString() == "Травоядное")
            {
                Spec.Items.AddRange(Herbivores.HerbivoreNames);
            }
            else if (Type.SelectedItem.ToString() == "Растение")
            {
                Spec.Items.AddRange(Plants.PlantNames);
            }
            else if (Type.SelectedItem.ToString() == "Насекомое")
            {
                Spec.Items.AddRange(Insects.InsectNames);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Hide();

            string selectedAnimal = Spec.SelectedItem.ToString();
            string currentProjectPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagesFolderPath = "Животные";
            string imagePath = $"{currentProjectPath}/{imagesFolderPath}/{selectedAnimal}.png";

            PictureBox animalPictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.AutoSize,
                Image = Image.FromFile(imagePath),
                BackColor = Color.Transparent
            };

            Label amountLabel = new Label
            {
                Text = numericUpDown1.Value.ToString(),
                AutoSize = true,
                BackColor = Color.Yellow
            };

            Form formToOpen = null;

            switch (callingFormId)
            {
                case 2:
                    formToOpen = new Form2(form1Instance);
                    break;
                case 3:
                    formToOpen = new Form3(form1Instance);
                    break;
                case 4:
                    formToOpen = new Form4(form1Instance);
                    break;
            }

            if (formToOpen != null)
            {
                formToOpen.MouseClick += (s, args) =>
                {
                    animalPictureBox.Location = args.Location;
                    pictureBoxes.Add(animalPictureBox);
                    pictureBoxLocations.Add(args.Location);

                    amountLabel.Location = new Point(args.Location.X, args.Location.Y + animalPictureBox.Height + 5);

                    cachedPictureBoxes[callingFormId] = pictureBoxes;
                    cachedLocations[callingFormId] = pictureBoxLocations;

                    formToOpen.Controls.Add(animalPictureBox);
                    formToOpen.Controls.Add(amountLabel);
                };

                for (int i = 0; i < pictureBoxes.Count; i++)
                {
                    PictureBox pictureBox = pictureBoxes[i];
                    Point location = pictureBoxLocations[i];
                    pictureBox.Location = location;
                    formToOpen.Controls.Add(pictureBox);
                }

                formToOpen.Show();
            }
        }

        private void objBehavior_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Spec.SelectedItem != null && objBehavior.SelectedItem != null)
            {
                string selectedSpecies = Spec.SelectedItem.ToString();
                string selectedBehavior = objBehavior.SelectedItem.ToString();

                World worldObject = null;

                if (Type.SelectedItem.ToString() == "Хищник")
                {
                    worldObject = new Predators(selectedSpecies, (int)numericUpDown1.Value, selectedBehavior);
                }
                else if (Type.SelectedItem.ToString() == "Травоядное")
                {
                    worldObject = new Herbivores(selectedSpecies, (int)numericUpDown1.Value, selectedBehavior);
                }
                else if (Type.SelectedItem.ToString() == "Растение")
                {
                    worldObject = new Plants(selectedSpecies, (int)numericUpDown1.Value, selectedBehavior);
                }
                else if (Type.SelectedItem.ToString() == "Насекомое")
                {
                    worldObject = new Insects(selectedSpecies, (int)numericUpDown1.Value, selectedBehavior);
                }

            }
        }

    }
}