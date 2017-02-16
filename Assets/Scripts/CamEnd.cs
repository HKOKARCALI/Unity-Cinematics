using UnityEngine;
using System.Collections;

public class CamEnd : MonoBehaviour {

	public void OnAnimationEnd() {
		AnimationManager.instance.DestroyCamera(gameObject);
	}
}
