using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHeadTwo : MonoBehaviour {
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
        if (collider.gameObject.CompareTag("Bullet"))
        {
            Instantiate(particleSyst, transform.position, transform.rotation);
            RightChar.Health -= 3;
            krik.Play();
            Debug.Log("AttackHeadTwo");
        }
    }
}
