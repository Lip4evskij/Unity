using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weap : MonoBehaviour
{
    public GameObject bullet;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    public AudioSource vistrel;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.collider.tag == "leftFire" && Time.time > nextFire)
            {
                vistrel.Play();
                nextFire = Time.time + fireRate;
                fire();
            }
        }
    }

      
    
    void fire()
    {
        bulletPos = transform.position;
        bulletPos += new Vector2(+1f, 0f);
        Instantiate(bullet, bulletPos, Quaternion.identity);
    }
   
}
