using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSomething : MonoBehaviour {

    public GameObject myFireball;
    public Transform SpawnPoint;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
	}

    void Fire()
    {
        var projectile = (GameObject)Instantiate( myFireball, SpawnPoint.position, SpawnPoint.rotation);

        projectile.GetComponent<Rigidbody>().velocity = -projectile.transform.forward * 6;
       
        Destroy(projectile, 2.0f);
    }
}
