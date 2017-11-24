using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour {

    private Animator myAnimator;

    [SerializeField]
    private float MovementSpeed = 1;

    private bool facingRight;

    public bool Attack { get; set; }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
} 
