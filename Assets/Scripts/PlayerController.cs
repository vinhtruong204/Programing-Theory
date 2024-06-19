using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float topBound = 14.0f;
    public float bottomBound = 1.0f;
    private float verticalInput;
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

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
    }
}
