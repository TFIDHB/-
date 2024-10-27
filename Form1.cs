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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            var selectedZone = zones.SelectedItem;
            if (selectedZone == null)
            {
                MessageBox.Show("Пожалуйста, выберите зону!");
                return;
            }
            selectedZone = zones.SelectedItem.ToString();
            switch (selectedZone)
            {
                case "Смешанный лес":
                    Form forestForm = new Form2(this);
                    forestForm.Show();
                    Hide();
                    break;
                case "Болото":
                    Form swampForm = new Form3(this);
                    swampForm.Show();
                    Hide();
                    break;

                case "Поляна":
                    Form meadowForm = new Form4(this);
                    meadowForm.Show();
                    Hide();
                    break;
            }

        }
        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
