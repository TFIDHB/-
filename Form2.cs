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
        public Form2(Form1 form1)
        {
            InitializeComponent();
            Form_1 = form1;
        }

        private void AddObj_Click(object sender, EventArgs e)
        {
            Form addObj = new Form5(2, Form_1);
            addObj.Show();
            Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_1.Show();
        }
    }
}
