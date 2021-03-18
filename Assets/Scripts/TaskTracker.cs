using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskTracker : MonoBehaviour
{
    public Text text;

    public List<string> tasks;
    private int listIndex = 0;

    private void Start()
    {
        text.text = tasks[listIndex];
    }

    public void OnTaskDone()
    {
        NewTask();
    }

    void NewTask()
    {
        listIndex++;
        text.text = tasks[listIndex];
    }
}
