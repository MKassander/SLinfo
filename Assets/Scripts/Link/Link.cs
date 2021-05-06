using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

    public void OpenLink()
    {
#if !UNITY_EDITOR
		openWindow("https://www.google.se/");
#endif
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);

}