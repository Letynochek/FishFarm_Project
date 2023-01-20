using Fishes.Presentors;
using Fishes.Views;

namespace Fishes.ExampleForms
{
    public partial class Ex1 : Form, IDataTable
    {
        public Ex1()
        {
            InitializeComponent();
        }

        public string Time { get => time.Text; set => time.Text=value; }
        public string Temperature { get => temp.Text; set => temp.Text = value; }
        public string Oxygen { get => oxy.Text; set => oxy.Text = value; }
        public string Light { get => ligh.Text; set => ligh.Text = value; }
        public string Ph { get => Phh.Text; set => Phh.Text = value; }

        public string TimeShow { get => timeShow.Text; set => timeShow.Text = value; }


        private TablePresentor presentor;

        private void button1_Click(object sender, EventArgs e)
        {
            presentor = new TablePresentor(this);
            presentor.FillValue();
            Ex2 example2 = new Ex2(presentor.TableData);
            example2.Show();
        }
    }
}
