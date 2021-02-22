using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTextPanel : MonoBehaviour
{
    public float smoothTime;

    public RectTransform turnPoint;
    private Vector3 startPos;
    
    Vector3 velocity = Vector3.zero;

    public bool startMove;
    public bool turn;

    private void Start()
    {
        startPos = GetComponent<RectTransform>().position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) startMove = true;

        if (Input.GetKeyDown(KeyCode.M)) turn = true;

        if (Input.GetKeyDown(KeyCode.K)) ResetBools();
        
        if (startMove)
        {
            if (turn)
            {
                transform.position = 
                    Vector3.SmoothDamp(transform.position, startPos, ref velocity, smoothTime);
            }else transform.position = 
                Vector3.SmoothDamp(transform.position, turnPoint.position, ref velocity, smoothTime);
        }
    }

    public void ResetBools()
    {
        startMove = false;
        turn = false;
    }
}
