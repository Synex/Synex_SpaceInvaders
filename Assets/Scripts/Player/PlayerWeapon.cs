using UnityEngine;
using System.Collections;

public class PlayerWeapon : MonoBehaviour
{
    public GameObject Projectile;
    public float fireRate = 0.5F;
    private float nextFire = 0.0F;
    
	// Update is called once per frame
	void Update ()
	{
        // Fire Projectile
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            // Fire Projectile after fireRate Delay
            nextFire = Time.time + fireRate;

            // Offset projectile to fire from outside of player
            Vector3 position = new Vector3(transform.position.x, transform.position.y + (transform.localScale.y / 2));
            GameObject clone = Instantiate(Projectile, position, Quaternion.identity) as GameObject;
        }


        // Shoot with spacebar
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    Instantiate(bullet, transform.position, transform.rotation);
        //}
	   
	}
}
