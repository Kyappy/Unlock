using UnityEngine;

namespace Unlock.Models
{
	[CreateAssetMenu(menuName = "Unlock/Models/Unlock")]
	public class Unlock : ScriptableObject
	{
		public string Title;
		public string Description;
		public string Available;
		public Texture2D Image;
	}
}
