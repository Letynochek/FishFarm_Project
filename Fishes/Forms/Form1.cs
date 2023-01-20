
using Fishes.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishes
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
            buttonOk.Enabled = false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
                buttonOk.Enabled = false;
            else
                buttonOk.Enabled = true;

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
           // Settings1 exampleForm1 = new Settings1();
            //exampleForm1.ShowDialog();
            SelectPlan selectform = new SelectPlan();
            selectform.ShowDialog();
        }
    }
}
