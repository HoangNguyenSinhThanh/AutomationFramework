using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ExcelFileFramworkHandle
{
    public class ExcelFileReader
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public ExcelFileReader(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = (Worksheet)wb.Worksheets[Sheet];
        }

        void OpenFile()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = Path.Combine(sCurrentDirectory, @"..\..\..\ExcelFileFramworkHandle\InputFile\Input.xlsx");
            string sFilePath = Path.GetFullPath(sFile);
            wb = excel.Workbooks.Open(sFilePath);
            ws = (Worksheet)wb.Worksheets[1];
        }

        void Close()
        {
            wb.Close();
        }
        public Worksheet GetWorksheet
        {
            get { return ws; }
            set { ws = value; }
        }

        public Workbook GetWorkbook
        {
            get { return wb; }
            set { wb = value; }
        }
    }
}
