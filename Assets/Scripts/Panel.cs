using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour {
    public GameObject pan;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (leftChar.Health <= 0 || RightChar.Health <= 0)
        {
            pan.SetActive(true);
        }
	}
}
