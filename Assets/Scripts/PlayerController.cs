using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ENCAPSULATION
    public float topBound { get; private set; }
    public float bottomBound { get; private set; }
    private float verticalInput;
    private float speed = 15.0f;
    public int points { get; set; }

    public new string name { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        topBound = 14.0f;
        bottomBound = 0.0f;
        name = "ving";
    }

    // Update is called once per frame
    void Update()
    {
        // Get vertical input
        verticalInput = Input.GetAxis("Vertical");

        // Move the character
        transform.Translate(Vector3.left * verticalInput * speed * Time.deltaTime);

        // Check bound and move back
        if (transform.position.z > topBound)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, topBound);
        }
        else if (transform.position.z < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, bottomBound);
        }

        // Check point is negative
        if (points < 0) MainManager.gameOver = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            MainManager.gameOver = true;
        }
    }
}
