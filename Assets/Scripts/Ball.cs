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

    // update is called once per frame
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
            if (SceneManager.GetActiveScene().name == "PEAK-MAP")
            {
                nextlevel2();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D Crash)
    {
        if (Crash.gameObject.CompareTag("Block"))
        {
            Destroy(Crash.gameObject);

        }
        if (Crash.gameObject.CompareTag("Wasted"))
        {
            GameOver();
        }



    }
  
    void GameOver()
    {
        SceneManager.LoadScene("GameOver");

    }
    void nextlevel1()
    
    
    {
        SceneManager.LoadScene("PEAK-MAP");
    }
    void nextlevel2()
    {
        SceneManager.LoadScene("REPO-MAP");
    }
        

}
