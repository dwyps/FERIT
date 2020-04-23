using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    public class Dataset:Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath)
            : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }
        public Prototype Clone()
        {
            Dataset clone = new Dataset();
            clone.data = new List<List<string>>();
            foreach (List<string> row in data)
            {
                List<string> newRow = new List<string>();
                foreach (string word in row)
                {
                    newRow.Add(word);
                }
                clone.data.Add(newRow);
            }
            return clone;
        }
        public void changeFirstElement()
        {
            data[0][0] = "ewfwegfe";
        }
    }
}
