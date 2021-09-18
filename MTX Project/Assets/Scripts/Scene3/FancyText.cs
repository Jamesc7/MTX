using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FancyText : MonoBehaviour {
    private TextMesh textMesh;
    private Sprite sprite;
    // Use this for initialization

    void Awake () {
        textMesh = GetComponentInChildren<TextMesh>();
    }
	
	// Update is called once per frame
	void Update () {
		if (enzymeAnimation.forText)
        {
            if (CompareTag("F2"))
            {
                transform.GetChild(2).gameObject.SetActive(true);
                textMesh.text = "3.1 Angstrom";
            } else {
                transform.GetChild(2).gameObject.SetActive(true);
                textMesh.text = "5.1 Angstrom";
                enzymeAnimation.forText = false;
            }
        }
        
        textMesh.color = Color.Lerp(Color.black, Color.red, Mathf.PingPong(Time.time, 1));
	}
}
