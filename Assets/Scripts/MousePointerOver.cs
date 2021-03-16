using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePointerOver : MonoBehaviour
{
    private void OnMouseEnter()
    {
        Cursor.SetCursor(MousePointerHandler.instance.OverCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(MousePointerHandler.instance.normalCursor, Vector2.zero, CursorMode.ForceSoftware);
    }
}
