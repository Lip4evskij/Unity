using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Tors") || collider.gameObject.CompareTag("Head") || collider.gameObject.CompareTag("FootOne"))
        {

            Destroy(gameObject);
        }
    }
}
