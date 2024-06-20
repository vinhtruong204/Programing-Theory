using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 20.0f;
    public static float xBound { get; private set; }
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        xBound = 21.0f;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move game object
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Destroy game object when it out of the screen
        if (transform.position.x < -xBound)
        {
            if (!MainManager.gameOver)
            {
                Animal animal = gameObject.GetComponent<Animal>();
                animal.minusPoint();
            }
            Destroy(gameObject);
        }
        else if (transform.position.x > xBound)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food") && !MainManager.gameOver)
        {
            Animal animal = gameObject.GetComponent<Animal>();
            animal.addPoint();
        }
        Destroy(gameObject);
    }
}
