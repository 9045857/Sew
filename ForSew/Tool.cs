using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSew
{
    class Tool
    {
        public List<Strategy> Strategies { get; set; }

        public Tool(List<string> puths) {
            //TODO Анализ, что передали, путь файла или папки. Или комбинированный вариант.
        }

        private void SetStrategiesFromFiles(List<Strategy> strategies, List<string> puths) {
            foreach (string puth in puths) {
                Strategy strategy = new Strategy(puth);
                strategies.Add(strategy);
            }
        }

        private void SetStrategiesFromFolders(List<Strategy> strategies, List<string> puths)
        {
            //TODO Do need checking of file existing?
            
        }

    }
}
