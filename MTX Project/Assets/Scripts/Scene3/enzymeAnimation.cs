using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enzymeAnimation : MonoBehaviour {
    private TextMesh textMesh;
    private bool startTimer = true;
    float time;
    Animator animator;
    Animator other;
    public static bool forText;
    public GameObject Enzyme;

    
    private bool triggerOnce = false;

    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        other = Enzyme.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (DialogueTrigger.number == 2)
        {
            startTimer = false;
            if (gameObject.CompareTag("Enzyme"))
            {
                animator.SetBool("moveEnzyme", true);
                animator.SetBool("moveEnzymeDown", true);
            }
            else if (gameObject.CompareTag("Enzyme1"))
            {
                animator.SetBool("moveEnzyme1", true);
                animator.SetBool("moveEnzymeDown1", true);
            }
        }
        if (!startTimer) time += Time.deltaTime;
        
        if (triggerOnce == false)
        {
            if (time > 2.2f && time < 2.29f)
            {
                other.SetBool("movespaghetti", true);
                other.SetBool("movespaghetti2", true);
                forText = true;
                triggerOnce = true;
            }
        }
    }
}
