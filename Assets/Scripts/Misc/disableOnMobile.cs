using UnityEngine;
using System.Collections;

public class disableOnMobile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		#if UNITY_ANDROID
			this.gameObject.SetActive(false);
		#endif
	}
}
