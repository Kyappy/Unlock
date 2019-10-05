using UnityEngine;

namespace Statistics.Components
{
	public class Timer : MonoBehaviour
	{
		public float Value { get; private set; }

		private void OnEnable()
		{
			Value = 0;
		}

		private void Update()
		{
			Value += Time.deltaTime;
		}
	}
}
