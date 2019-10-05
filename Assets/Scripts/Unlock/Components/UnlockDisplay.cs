using System;
using TMPro;
using UnityEngine;

namespace Unlock.Components
{
	public class UnlockDisplay : MonoBehaviour
	{
		public float DisplayTime;

		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescriptionText;

		public TextMeshProUGUI AvailableText;

		private float _displayedTime;

		public void Show(Models.Unlock data)
		{
			TitleText.text = data.Title;
			DescriptionText.text = data.Description;
			AvailableText.text = data.Available + " unlocked!";

			enabled = true;
		}

		private void Update()
		{
			_displayedTime += Time.deltaTime;

			if (!(_displayedTime > DisplayTime)) return;

			enabled = false;

			TitleText.text = null;
			DescriptionText.text = null;
			AvailableText.text = null;

			_displayedTime = 0;
		}
	}
}
