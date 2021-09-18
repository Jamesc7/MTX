using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlight : MonoBehaviour {
    Renderer rend;
    Color yellow;
    Color invisible;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        yellow = new Color(1, 1, 0, 1);
        invisible = new Color(1, 1, 0, 0);
    }

    public void ChangeYellow ()
    {
        rend.material.SetColor("_OutlineColor", yellow);
    }

    public void ChangeInvisible()
    {
        rend.material.SetColor("_OutlineColor", invisible);
    }
}
