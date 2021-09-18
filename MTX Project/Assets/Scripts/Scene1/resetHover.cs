using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetHover : MonoBehaviour {

    bool reset = false;

	// Use this for initialization
	void Start () {
        DialogueTrigger.hoverStart = reset;
        //reset values for scene 4
        MoveHydrogen.enableNext = false;
        textAppear.enableNext = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
