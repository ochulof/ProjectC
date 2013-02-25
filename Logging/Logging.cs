using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
namespace Logging
{
    public class Logging
    {
        private String fileNameValue;


        public String FileName
        {
            get
            {
                return fileNameValue;
            }
            set
            {
                fileNameValue = value;
            }
        }

        public Logging() { }

        // in windows forms kent hij de configuration manager niet, dus indien we een integer meegeven bij aanroep creërt hij hier automatisch het path
        public Logging(int i)
        {
            this.FileName = "C:\\databank\\WebService.log";
        }

        public Logging(String FileName)
        {
            this.FileName = FileName;
        }


        public void WriteLine(String App, String Line)
        {
            StreamWriter writer = null;
            try
            {
                using (writer = new StreamWriter(FileName, true))
                {
                    String prefix = DateTime.UtcNow.ToString("dd/MM/yyyy hh:mm:ss UTC") + " : App : " + App.PadRight(20) + " - ";

                    Line = prefix + Line;

                    Line = Line.Replace("/n", "/n" + prefix);

                    writer.WriteLine(Line);
                    writer.Flush();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                writer.Close();
                writer = null;
            }
        }

        public void WriteLine(String App, Exception ex)
        {
            StreamWriter writer = null;
            String Line;
            try
            {
                using (writer = new StreamWriter(FileName, true))
                {
                    String prefix = DateTime.UtcNow.ToString("dd/MM/yyyy hh:mm:ss UTC") + " : App : " + App.PadRight(20);

                    Line = prefix + " - " + "Message : " + ex.Message;
                    writer.WriteLine(Line);

                    var currentStack = new StackTrace(ex, 0, true);
                    StackFrame[] stackFrames = currentStack.GetFrames();

                    for (int i = stackFrames.Length - 1; i >= 0; i--)
                    {

                        Line = prefix + " - " + "Source : " + System.IO.Path.GetFileName(stackFrames[i].GetFileName()) + " Methode : " + stackFrames[i].GetMethod() + " Line : " + stackFrames[i].GetFileLineNumber();
                        writer.WriteLine(Line);
                        prefix = prefix + "   ";
                    }
                    writer.Flush();
                }
            }
            catch (Exception exept)
            {
                throw exept;
            }
            finally
            {
                writer.Close();
                writer = null;
            }
        }

    }
}
