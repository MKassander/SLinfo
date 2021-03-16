using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MousePointerHandler : MonoBehaviour
{
    public static MousePointerHandler instance;
    public Texture2D normalCursor;
    public Texture2D OverCursor;
    private void Start()
    {
        Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.ForceSoftware);
        instance = this;
    }
}
