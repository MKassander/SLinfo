using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Drag : MonoBehaviour, IDragHandler
{
    private RectTransform rectTransform => GetComponent<RectTransform>();
    private Canvas canvas => FindObjectOfType<Canvas>();
    
    public void OnDrag(PointerEventData eventData)
    {
        //transform.position = Input.mousePosition;
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
}
