using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace Excel_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Students.xls");

            // Console.WriteLine(path);
            Excel.Application app = new Excel.Application();
            string workingPath = Application.StartupPath + path;
            Excel.Workbook xlfieald = app.Workbooks.Open(workingPath);
            Excel._Worksheet xlWorksheet = xlfieald.Sheets[1];
            Excel.Range xlsRange = xlWorksheet.UsedRange;
                                 
            for (int i = 2; i <= xlsRange.Rows.Count; i++)
            {

                string tempName = xlsRange.Cells[i, 1].Value.ToString();
                string tempSurname = xlsRange.Cells[i, 2].Value.ToString();
                int tempYear = Int32.Parse(xlsRange.Cells[i, 3].Value.ToString());
                int tempKnownLang = Int32.Parse(xlsRange.Cells[i, 4].Value.ToString());
                int tempPhone = Int32.Parse(xlsRange.Cells[i, 5].Value.ToString());
                Student student = new Student(tempName, tempSurname, tempYear, tempKnownLang, tempPhone);
                students.Add(student);
            }

            string pathFilter = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Filter.xls");

            // Console.WriteLine(path);
            Excel.Application appFilter = new Excel.Application();
            string workingPathFilter = Application.StartupPath + pathFilter;
            Excel.Workbook xlfiealdFilter = appFilter.Workbooks.Open(workingPath);

            Excel._Worksheet xlWorksheetFilter = xlfiealdFilter.Sheets[1];
            Excel.Range xlRangeFilter = xlWorksheetFilter.UsedRange;
           

            Filter filterByName = new FilterWithOneParameter(xlRangeFilter.Cells[1, 1].Value.ToString());
            Filter filterBySurname = new FilterWithOneParameter(xlRangeFilter.Cells[2, 1].Value.ToString());            Filter filterByPhone=new FilterWithOneParameter(xlRangeFilter.Cells[5, 1].Value.ToString());

            int birthDayFrom = Int32.Parse(xlRangeFilter.Cells[3, 1].Value.ToString());
            int birthDayTo = Int32.Parse(xlRangeFilter.Cells[3, 2].Value.ToString());

            int knownLangFrom = Int32.Parse(xlRangeFilter.Cells[4, 1].Value.ToString());
            int knownLangTo = Int32.Parse(xlRangeFilter.Cells[4, 2].Value.ToString());

            Filter filterRangBirthDay = new FilterWithTwoParameters(birthDayFrom, birthDayTo);            Filter filterRangLang = new FilterWithTwoParameters(knownLangFrom, knownLangTo);
            List<Student> filteredName = students.Select(x => x).Where(filterByName.GetValues()).ToList();            List<Student> filteredSurname = students.Select(x => x).Where(filterBySurname.GetValues()).ToList();            List<Student> filteredBirthDay = students.Select(x => x).Where(filterRangBirthDay.GetValues()).ToList();            List<Student> filteredLanguage= students.Select(x => x).Where(filterRangBirthDay.GetValues()).ToList();
            List<Student> filteredPhone= students.Select(x => x).Where(filterByPhone.GetValues()).ToList();            
            Console.WriteLine("Yst anvan: \n ");
            foreach (var i in filteredName)
            {
                Console.WriteLine(i.Name + "\n");
            }
            Console.WriteLine("Yst azganvan: ");

            foreach (var i in filteredSurname)
            {
                Console.WriteLine(i.Surname + "\n");
            }
            Console.WriteLine("Yst cnndyan tvakani: ");
            foreach (var i in filteredBirthDay)
            {
                Console.WriteLine(i.YearOfBirth + "\n");            }
            Console.WriteLine("Yst cragravorman lezuneri:");            
            foreach (var i in filteredLanguage)            {                Console.WriteLine(i.NumberOfKnownProgrammingLanguages + "\n");
            }

            Console.WriteLine("Yst heraxosahamarneri: ");            foreach (var i in filteredPhone)
            {
                Console.WriteLine(i.PhoneNumber + "\n");
            }
        }
    }
}
