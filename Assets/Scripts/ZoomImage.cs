using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class ZoomImage : MonoBehaviour, IScrollHandler
{
    [SerializeField] float minimumScale = 0.5f;
    [SerializeField] float initialScale = 1f;
    [SerializeField] float maximumScale = 3f;
    [SerializeField] float scaleIncrement = .5f;
 
    Vector3 scale;
 
    RectTransform thisTransform;
 
    private void Awake()
    {
 
        thisTransform = transform as RectTransform;
 
        scale.Set(initialScale, initialScale, 1f);
        thisTransform.localScale = scale;
 
    }

    public void ZoomIn()
    {
        var thisTransformLocalScale = thisTransform.localScale;
        thisTransformLocalScale.x = Mathf.Clamp(thisTransformLocalScale.x + 0.1f, minimumScale, maximumScale);
        thisTransformLocalScale.y = Mathf.Clamp(thisTransformLocalScale.y + 0.1f, minimumScale, maximumScale);
    }
    public void ZoomOut()
    {
        var thisTransformLocalScale = thisTransform.localScale;
        thisTransformLocalScale.x = Mathf.Clamp(thisTransformLocalScale.x - 0.1f, minimumScale, maximumScale);
        thisTransformLocalScale.y = Mathf.Clamp(thisTransformLocalScale.y - 0.1f, minimumScale, maximumScale);
    }
 
    public void OnScroll(PointerEventData eventData)
    {
        Vector2 relativeMousePosition;
 
        RectTransformUtility.ScreenPointToLocalPointInRectangle(thisTransform, Input.mousePosition, null, out relativeMousePosition);
 
        float delta = eventData.scrollDelta.y;
 
        if (delta > 0 && scale.x < maximumScale)
        {
            scale.Set(scale.x + scaleIncrement, scale.y + scaleIncrement, 1f);
            thisTransform.localScale = scale;
            thisTransform.anchoredPosition -= (relativeMousePosition * scaleIncrement);
        }
 
        else if (delta < 0 && scale.x > minimumScale)
        {
            scale.Set(scale.x - scaleIncrement, scale.y - scaleIncrement, 1f);
            thisTransform.localScale = scale;
            thisTransform.anchoredPosition += (relativeMousePosition * scaleIncrement);
        }
    }
}