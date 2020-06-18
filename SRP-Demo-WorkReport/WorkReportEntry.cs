using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo_WorkReport
{
    public class WorkReportEntry
    {
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int SpentHours { get; set; }
    }

//public class FileSaver
//    {
//        public void SaveToFile(string directoryPath, string fileName, WorkReport report)
//        {
//            if (!Directory.Exists(directoryPath))
//            {
//                Directory.CreateDirectory(directoryPath);
//            }

//            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
//        }
//    }

}
