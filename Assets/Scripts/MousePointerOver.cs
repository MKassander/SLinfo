using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MousePointerOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(MousePointerHandler.instance.OverCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(MousePointerHandler.instance.normalCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Cursor.SetCursor(MousePointerHandler.instance.normalCursor, Vector2.zero, CursorMode.ForceSoftware);
    }
}
