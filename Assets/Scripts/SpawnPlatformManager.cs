using UnityEngine;
using System.Collections;

public class SpawnPlatformManager : MonoBehaviour {

	public int maxPlatforms = 20;
	public GameObject platform;
	//public GameObject platformWin;
	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -6f;
	public float verticalMax = 6f;

	private Vector2 originPosition;


	// Use this for initialization
	void Start () {
		originPosition = transform.position;
		Spawn ();
	}

	void Spawn() { 
		for (int i = 0; i < maxPlatforms; i++) {
			Vector2 randomPosition = originPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			Instantiate (platform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
		}
		//Vector2 winPos = originPosition + new Vector2 (0f, 3f); // testzwecke, diese beiden zeilen sind überflüssig
		//winPos = originPosition;
		//Instantiate (platformWin, winPos, Quaternion.identity); 
	}
}
