using UnityEngine;

public class BallWastedSound : MonoBehaviour
{
    public AudioClip wastedClip;
    public AudioClip wastedClip2;

    [Range(0f, 1f)]
    public float volume = 1f;

    [Range(0f, 1f)]
    public float volume2 = 1f;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null && wastedClip != null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false;
        }
    }

    public void PlayWastedSound()
    {
        if (wastedClip == null)
        {
            return;
        }

        GameObject temp = new GameObject("WastedSound");
        var src = temp.AddComponent<AudioSource>();
        src.clip = wastedClip;
        src.playOnAwake = false;
        src.volume = volume;
        DontDestroyOnLoad(temp);
        src.Play();
        Destroy(temp, wastedClip.length + 0.1f);

        if (wastedClip2 != null)
        {
            GameObject temp2 = new GameObject("WastedSound2");
            var src2 = temp2.AddComponent<AudioSource>();
            src2.clip = wastedClip2;
            src2.playOnAwake = false;
            src2.volume = volume2;
            DontDestroyOnLoad(temp2);
            src2.Play();
            Destroy(temp2, wastedClip2.length + 0.1f);
        }
    }
}
