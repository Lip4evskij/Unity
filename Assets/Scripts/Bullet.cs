using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public Transform particleSyst;
    public AudioSource metal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Racket"))
        {
            metal.Play();
            Instantiate(particleSyst, transform.position, transform.rotation);
            Destroy(gameObject,0.11f);
        }
    }
}
