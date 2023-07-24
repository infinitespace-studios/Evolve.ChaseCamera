using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Content.PM;
using Android.Views;
using Android.Widget;
using Android.OS;

using Microsoft.Xna.Framework;
using Evolve.ChaseCamera.Droid;

namespace Evolve.ChaseCamera.Droid.Droid
{
	[Activity (Label = "Evolve.ChaseCamera.Droid", 
		MainLauncher = true,
		Icon = "@drawable/icon",
		Theme = "@style/Theme.Splash",
		AlwaysRetainTaskState = true,
		LaunchMode = LaunchMode.SingleInstance,
		ConfigurationChanges = ConfigChanges.Orientation |
		ConfigChanges.KeyboardHidden |
		ConfigChanges.Keyboard)]
	public class Activity1 : AndroidGameActivity
	{
		ChaseCameraGame _game;
		View _view;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create our OpenGL view, and display it
			_game = new ChaseCameraGame ();
			_view = _game.Services.GetService(typeof(View)) as View;
			SetContentView (_view);
			_game.Run ();
		}
		
	}
}


