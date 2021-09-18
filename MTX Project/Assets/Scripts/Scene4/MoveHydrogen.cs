using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHydrogen : MonoBehaviour {

    public static bool enableNext = false;
    public static bool start;
    private Animator animator;
    GameObject hydrogen;
    Renderer rend;
    float timer;
    public GameObject DHF;
    TextMesh textmesh;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        hydrogen = transform.GetChild(0).GetChild(81).gameObject;
        rend = GetComponent<Renderer>();
        textmesh = GetComponentInChildren<TextMesh>();
        //rend = transform.GetChild(0).GetChild(81).gameObject;
        //rend.material.shader = Shader.Find("Border");
        timer = 0;
    }

    // Update is called once per frame
    void Update () {
        
        //start = true;
        timer += Time.deltaTime;
        if (timer >= 4.5f && timer <= 6.0f/*animator.GetBool("moveHydrogen") == true*/)
        {
            // Calls the "ChangeYellow" function on the "highlight" script on the hydrogen game object
            hydrogen.GetComponent<highlight>().ChangeYellow();
            //rend.material.SetColor("_OutlineColor", new Color(1, 1, 0, 1));
        }
        else
        {
            // Calls the "ChangeInvisible" function on the "highlight" script on the hydrogen game object
            hydrogen.GetComponent<highlight>().ChangeInvisible();
            //rend.material.SetColor("_OutlineColor", new Color(1, 1, 0, 0));
        }

        if (timer >= 9.21f && timer <= 9.45f) 
        {
            transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
            textmesh.text = "Reduction is <color=green>occuring</color>";
            enableNext = true;
        }
        /*
        if (timer >= 9.21f && timer <= 9.3f)
        {
            DialogueTrigger.stop = true;
            Debug.Log("true");

        }
            */


        // Change this VVVV
        /*if (timer >= 10.0f)
        {
            DHF.SetActive(true);
        }*/
    }
}
