using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableRotationArrow : MonoBehaviour {

    public GameObject arrow;
    private bool triggerOnce = false;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (triggerOnce == false)
        {
            if (DialogueTrigger.number == 2 && DialogueTrigger.sceneCounter == 1)
            {
                arrow.gameObject.SetActive(true);
                triggerOnce = true;
                playAudio.triggerLock = true;
            }
        }

    }
}
