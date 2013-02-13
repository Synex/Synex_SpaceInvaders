using UnityEngine;
using System.Collections;

public class DestroyOnInvisible : MonoBehaviour {
	// Destroying objects outside of the screen to save memory
	void OnBecameInvisible() 
    {
        Destroy(gameObject);
	}
}
