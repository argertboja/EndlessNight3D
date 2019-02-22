/*
 * @author: Argert Boja 
 * @company: ABEnt.
 * @date: 8/12/2018
 * @version: 1.0.0.0
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotionIntro : MonoBehaviour {

    // Variables
    [SerializeField]
    private Transform[] targets; //Holds the waypoints
    [SerializeField]
    private float speed; //moving speed of character

    private int current;
	
	// Update is called once per frame
	void Update () {
        if (transform.position != targets[current].position) {
            // Move to next waypoint and look at it
            Vector3 newPosition = Vector3.MoveTowards(transform.position, targets[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(newPosition);
            //Find direction where to look at
            Vector3 direction = new Vector3( targets[current].transform.position.x, transform.position.y, targets[current].transform.position.z);
            transform.LookAt(direction);
        }
        else {
            current = current + 1;
        }
	}
}
