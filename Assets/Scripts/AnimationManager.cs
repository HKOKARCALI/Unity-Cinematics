using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnimationManager : MonoBehaviour {

	public static AnimationManager instance = null;

	[SerializeField] private List<GameObject> cameras = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy(gameObject);
		}
	}

	void StartNextCamera() {
		cameras[0].SetActive(true);
	}
	
	public void DestroyCamera(GameObject camera) {
			cameras.RemoveAt(0);
			Destroy(camera);
			StartNextCamera();
		
	}
}
