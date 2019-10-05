using Statistics.Components;
using UnityEngine;
using Unlock.Events;

namespace Unlock.Components
{
	public class GameOpened : MonoBehaviour
	{
		public Timer Timer;

		public float Time;

		public Models.Unlock Data;

		public UnlockedEvent Unlocked;

		void Update()
		{
			if (!(Timer.Value > Time)) return;
			Unlocked.Invoke(Data);
			enabled = false;
		}
	}
}
