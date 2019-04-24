using System;
using GTA;
using GTA.Native;
using System.Windows.Forms;

namespace ScriptHookTest
{
	public class ScriptHookTest : Script
	{
		public ScriptHookTest()
		{
			this.Tick += OnTick;
			this.KeyDown += OnKeyDown;
			UI.Notify("ScriptHookTest Reloaded");
		}

		private void OnKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.J)
			{
				// write your test here, debug using UI.Notify.
				Ped player = Game.Player.Character;
				// Note: this is already available as player.Position,
				// but I'm showcasing how to call hooks directly if desired.
				var pos = Function.Call<GTA.Math.Vector3>(Hash.GET_ENTITY_COORDS, player.Handle, 0);
				UI.Notify($"Current Position: {pos}");
			}
		}

		private void OnTick(object sender, EventArgs e)
		{
			// do something every tick.
		}
	}
}
