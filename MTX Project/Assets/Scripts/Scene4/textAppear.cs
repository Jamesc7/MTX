using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textAppear : MonoBehaviour {

    float timer;
    public static bool enableNext = false;
    public static bool turnBlue;
    public GameObject text1;
    public GameObject text2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        //timer < 4.5
        if (timer > 3.0f && timer < 3.1f)
        {
            text1.SetActive(true);
        }
        //timer < 8.5        
        else if (timer > 5.3f && timer < 5.4f)
        {
            text1.SetActive(false);
        }

        if (timer > 4.3f && timer < 4.4f)
        {
            text2.SetActive(false);
            turnBlue = true;
            enableNext = true;
        }
        
	}
}
