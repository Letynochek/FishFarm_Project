using Fishes.Views;

namespace Fishes.Presentors
{
    public class TablePresentor
    {

        public double[,] TableData = new double[18, 5];
        private IDataTable datatableView;
        public int row = 0; 

        public TablePresentor(IDataTable view)
        {
            datatableView = view;
        }

        public TablePresentor(IDataTable view, double[,] arrTable, int rowValue) 
        {
            datatableView = view;
            TableData = arrTable;
            row = rowValue;
        }

        public void FillValue()
        {
            TableData[row, 0] = Convert.ToDouble(datatableView.Time1);
            TableData[row, 1] = Convert.ToDouble(datatableView.Temperature1);
            TableData[row, 2] = Convert.ToDouble(datatableView.Oxygen1);
            TableData[row, 3] = Convert.ToDouble(datatableView.Light1);
            TableData[row, 4] = Convert.ToDouble(datatableView.Ph1);

            TableData[row+1, 0] = Convert.ToDouble(datatableView.Time2);
            TableData[row+1, 1] = Convert.ToDouble(datatableView.Temperature2);
            TableData[row + 1, 2] = Convert.ToDouble(datatableView.Oxygen2);
            TableData[row + 1, 3] = Convert.ToDouble(datatableView.Light2);
            TableData[row + 1, 4] = Convert.ToDouble(datatableView.Ph2);

            TableData[row+2, 0] = Convert.ToDouble(datatableView.Time3);
            TableData[row+2, 1] = Convert.ToDouble(datatableView.Temperature3);
            TableData[row+2, 2] = Convert.ToDouble(datatableView.Oxygen3);
            TableData[row+2, 3] = Convert.ToDouble(datatableView.Light3);
            TableData[row+2, 4] = Convert.ToDouble(datatableView.Ph3);

            TableData[row+3, 0] = Convert.ToDouble(datatableView.Time4);
            TableData[row+3, 1] = Convert.ToDouble(datatableView.Temperature4);
            TableData[row+3, 2] = Convert.ToDouble(datatableView.Oxygen4);
            TableData[row+3, 3] = Convert.ToDouble(datatableView.Light4);
            TableData[row+3, 4] = Convert.ToDouble(datatableView.Ph4);

            TableData[row+4, 0] = Convert.ToDouble(datatableView.Time5);
            TableData[row+4, 1] = Convert.ToDouble(datatableView.Temperature5);
            TableData[row+4, 2] = Convert.ToDouble(datatableView.Oxygen5);
            TableData[row+4, 3] = Convert.ToDouble(datatableView.Light5);
            TableData[row+4, 4] = Convert.ToDouble(datatableView.Ph5);

        }

        public bool CheckValues()
        {
                for(int i = row; i< row+5; i++)
                if (TableData[i, 0] <= 0)
                {
                    datatableView.Checking = "Wrong time value";
                    return false;
                }

            for (int i = row; i < row + 5; i++)
                if (TableData[i, 1] <= 0 || TableData[i, 1] >= 100)
                {
                    datatableView.Checking = "Wrong temperature value";
                    return false;
                }

            for (int i = row; i < row + 5; i++)
                if (TableData[i, 2] <= 0 || TableData[i, 2] >= 100)
                {
                    datatableView.Checking = "Wrong oxygen value";
                    return false;
                }

            for (int i = row; i < row + 5; i++)
                if (TableData[i, 3] <= 0)
                {
                    datatableView.Checking = "Wrong light value";
                    return false;
                }

            for (int i = row; i < row + 5; i++)
                if (TableData[i, 4] <= 0 || TableData[i, 4] >= 100)
                {
                    datatableView.Checking = "Wrong ph value";
                    return false;
                }
            return true;
        }

        //public void GetValues()
        //{
        //    datatableView.Time = TableData[row, 0].ToString();
        //    datatableView.Temperature = TableData[row, 1].ToString();
        //    datatableView.Light = TableData[row, 2].ToString();
        //    datatableView.Oxygen = TableData[row, 3].ToString();
        //    datatableView.Ph = TableData[row, 4].ToString();
        //}
       
    }
}
