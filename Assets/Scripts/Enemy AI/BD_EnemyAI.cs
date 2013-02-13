using UnityEngine;
using System.Collections;

public class BD_EnemyAI : MonoBehaviour
{
    public float speed;
    public int Health = 20;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 newPosition = transform.position;
	    newPosition.y -= speed * Time.deltaTime;
	    transform.position = newPosition;

	}
}
