using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Модель_леса
{
    public partial class Form2 : Form
    {
        private Form1 Form_1;
        private List<PictureBox> pictureBoxes;
        private List<Point> pictureBoxLocations;
        private int callingFormId = 2;
        private List<Button> otherButtons = new List<Button>();
        public Label instruction;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            Form_1 = form1;
            pictureBoxes = Form5.cachedPictureBoxes.ContainsKey(callingFormId) ? Form5.cachedPictureBoxes[callingFormId] : new List<PictureBox>();
            pictureBoxLocations = Form5.cachedLocations.ContainsKey(callingFormId) ? Form5.cachedLocations[callingFormId] : new List<Point>();

            foreach (Control control in Controls)
            {
                if (control is Button button && button.Name != "back")
                {
                    otherButtons.Add(button);
                }
            }

            instruction = new Label
            {
                Text = "Выберите объект для удаления",
                Location = new Point(10, 10),
                AutoSize = true,
                Visible = false
            };
            Controls.Add(instruction);

            back.Click += (sender, e) =>
            {
                World.Back(this, Form_1);
                instruction.Visible = false;
                foreach (var button in otherButtons)
                {
                    button.Visible = true;
                }
            };

            remove.Click += (sender, e) =>
            {
                World.Remove(this, pictureBoxes, pictureBoxLocations, callingFormId, instruction, otherButtons);
            };
        }

        private void AddObj_Click(object sender, EventArgs e)
        {
            World.Add(this, Form_1);
        }

        private void back_Click(object sender, EventArgs e)
        {
            World.Back(this, Form_1);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            World.Remove(this, pictureBoxes, pictureBoxLocations, callingFormId, instruction, otherButtons);
        }
    }
}




