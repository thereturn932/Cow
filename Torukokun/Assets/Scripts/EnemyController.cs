using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    [SerializeField]
    private int healthPoints = 100;
    public float movementSpeed = 5;

    public float MaxDist = 100;
    public GameObject Player;
    private bool gotHit;

    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, Player.transform.position) <= MaxDist || gotHit)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z), movementSpeed * Time.deltaTime);
        }

        if (healthPoints <= 0)
        {
            Destroy(transform.parent.gameObject);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Projectile")
        {
            Damaged(other.gameObject.GetComponent<SkillStats>().damage);
            Destroy(other.gameObject);
            gotHit = true;
        }
        Debug.Log("Hit");
    }
    void Damaged( int damage)
    {
        healthPoints -= damage;
    }
}
