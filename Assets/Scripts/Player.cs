using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20f;
    private float horizontalmove;

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalmove * speed * Time.deltaTime, 0, 0);
    }
}
