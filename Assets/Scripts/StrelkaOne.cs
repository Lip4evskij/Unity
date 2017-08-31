using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrelkaOne : MonoBehaviour {
    public float speed;

    private Vector3 target = new Vector3(-9.6f, 2.25f, 0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != 2.25f)
            target.y = 2.25f;
        else if (transform.position == target && target.y == 2.25f)
            target.y = 2.7f;
	}
}
