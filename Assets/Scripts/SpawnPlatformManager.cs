﻿using UnityEngine;
using System.Collections;

public class SpawnPlatformManager : MonoBehaviour {

	public int maxPlatforms = 25;
	public GameObject platform;
	public GameObject platformWin;
	public float horizontalMin = 6.5f;
	public float horizontalMax = 14f;
	public float verticalMin = -6f;
	public float verticalMax = 6f;

	private Vector2 originPosition;
	private Vector2 lastBeforeLastPosition;


	void Start () {
		originPosition = transform.position;
		Spawn ();
	}

	void Spawn() { 
		for (int i = 0; i < maxPlatforms; i++) {
			Vector2 randomPosition = originPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			Instantiate (platform, randomPosition, Quaternion.identity);
			originPosition = randomPosition;
			lastBeforeLastPosition = randomPosition;
		}

		Vector2 winPos = lastBeforeLastPosition + new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
		Instantiate (platformWin, winPos, Quaternion.identity);

		 
	}
}
