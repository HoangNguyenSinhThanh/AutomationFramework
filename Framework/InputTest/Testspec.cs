using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelFileFramworkHandle
{

    public class Testspec
    {
        string description = "Description";
        string testId = "TestId";
        List<string> teststep = new List<string>();

        public Testspec(List<string> listString)
        {
            var queue = new Queue<string>(listString);
            description = queue.Dequeue();
            testId = queue.Dequeue();
            teststep = queue.ToList<string>();
        }

        public override string ToString()
        {
            return $"{description} - {testId} - {teststep}";
        }
    }
}
