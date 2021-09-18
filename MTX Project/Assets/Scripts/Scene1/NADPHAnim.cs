using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;

public class NADPHAnim : MonoBehaviour {

    Animator animator;
    public static bool appear;
    public GameObject enzymeText;
    private float timer;
    //public float timeLeft;
    //bool moveLeft;
    //bool moveRight;

    //GameObject folateAnim;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (DialogueTrigger.number == 3 /*DialogueTrigger.sentences.Length*/)
        {
            timer += Time.deltaTime;
            if (timer >= 2 && timer <= 2.1)
            {
                // If the timer has exceeded 2 seconds, NADPH starts moving left. It waits until after 2 seconds to allow time for the DHFR to do its animation
                //DialogueTrigger.stop = true;
                animator.SetBool("MoveLeft", true);
                enzymeText.gameObject.SetActive(true);
            }
            appear = true;

        }

    }
}
