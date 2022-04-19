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
    public static class Extensions
    {
        public static T DeepClone<T>(this T obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Position = 0;

                return (T)formatter.Deserialize(stream);
            }
        }
    }
    public class Testspec
    {
        string testSpec = "Test spec";
        string description = "Description";
        string testId = "TestId";
        List<List<string>> teststep = new List<List<string>>();

        #region CheckFunction
        bool IsTeststep(string content)
        {
            if (content == "Test step")
                return true;
            else
                return false;
        }

        bool IsTestspec(string content)
        {
            if (content == "Test spec")
                return true;
            else
                return false;
        }

        bool IsTestId(string content)
        {
            if (content == "TestId")
                return true;
            else
                return false;
        }

        bool IsDescription(string content)
        {
            if (content == "Description")
                return true;
            else
                return false;
        }
        #endregion

        public bool CheckTitleInputSpec(ExcelFileReader excelFileReader)
        {
            var ws = excelFileReader.GetWorksheet;
            testSpec = (string)(ws.Cells[1, 1] as Excel.Range).Value;
            description = (string)(ws.Cells[2, 2] as Excel.Range).Value;
            testId = (string)(ws.Cells[2, 3] as Excel.Range).Value;
            var testStep = (string)(ws.Cells[2, 4] as Excel.Range).Value;
            if (IsTestspec(testSpec) && IsDescription(description) && IsTestId(testId) && IsTeststep(testStep))
                return true;
            else
                return false;
        }

        public List<List<string>> GetTestStep(ExcelFileReader excelFileReader)
        {
            int i = 0;
            int j = 0;
            bool checkRow = false;
            bool checkColumn = false;
            var listStep = new List<string>();
            var ws = excelFileReader.GetWorksheet;
            while (!checkColumn)
            {
                if ((ws.Cells[2 + i + 1, 4 + j] as Excel.Range).Value != null)
                {
                    while (!checkRow)
                    {
                        if ((ws.Cells[2 + i + 1, 4 + j] as Excel.Range).Value != null)
                        {
                            listStep.Add((string)(ws.Cells[2 + i + 1, 4 + j] as Excel.Range).Value);
                            j++;
                        }
                        else
                        {
                            teststep.Add(listStep.DeepClone());
                            listStep.Clear();
                            j = 0;
                            i++;
                            checkRow = true;
                        }
                    }
                    checkRow = false;
                }
                else
                {
                    checkColumn = true;
                }
            }

            return teststep;
        }
    }
}
