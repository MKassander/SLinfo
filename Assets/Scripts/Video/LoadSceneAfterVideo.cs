using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

namespace Video
{
    public class LoadSceneAfterVideo : MonoBehaviour
    {
        public VideoClip clip => GetComponent<VideoPlayer>().clip;
        private void Start()
        {
            Invoke("SwitchScene", (float) clip.length
            + FindObjectOfType<Fade>().fadeDuration * 2);
        }

        void SwitchScene()
        {
            SceneManager.LoadScene("QuizScene");
        }
    }
}
