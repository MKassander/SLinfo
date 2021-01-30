using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

namespace Video
{
    public class LoadSceneAfterVideo : MonoBehaviour
    {
        private VideoClip clip => GetComponent<VideoPlayer>().clip;
        private void Start()
        {
            Invoke("SwitchScene", (float) clip.length);
        }

        void SwitchScene()
        {
            SceneManager.LoadScene("QuizScene");
        }
    }
}
