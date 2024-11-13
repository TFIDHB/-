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
    public partial class Form3 : Form
    {
        private Form1 Form_1;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            Form_1 = form1;
        }

        private void back_Click(object sender, EventArgs e)
        {
            World.Back(this, Form_1);
        }

        private void AddObj_Click(object sender, EventArgs e)
        {
            World.Add(this, Form_1);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            //World.Remove(this, pictureBoxes, pictureBoxLocations, callingFormId, instruction, otherButtons);
        }
    }
}
