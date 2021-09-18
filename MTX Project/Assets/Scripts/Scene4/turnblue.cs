using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnblue : MonoBehaviour {

    
    Material material;
    Renderer rend;
    private TextMesh textMesh;
    Color darkblue = new Color(0f, .3216f, .4528f, 1f);
    Color blue = new Color(.5294f, .8078f, .9215f, 1f);
    Color redd = new Color(.7264f, .0445f, 1470f, 1f);
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        material = GetComponent<Renderer>().material;
        textMesh = GetComponentInChildren<TextMesh>();
        textAppear.turnBlue = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (textAppear.turnBlue)
        {

            rend.material.color = Color.Lerp(blue, darkblue, Mathf.PingPong(Time.time, 2)/2);
            textMesh.text = "Enzyme is <color=red>disabled</color>" + "\n" + "No reduction"; //+ hand.name;
            transform.GetChild(0).GetChild(0).gameObject.SetActive(true);

        }
        



    }
}
