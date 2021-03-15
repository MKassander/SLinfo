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
    private MoveTextPanel MoveTextPanel => GetComponent<MoveTextPanel>();
    public Text text;

    public List<string> tasks;
    private int listIndex = 0;

    private void Start()
    {
        text.text = tasks[listIndex];
    }

    public void OnTaskDone()
    {
        MoveTextPanel.ResetBools();
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

    void NewTask()
    {
        listIndex++;
        text.text = tasks[listIndex];
        MoveTextPanel.turn = true;
    }
}
