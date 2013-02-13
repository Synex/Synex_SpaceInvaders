using UnityEngine;
using System.Collections;

public class DestroyUnderScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Destroy an object once it has fallen under the visible area
        if (transform.position.y <= -10f)
        {
            Destroy(gameObject);
        }
	
	}
}
