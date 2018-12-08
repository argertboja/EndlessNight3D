using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotionIntro : MonoBehaviour {

    // Variables
    [SerializeField]
    private Transform[] targets; //Holds the waypoints
    [SerializeField]
    private float speed; //moving speed of character
    [SerializeField]
    private float rotationSpeed; //rotation speed toward waypoint

    private int current;
	
	// Update is called once per frame
	void Update () {
        if (transform.position != targets[current].position) {
            // Move to next waypoint and look at it
            Vector3 newPosition = Vector3.MoveTowards(transform.position, targets[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(newPosition);
            //Find direction where to look at
            Vector3 direction = targets[current].position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
        else current = current + 1;
	}
}
