using UnityEngine;
using System.Collections;

public class GibOnCollide : MonoBehaviour
{
    public GameObject[] gibs;
    public float explosionForce = 2000;
    public float spawnRadius = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // When Bullet hits Enemy
    void OnTriggerEnter()
    {
        foreach(GameObject gib in gibs)
        {
            GameObject gibInstance = Instantiate(gib, transform.position + Random.insideUnitSphere*spawnRadius, transform.rotation) as GameObject;
            gibInstance.rigidbody.AddExplosionForce(explosionForce,transform.position,spawnRadius);
        }
        Destroy(gameObject);
    }
}
