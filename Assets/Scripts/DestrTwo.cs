using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrTwo : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("TorsTwo") || collider.gameObject.CompareTag("HeadTwo") || collider.gameObject.CompareTag("FootTwo"))
        {
           
            Destroy(gameObject);
        }
    }
}
