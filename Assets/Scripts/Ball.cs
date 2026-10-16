using UnityEngine;
using UnityEngine.SceneManagement; // scene stuff

public class Ball : MonoBehaviour
{
    public Vector2 InitialSpeed;
    private Rigidbody2D ballrigidbody;
    private bool IsMoving;
    public int Scores;
    public Score sumscore;

    void Start()
    {
        // get the rb
        ballrigidbody = GetComponent<Rigidbody2D>(); //pacman
    }

    // update runs every frame
    void Update()
    {
        if (IsMoving == false) // push ball if stuck
        {
            ballrigidbody.linearVelocity = InitialSpeed;
            IsMoving = true;
        }

        // change level if no blocks left
        if (GameObject.FindGameObjectsWithTag("Block").Length == 0)
        {
            if (SceneManager.GetActiveScene().name == "CS2-MAP")
            {
                nextlevel1();
            }
            if (SceneManager.GetActiveScene().name == "PEAK-MAP")
            {
                nextlevel2();
            }
            // transition to victory screen when final map is cleared
            if (SceneManager.GetActiveScene().name == "REPO-MAP")
            {
                winGame();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D Crash)
    {
        // break block and add points
        if (Crash.gameObject.CompareTag("Block"))
        {
            Debug.Log("1 The Script Is Working" + Scores);
            Destroy(Crash.gameObject);

            sumscore.count(Scores);
        }

        // die if touch bottom
        if (Crash.gameObject.CompareTag("Wasted"))
        {
            // Play wasted sound (persists across scene change) and immediately go to GameOver.
            var bws = GetComponent<BallWastedSound>();
            if (bws != null)
            {
                bws.PlayWastedSound();
            }
            GameOver();
        }
    }

    // go to dead screen
    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    // go to map 2
    void nextlevel1()
    {
        SceneManager.LoadScene("PEAK-MAP");
    }

    // go to map 3
    void nextlevel2()
    {
        SceneManager.LoadScene("REPO-MAP");
    }

    // you won congrats ur lebron
    void winGame()
    {
        SceneManager.LoadScene("Victory");
    }
}