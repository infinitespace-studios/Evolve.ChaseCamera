#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
#endregion

namespace Evolve.ChaseCamera.Desktop
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var game = new ChaseCameraGame ();
            game.Run();
        }
    }
}
