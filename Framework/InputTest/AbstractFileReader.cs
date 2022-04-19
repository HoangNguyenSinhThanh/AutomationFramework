using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelFileFramworkHandle
{
    abstract class AbstractFileReader
    {
        protected abstract void OpenFile();
        protected abstract void CloseFile();
        protected abstract void ParseData();
    }
}
