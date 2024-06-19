using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 20.0f;
    private float horizontalBound = 21.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move game object
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Destroy game object when it out of the screen
        if (transform.position.x < -horizontalBound || transform.position.x > horizontalBound)
        {
            Destroy(gameObject);
        }
    }

    
}
