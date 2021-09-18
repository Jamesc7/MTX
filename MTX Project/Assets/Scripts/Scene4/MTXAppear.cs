using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTXAppear : MonoBehaviour {

    public GameObject MTX;

    bool triggerOnce = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (triggerOnce == false)
        {
            if (DialogueTrigger.number == 2 && DialogueTrigger.sceneCounter == 3)
            {
                MTX.gameObject.SetActive(true);
                triggerOnce = true;
            }
        }


    }
}
