using Fishes.Presentors;
using Fishes.Views;

namespace Fishes.Forms
{
    public partial class Aquarium : Form, IAquarium
    {
        double[,] arr;
        int row = 0;
        private AquariumPresentor presentor;

        public Aquarium(double[,] arrForPres)
        {
            InitializeComponent();
            arr = arrForPres;
            ViewUpdate.Enabled = false;
            Nature.Enabled = false;
            AquariumWork.Enabled = false;
            SystemTime.Enabled = false;
            //presentor = new AquariumPresentor(this, arr);
        }

        public string Temperature1 { get => temp.Text; set => temp.Text = value; }
        public string Oxygen { get => oxy.Text; set => oxy.Text = value; }
        public string Ph { get => ph.Text; set => ph.Text = value; }
        public string TimeOfLight { get => LightTime.Text; set => LightTime.Text = value; }

        public string StageNumber { get => Stage.Text; set => Stage.Text = value; }
        public string TimeOfStage { get => StageTime.Text; set => StageTime.Text = value; }

        public string TempMode { get => TMode.Text; set => TMode.Text = value; }
        public string OxyMode { get => OMode.Text; set => OMode.Text = value; }
        public string PhMode { get => PMode.Text; set => PMode.Text = value; }
        public string LightMode { get => LMode.Text; set => LMode.Text = value; }


        //private AquariumPresentor presentor;
        private void start_Click(object sender, EventArgs e)
        {
            presentor = new AquariumPresentor(this, arr);
            ViewUpdate.Enabled = true;
            Nature.Enabled = true;
            AquariumWork.Enabled = true;
            SystemTime.Enabled = true;
            presentor.CopyData();
            presentor.Fill();
            start.Enabled = false;
            Status.Text = "Working";
        }
        

        private void ViewUpdate_Tick(object sender, EventArgs e)
        {
            presentor.UpdateViewValue();
        }

        private void Nature_Tick(object sender, EventArgs e)
        {
            presentor.NaturalConditions();
        }

        private void AquariumWork_Tick(object sender, EventArgs e)
        {

            presentor.WorkOfAquarium();
        }

        private void SystemTime_Tick(object sender, EventArgs e)
        {

            if(!presentor.ChekTime())
            {
                ViewUpdate.Enabled = false;
                AquariumWork.Enabled=false;
                Nature.Enabled=false;
                SystemTime.Enabled = false;
                start.Enabled = true;
                Status.Text = "End of work";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog(this) == DialogResult.OK)
            {
                presentor.WriteTableInFile(save.FileName + ".txt");
            }
        }
    }
}
