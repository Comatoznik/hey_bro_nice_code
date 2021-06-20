using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Diplom
{
    public class Log
    {
        public static void Logger(string text)
        {   
            string path = "E:\\log.txt";
            File.AppendAllText(path, text +" " + DateTime.Now + "\n") ;
            
        }
    }
}
