using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchImage : MonoBehaviour
{
    public RectTransform CurrentImage;
    public RectTransform ImageToSwitchTo;
    private ScrollRect scrollRect => FindObjectOfType<ScrollRect>();

    public void Switch()
    {
        if (ImageToSwitchTo != null)
        {
            ImageToSwitchTo.gameObject.SetActive(true);
            scrollRect.content = ImageToSwitchTo;
            CurrentImage.gameObject.SetActive(false);
        }
    }
}
