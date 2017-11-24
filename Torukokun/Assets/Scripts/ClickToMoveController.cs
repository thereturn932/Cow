﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class ClickToMoveController : MonoBehaviour {

    public LayerMask movementMask;
    public Interactable focus;

    Camera cam;
    PlayerMotor motor;

	// Use this for initialization
	void Start () {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
              //  motor.MoveToPoint(hit.point);
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                if (interactable != null)
                {
                    SetFocus(interactable);
                }
                else
                {
                    RemoveFocus();
                }
            }
        }
	}
    void SetFocus (Interactable newFocus)
    {
        focus = newFocus;
        motor.FollowTarget(newFocus);
    }
    void RemoveFocus ()
    {
        focus = null;
        motor.StopFollowingTarget();
    }
}
