using Fishes.Presentors;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishes.Forms
{
    public partial class SelectPlan : Form
    {
        private AquariumPresentor presentor;
        public SelectPlan()
        {
            InitializeComponent();
            
        }

        private void LoadPlan_Click(object sender, EventArgs e)
        {
            OpenFileDialog selection = new OpenFileDialog();
            if (selection.ShowDialog(this)== DialogResult.OK) 
            {
                presentor = new AquariumPresentor();
                presentor.WriteDataInTable(selection.FileName);
                Aquarium aqua = new Aquarium(presentor.TableData);
                aqua.ShowDialog();
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings1 set = new Settings1();
            set.ShowDialog();
        }

        private void ReadyPlan_Click(object sender, EventArgs e)
        {
            presentor = new AquariumPresentor();
            presentor.WriteDataInTable("ReadyPlan.txt");
            Aquarium aqua = new Aquarium(presentor.TableData);
            aqua.ShowDialog();
        }
    }
}
