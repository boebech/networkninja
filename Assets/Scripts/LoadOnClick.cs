using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnClick: MonoBehaviour {
	[SerializeField]
	private GameObject loadingImage;

	public void loadScene (string scene){
		loadingImage.SetActive (true);
		SceneManager.LoadScene (scene);
	}

}
