using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHead : MonoBehaviour {
    public Transform particleSyst;
    public AudioSource krik;
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
            Instantiate(particleSyst, transform.position, transform.rotation);
            leftChar.Health -= 3;
            krik.Play();
            Debug.Log("AttackHead");
        }
    }
}
