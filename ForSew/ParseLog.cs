using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSew
{
    public class ParseLog
    {
        public delegate void AccountWarnings(string message);
        public event AccountWarnings Notify;
        //Вторая ветка для теста, как это будет на Гитхабе

    }
}
