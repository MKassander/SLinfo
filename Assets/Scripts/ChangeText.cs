using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    private Text Text => GetComponentInChildren<Text>();

    public List<string> infoTexts;
    private int index = 0;

    void Start()
    {
        Text.text = infoTexts[0];
    }

    public void SetNextText()
    {
        Text.text = infoTexts[index++];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Text.text = infoTexts[0];
        if (Input.GetKeyDown(KeyCode.Alpha2)) Text.text = infoTexts[1];
        if (Input.GetKeyDown(KeyCode.Alpha3)) Text.text = infoTexts[2];
        if (Input.GetKeyDown(KeyCode.Alpha4)) Text.text = infoTexts[3];
    }
}
