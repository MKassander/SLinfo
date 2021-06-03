using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Link : MonoBehaviour
{
    public void OpenLinkJSPlugin()
    {
#if !UNITY_EDITOR
        openWindow("https://www.google.se/");
#endif
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);
}
