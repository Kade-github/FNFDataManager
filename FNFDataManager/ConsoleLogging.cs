using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FNFDataManager
{
    public class ConsoleLogging : TextWriter
    {
        public override Encoding Encoding => Encoding.ASCII;

        public override void WriteLine(string value)
        {
            // Get the last element in a stack frame for the name of the calling namespace, good for organization.
            // Append it to the gamer text box
            FNFDataManagerForm.consoleOutput.Text += $@"[{new StackFrame(3).GetMethod().ReflectedType?.Name}-{DateTime.Now.ToShortTimeString()}] {value}{Environment.NewLine}";
        }

    }
}