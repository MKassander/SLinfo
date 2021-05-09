using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskTracker : MonoBehaviour
{
    public Text task;

    public List<string> tasks;
    private int listIndex = 0;

    private void Start()
    {
        task.text = tasks[listIndex];
    }

    public void OnTaskDone()
    {
        NewTask();
    }

    void NewTask()
    {
        listIndex++;
        task.text = tasks[listIndex];
    }
}
