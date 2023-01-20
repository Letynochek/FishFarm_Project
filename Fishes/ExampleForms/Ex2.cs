using Fishes.Presentors;
using Fishes.Views;

namespace Fishes.ExampleForms
{
    public partial class Ex2 : Form, IDataTable
    {
        double[,] arr;
        public Ex2(double[,] arrForPres)
        {
            InitializeComponent();
            arr = arrForPres;
        }

        public string Time { get => time.Text; set => time.Text = value; }
        public string Temperature { get => temp.Text; set => temp.Text = value; }
        public string Oxygen { get => oxy.Text; set => oxy.Text = value; }
        public string Light { get => ligh.Text; set => ligh.Text = value; }
        public string Ph { get => Phh.Text; set => Phh.Text = value; }

        public string TimeShow { get; set; }

        private TablePresentor presentor;

        private void button1_Click(object sender, EventArgs e)
        {
            presentor = new TablePresentor(this, arr, 0);
            presentor.GetValues();
           // presentor.GetTime();
        }
    }
}
