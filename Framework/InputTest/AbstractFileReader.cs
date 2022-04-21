using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelFileFramworkHandle
{
    public abstract class AbstractFileReader
    {
        public enum RuleTestStep
        {

        }
        public abstract void OpenFile();
        public abstract void CloseFile();
        public abstract bool VerifySpec();
        public abstract List<Testspec> GetData();
        public void ParseData(List<Testspec> listTestpec)
        {
            List<string> testStepList = new List<string>();
            foreach(var e in listTestpec)

        }
    }
}
