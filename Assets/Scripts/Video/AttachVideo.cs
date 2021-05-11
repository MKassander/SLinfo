using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class AttachVideo : MonoBehaviour
{
    private VideoPlayer VideoPlayer => GetComponent<VideoPlayer>();
    public string path;

    public void Awake()
    {
        VideoPlayer.url = Path.Combine(Application.streamingAssetsPath, path + ".mp4");
    }
}
