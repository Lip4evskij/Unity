using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrelkaTwo : MonoBehaviour {
    public float speed;

    private Vector3 target = new Vector3(4.37f, 2.16f, 0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != 2.16f)
            target.y = 2.16f;
        else if (transform.position == target && target.y == 2.16f)
            target.y = 2.8f;
	}
}
