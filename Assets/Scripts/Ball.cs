using UnityEngine;
using UnityEngine.SceneManagement; //call libraries to change scenes

public class Ball : MonoBehaviour
{
    public Vector2 InitialSpeed;
    private Rigidbody2D ballrigidbody;
    private bool IsMoving;
    public int Score;
    void Start()
    {
        ballrigidbody = GetComponent<Rigidbody2D>(); //pacman
    }

    // Update is called once per frame
    void Update()
    {
        if (IsMoving == false) // If Not Moving Enters {
                               // }
        {
            ballrigidbody.linearVelocity = InitialSpeed;
            IsMoving = true;
        }
        if (GameObject.FindGameObjectsWithTag("Block").Length == 0)
        {
            if (SceneManager.GetActiveScene().name == "CS2-MAP")
            {
                nextlevel1();
            }
        }


    }
    void nextlevel1()
    {
        SceneManager.LoadScene("PEAK-MAP");
    }
}
