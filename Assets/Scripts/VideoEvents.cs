using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoEvents : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public UnityEvent onVideoEnded;

    private void OnEnable()
    {
        videoPlayer.loopPointReached += OnVideoEnded;
    }

    private void OnDisable()
    {
        videoPlayer.loopPointReached -= OnVideoEnded;
    }

    private void OnVideoEnded(VideoPlayer source)
    {
        onVideoEnded.Invoke();
    }
}
