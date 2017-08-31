using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RPB : MonoBehaviour {

	public Transform LoadingBar;
	public Transform TextIndicator;
	public Transform TextLoading;
    public GameObject press;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	// Use this for initialization
	void Start () {
        //UnityEngine.Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			TextIndicator.GetComponent<Text>().text=((int)currentAmount).ToString()+"%";
			TextLoading.gameObject.SetActive (true);
		} else {
            TextLoading.gameObject.SetActive(false);
            TextIndicator.GetComponent<Text>().text = "Go!";
            if (currentAmount >99)
            {
                Debug.Log("100");
                press.SetActive(true);
            }
            if (Input.anyKeyDown) {
				Application.LoadLevel ("Play");
			}

		}
		LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
	}
}
