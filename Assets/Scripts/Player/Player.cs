using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float PlayerSpeed = 12.0f; // Default player speed
    public int Lives = 3;             // Default ammount of player lives
	
	// Update is called once per frame
	void Update ()
	{
        // Player Movement limited to the X-Axis
	    Vector3 newPosition = transform.position;
	    newPosition.x += Input.GetAxis("Horizontal") * PlayerSpeed * Time.deltaTime;
	    
        // Move Player
        transform.position = newPosition;

        // Limmit Player to screen
        if (transform.position.x <= -13.168f)
            transform.position = new Vector3(-13.168f,transform.position.y);
        else if (transform.position.x >= 13.168f)
            transform.position = new Vector3(13.168f, transform.position.y);
	}
}
