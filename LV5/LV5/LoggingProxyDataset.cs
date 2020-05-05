using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LV5
{
    public class LoggingProxyDataset : IDataset
    {
        private string filePath;
        private Dataset dataset;
        public LoggingProxyDataset(string filePath)
        {
            this.filePath = filePath;
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            ConsoleLogger.getInstance().log();
            return dataset.GetData();
        }
    }
}
