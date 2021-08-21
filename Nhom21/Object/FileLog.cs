using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Nhom21.Object
{
    class FileLog
    {
        private static string filename = "_log.txt";

        public static void clearFile()
        {
            using (FileStream fs = File.Open(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                lock (fs)
                {
                    fs.SetLength(0);
                }
            }
            
        }

        public static void writeln(string content)
        {
            using (FileStream fs = File.Open(filename, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(content);
                }

            }
        }
        public static void write(string content)
        {
            using (FileStream fs = File.Open(filename, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(content);
                }

            }
        }

        public static void writeGT(List<string> GT)
        {
            using (FileStream fs = File.Open(filename, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    string tmp = "Tập giả thiết GT={";
                    for(int i=0; i< GT.Count; i++)
                    {
                        tmp += GT[i];
                        if (i < GT.Count - 1)
                        {
                            tmp += ", ";
                        }
                    }
                    tmp += "}";
                    sw.WriteLine(tmp);
                }
            }
        }
        public static void writeRule(List<Rule> R)
        {
            using (FileStream fs = File.Open(filename, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    try
                    {
                        sw.WriteLine("Tập luật :");
                        foreach (Rule item in R)
                        {
                            sw.WriteLine(item.ToString());
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.StackTrace);
                    }
                    
                    
                }
            }
        }
        public static void writeSAT(Queue<Rule> SAT)
        {
            List<Rule> tmp = new List<Rule>(SAT);
            using (FileStream fs = new FileStream(filename, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {

                    string t = "SAT={";
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        t += tmp[i].id;
                        if (i != tmp.Count - 1)
                        {
                            t += ",";
                        }
                    }
                    t += "}";
                    sw.WriteLine(t);
                }
            }
        }

        public static string readfile()
        {
            string tmp = "";
            using (FileStream fs = File.Open(filename, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        tmp += sr.ReadLine()+"\n";
                    }
                }

            }
            return tmp;
        }
    }
}
