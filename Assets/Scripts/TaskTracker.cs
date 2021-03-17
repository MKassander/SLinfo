using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskTracker : MonoBehaviour
{
    public float returnAfter = 2;
    public Text text;

    public List<string> tasks;
    private int listIndex = 0;

    private void Start()
    {
        text.text = tasks[listIndex];
    }

    public void OnTaskDone()
    {
        Invoke(nameof(NewTask), returnAfter);
    }

    void NewTask()
    {
        listIndex++;
        text.text = tasks[listIndex];
    }
}
