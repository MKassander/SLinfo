using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskTracker : MonoBehaviour
{
    public float moveAfter = 1;
    public float returnAfter = 2;
    public float resetAfter = 3;
    public Image image;
    private MoveTextPanel MoveTextPanel => GetComponent<MoveTextPanel>();
    public Text text;

    public List<string> tasks;
    private int listIndex = 0;

    private void Start()
    {
        text.text = tasks[listIndex];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) OnTaskDone();
        if (Input.GetKeyDown(KeyCode.P)) NewTask();
    }

    public void OnTaskDone()
    {
        MoveTextPanel.ResetBools();
        ShowCheckmark();
        Invoke(nameof(MovePanel), moveAfter);
        Invoke(nameof(NewTask), returnAfter);
        Invoke(nameof(ResetBools), resetAfter);
    }

    void MovePanel()
    {
        MoveTextPanel.startMove = true;
    }
    
    void ResetBools()
    {
        MoveTextPanel.ResetBools();
    }

    void ShowCheckmark()
    {
        image.color = Color.green;
    }

    void HideCheckmark()
    {
        image.color = Color.clear;
    }

    void NewTask()
    {
        text.text = tasks[listIndex+1];
        MoveTextPanel.turn = true;
        HideCheckmark();
    }
}
