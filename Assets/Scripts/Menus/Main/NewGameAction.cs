using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menus.Main
{
	public class NewGameAction : MonoBehaviour
	{
		public void Execute()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
