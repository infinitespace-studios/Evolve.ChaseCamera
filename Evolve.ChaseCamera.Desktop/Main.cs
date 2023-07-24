#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;


#endregion

namespace Evolve.ChaseCamera.Desktop
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main (string[] args)
		{
			var game = new ChaseCameraGame ();
			game.Run ();
		}
	}
}


