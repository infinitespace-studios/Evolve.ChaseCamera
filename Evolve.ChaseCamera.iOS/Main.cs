#region Using Statements
using System;

using Foundation;
using UIKit;

#endregion


namespace Evolve.ChaseCamera.iOS
{
	[Register("AppDelegate")]
    class Program : UIApplicationDelegate
    {
        private static ChaseCameraGame game;

        internal static void RunGame()
        {
            game = new ChaseCameraGame();
            game.Run();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            UIApplication.Main(args, null, typeof(Program));
        }

        public override void FinishedLaunching(UIApplication app)
        {
            RunGame();
        }
    }
}
}
