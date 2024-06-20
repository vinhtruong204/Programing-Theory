using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static bool gameOver;
    [SerializeField] private GameObject gameoverText;
    [SerializeField] private TextMeshProUGUI scoreText;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        gameoverText.SetActive(false);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Player: " + playerController.name + " Score: " + playerController.points;
        if (gameOver)
        {
            gameoverText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameOver = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
