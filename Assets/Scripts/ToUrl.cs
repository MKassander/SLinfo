using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToUrl : MonoBehaviour
{
    public string url;

    public void ButtonPress()
    {
        Application.ExternalEval("window.open(" + url + ");");
    }
}
