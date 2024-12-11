using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static  class LogManager
    {
        private static readonly string path = "Log";
        public static string getCurrentFolderPath()
        {
            return DateTime.Now.Year+@"\"+ DateTime.Now.Month;
            
        }
        public static string getCurrentFilePath()
        {
            return DateTime.Now.Year+@"\"+DateTime.Now.Month+@"\"+ DateTime.Now.Day;

        }

        public static void cleanLog()
        {
            var directories = Directory.GetDirectories(path);

            foreach (var d in directories)
            {
                var yearDirectories = Directory.GetDirectories(d);
                foreach (var  dir in yearDirectories)
                {
                    if (Directory.GetCreationTime(dir).Month!=DateTime.Now.Month&& (Directory.GetCreationTime(dir).Month != DateTime.Now.Month-1))
                        Directory.Delete(dir, true);
                }
            }
        }
        public static void writeToLog(string projectName,string func,string message) {
            string rootIncludeDay = path+ @"\"+ DateTime.Now.Year + @"\" + DateTime.Now.Month + @"\" + DateTime.Now.Day;
            string rootIncludeMonth = path + @"\" + DateTime.Now.Year + @"\" + DateTime.Now.Month;
                if( !Directory.Exists(rootIncludeMonth) )
                {
               Directory.CreateDirectory(rootIncludeMonth);
                FileStream fs= File.Create(rootIncludeDay + @".txt");
                fs.Close();

            }
                else if(!File.Exists(rootIncludeDay + @".txt"))
            {
                FileStream fs = File.Create(rootIncludeDay + @".txt");
                fs.Close();


            }
            
                string contentFile = $"{DateTime.Now}\t{projectName}.{func}:\t{message}";
                File.AppendAllText(rootIncludeDay + @".txt", contentFile + Environment.NewLine);
        }

       
        }
    }

   
