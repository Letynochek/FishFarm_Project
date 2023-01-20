using Fishes.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fishes.Presentors;
using Fishes.Views;

namespace Fishes.Forms
{
    public partial class Settings1 : Form, IDataTable
    {
        public Settings1()
        {
            InitializeComponent();
        }

        public string Time1 { get => time1.Text; set => time1.Text = value; }
        public string Temperature1 { get => temp1.Text; set => temp1.Text = value; }
        public string Oxygen1 { get => oxy1.Text; set => oxy1.Text = value; }
        public string Light1 { get => light1.Text; set => light1.Text = value; }
        public string Ph1 { get => ph1.Text; set => ph1.Text = value; }

        public string Time2 { get => time2.Text; set => time2.Text = value; }
        public string Temperature2 { get => temp2.Text; set => temp2.Text = value; }
        public string Oxygen2 { get => oxy2.Text; set => oxy2.Text = value; }
        public string Light2 { get => light2.Text; set => light2.Text = value; }
        public string Ph2 { get => ph2.Text; set => ph2.Text = value; }

        public string Time3 { get => time3.Text; set => time3.Text = value; }
        public string Temperature3 { get => temp3.Text; set => temp3.Text = value; }
        public string Oxygen3 { get => oxy3.Text; set => oxy3.Text = value; }
        public string Light3 { get => light3.Text; set => light3.Text = value; }
        public string Ph3 { get => ph3.Text; set => ph3.Text = value; }

        public string Time4 { get => time4.Text; set => time4.Text = value; }
        public string Temperature4 { get => temp4.Text; set => temp4.Text = value; }
        public string Oxygen4 { get => oxy4.Text; set => oxy4.Text = value; }
        public string Light4 { get => light4.Text; set => light4.Text = value; }
        public string Ph4 { get => ph4.Text; set => ph4.Text = value; }

        public string Time5 { get => time5.Text; set => time5.Text = value; }
        public string Temperature5 { get => temp5.Text; set => temp5.Text = value; }
        public string Oxygen5 { get => oxy5.Text; set => oxy5.Text = value; }
        public string Light5 { get => light5.Text; set => light5.Text = value; }
        public string Ph5 { get => ph5.Text; set => ph5.Text = value; }

        public string Checking { get => Check.Text; set => Check.Text = value; }

        private TablePresentor presentor;

        private void Next_Click(object sender, EventArgs e)
        {
            presentor = new TablePresentor(this);
            presentor.FillValue();
            if (presentor.CheckValues())
            {
                Aquarium set2 = new Aquarium(presentor.TableData);
                set2.Show();
            }
        }
    }
}
