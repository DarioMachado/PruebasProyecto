using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
namespace guidotnet;

static class Program
{
    [DllImport("kernel32.dll")]
    static extern bool AllocConsole();

    [STAThread]
    static void Main()
    {
        AllocConsole();
        Console.SetOut(Console.Out);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new Form1());
    }
}