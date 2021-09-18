using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableArrows : MonoBehaviour {

    public static bool arrowMTX = false;
    public static bool arrowFolate = false;

    private float time = 0f;

    public GameObject arrowF;
    public GameObject arrowM;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (DialogueTrigger.number == 2)
        {
            arrowMTX = false;
            time += Time.deltaTime;
            if (time > 3.55f)
            {
                arrowFolate = true;
            }
            
        }
        else if (DialogueTrigger.number == 3)
        {
            arrowFolate = false;
            arrowMTX = true;
        }

        else if (DialogueTrigger.number == 4)
        {
            arrowMTX = false;
        } else
        {
            arrowMTX = false;
            arrowFolate = false;
        }


        //literally bad coding
        if (arrowMTX == true)
        {
            arrowM.SetActive(true);
        }
        else
        {
            arrowM.SetActive(false);
        }

        if (arrowFolate == true)
        {
            arrowF.SetActive(true);
        }
        else
        {
            arrowF.SetActive(false);
        }
	}
}
