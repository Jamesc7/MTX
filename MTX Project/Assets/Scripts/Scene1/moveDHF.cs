using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDHF : MonoBehaviour {
    float timer;
    Animator animator;
    public GameObject text;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (DialogueTrigger.number == 3)
        {
            timer += Time.deltaTime;
            if (timer > 1.5f && timer < 2.2f)
            {
                animator.SetBool("moveDHF", true);
            }
            else if (timer >= 2.3f && timer <= 2.4f)
            {
                text.SetActive(true);
                //Enables to go next line. true in FolateAnim
                playAudio.triggerLock = false;
            }
        }
	}
}
