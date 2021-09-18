using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR;

public class FolateAnim : MonoBehaviour
{

    // Moves the Folate to the right, and activates the DHFR

    Animator animator;
    public static bool appear;
    public GameObject appearingMolecule;
    public GameObject NADPH;
    private float timer = 0;
    bool trigger = false;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        appear = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueTrigger.number == 3 /*DialogueTrigger.sentences.Length && trigger == false*/)
        {
            //Disables next line until animation is done in moveDHF script
            playAudio.triggerLock = true;

            if (timer < 2)
            {
                // If the timer is less than 2 seconds and the current line of dialogue is 2, set the DHFR to active
                appearingMolecule.SetActive(true);
            }
            
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                // If the timer has exceeded 2 seconds, Folate starts moving right. It waits until after 2 seconds to allow time for the DHFR to do its animation
                animator.SetBool("MoveRight", true);
            }
            appear = true;
        }
        // After 4 seconds, set the gameobject to false
        if (timer >= 4 && appear == true && trigger == false)
        {
            appear = false;
            trigger = true;
            NADPH.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
