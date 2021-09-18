using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCredit : MonoBehaviour {

    private float timer = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        //Debug.Log(timer);
        if (timer >= 10)
        {
            SceneManager.LoadScene("(1) Folate And MTX Animation", LoadSceneMode.Single);
        }

    }
}
