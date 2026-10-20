using UnityEngine;

public class Victory : MonoBehaviour
{
    // Assign the victory sound clip in the Inspector.
    public AudioClip victoryClip;

    [Range(0f, 1f)]
    public float volume = 1f;

    // Play the victory sound as soon as the victory scene is loaded.
    void Start()
    {
        if (victoryClip != null)
        {
            AudioSource.PlayClipAtPoint(victoryClip, Vector3.zero, volume);
        }
    }
}
