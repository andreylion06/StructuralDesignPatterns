using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.AdapterLibrary
{
    public class FileLoggerAdapter : Logger
    {
       private FileWriter _fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public override void Log(string message)
        {
            _fileWriter.WriteLine($"Log: {message}");
        }

        public override void Error(string message)
        {
            _fileWriter.WriteLine($"Error: {message}");
        }

        public override void Warn(string message)
        {
            _fileWriter.WriteLine($"Warn: {message}");
        }
    }
}
