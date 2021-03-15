using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

namespace Video
{
    public class LoadSceneAfterVideo : MonoBehaviour
    {
        public VideoClip clip => GetComponent<VideoPlayer>().clip;
        private SceneSwitcher sceneSwitcher => GetComponent<SceneSwitcher>();
        private void Start()
        {
            Invoke("CallSwitchScene", (float) clip.length);
        }

        public void CallSwitchScene()
        {
            sceneSwitcher.SwitchScene();
        }
    }
}
