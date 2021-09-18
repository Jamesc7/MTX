using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScene4 : MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (DialogueTrigger.number == 1 && DialogueTrigger.sceneCounter == 3)
        {
            if (MoveHydrogen.enableNext == false)
            {
                playAudio.triggerLock = true;
            }
            else
            {
                playAudio.triggerLock = false;
                
            }
        }
        else if (DialogueTrigger.number == 2 && DialogueTrigger.sceneCounter == 3)
        {
            if (textAppear.enableNext == false)
            {
                playAudio.triggerLock = true;
            }
            else
            {
                playAudio.triggerLock = false;
                
            }

        }
    }
}
