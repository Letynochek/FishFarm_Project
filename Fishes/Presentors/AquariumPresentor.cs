using Fishes.Views;

namespace Fishes.Presentors
{
    internal class AquariumPresentor
    {
        private IAquarium AquariumView;
        public double[,] TableData = new double[18, 5];
        public double[] CurrentData = new double[5];
        private DateTime timeBegin;
        private DateTime timeNow;
        public int CurrentRow = 0;

        public void CopyData()
        {
            for (int j = 0; j < 5; j++)
            {
                CurrentData[j] = TableData[0, j];
            }
        }

        public AquariumPresentor(IAquarium view, double[,] arrTable)
        {
            AquariumView = view;
            TableData = arrTable;
            timeBegin = DateTime.Now;
            timeNow = DateTime.Now;
        }

        public AquariumPresentor()
        {
          
        }

        public void Fill()
        {
            AquariumView.Temperature1 = Convert.ToString(CurrentData[1]);
            AquariumView.Ph = Convert.ToString(CurrentData[4]);
            AquariumView.Oxygen = Convert.ToString(CurrentData[2]);
        }

        public void NaturalConditions()
        {
            CurrentData[1] -= 2;
            CurrentData[2] -= 2;
            CurrentData[4] -= 2;
        }

        private void Heater()
        {
            CurrentData[1]++;
        }

        private void Filter()
        {
            CurrentData[2]++;
        }
        private void Food()
        {
            CurrentData[4]++;
        }

        private void Light()
        {
            timeNow = DateTime.Now;
            if (timeNow.Subtract(timeBegin).Seconds > TableData[CurrentRow, 3])
            {
                AquariumView.LightMode = "Off";
            }
            else
            {
                AquariumView.LightMode = "On";
                CurrentData[3] = timeNow.Subtract(timeBegin).Seconds;
            }    
        }

        public void UpdateTemp()
        {
            AquariumView.Temperature1 = Convert.ToString(CurrentData[1]);
        }
        public void UpdateViewValue()
        {
            AquariumView.Temperature1 = Convert.ToString(CurrentData[1]);
            AquariumView.Ph = Convert.ToString(CurrentData[4]);
            AquariumView.Oxygen = Convert.ToString(CurrentData[2]);
            AquariumView.StageNumber = Convert.ToString(CurrentRow+1);
            AquariumView.TimeOfLight = Convert.ToString(CurrentData[3]);
            AquariumView.TimeOfStage = Convert.ToString(CurrentData[0]); 
        }

        public void WorkOfAquarium()
        {
            if (CurrentData[1] < TableData[CurrentRow, 1])
            {
                Heater();
                AquariumView.TempMode = "On";
            }
            else
                AquariumView.TempMode = "Off";

            if (CurrentData[4] < TableData[CurrentRow, 4])
            { 
                Food();
                AquariumView.PhMode = "On";
            }
            else
                AquariumView.PhMode = "Off";

            if (CurrentData[2] < TableData[CurrentRow, 2])
            {
                Filter();
                AquariumView.OxyMode = "On";
            }
            else
                AquariumView.OxyMode = "Off";

            Light();
        }

        public bool ChekTime()
        {
            timeNow = DateTime.Now;
            if (timeNow.Subtract(timeBegin).Seconds > TableData[CurrentRow,0])
            {
                CurrentRow++;
                timeBegin = DateTime.Now;
            }
            else
                CurrentData[0] = timeNow.Subtract(timeBegin).Seconds;
            if (CurrentRow == TableData.GetUpperBound(0) + 1)
                return false;
            else
                return true;
        }

        public void WriteTableInFile(string file)
        {
            StreamWriter stream = new StreamWriter(file);
            string data = "      Time   Temp-re    Oxygen     Light       Ph\n";
            stream.Write(data);
            data = "";
            for (int i = 0; i < TableData.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < TableData.GetUpperBound(1) + 1; j++)
                {
                    data += TableData[i, j].ToString().PadLeft(10);
                }
                data+= "\n";
                stream.Write(data);
                data = "";
            }
            stream.Close();
        }

        public void WriteDataInTable( string file)
        {
            StreamReader sr = new StreamReader(file);
            string[] mas_rows = sr.ReadToEnd().Split('\n');
            for (int i = 0; i < TableData.GetUpperBound(0) + 1; i++)
            {
                int index = 0;
                string[] elements = mas_rows[i+1].Split(' ');
                for (int j = 0; j < TableData.GetUpperBound(1) + 1; j++)
                {
                    while (index < (elements.Length) - 1 && elements[index] == "")
                        index++;
                    TableData[i, j] = double.Parse(elements[index]);
                    index++;
                }
            }
            sr.Close();
        }
    }
}
