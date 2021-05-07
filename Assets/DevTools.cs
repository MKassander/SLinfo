using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    private SceneSwitcher SceneSwitcher => FindObjectOfType<SceneSwitcher>();

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneSwitcher.SwitchScene();
        }
    }
}
