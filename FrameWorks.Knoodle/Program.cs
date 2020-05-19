using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EntitySpaces.Interfaces;

namespace Weaselware.Knoodle
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            esProviderFactory.Factory =
            new EntitySpaces.Loader.esDataProviderFactory();   
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
