using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class RightChar : MonoBehaviour {
    Animator AnimTwo;
    public Transform groundCheckTransform;
    public LayerMask groundCheckLayerMask;
    private bool grounded;
    public GameObject PlOne;
    public GameObject RipOne;
    public static int Health = 15;
    public Text healthText;
    public GameObject StrelkaTwo;
	// Use this for initialization
	void Start () {
        AnimTwo = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (PlOne == null)
        {
            RipOne.SetActive(true);
            StrelkaTwo.SetActive(true);
        }
        healthText.text = Health.ToString();
        if (Health <= 0)
        {
           
            AnimTwo.SetBool("die", true);
            Health = 0;
            Destroy(gameObject, 0.7f);
            Debug.Log("GameOver");
        }
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.collider.tag == "PlayerTwo")
            {
                Debug.Log("Anim");
                AnimTwo.SetBool("JumpTwo", true);

            }
            if (hit.collider.tag == "Exit")
            {
                Application.Quit();
                Debug.Log("Exit");


            }
            if (hit.collider.tag == "Replay")
            {
                Application.LoadLevel("Play");
                Health = 15;
               leftChar.Health = 15;
                Debug.Log("Exit");


            }

        }
	}
    void FixedUpdate()
    {
        UpdateGroundedStatus();
    }
    void UpdateGroundedStatus()
    {
        //1
        grounded = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, groundCheckLayerMask);

        //2
        AnimTwo.SetBool("JumpTwo", grounded);
    }
}
