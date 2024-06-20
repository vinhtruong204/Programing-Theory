using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject carrot;
    private GameObject player;
    private PlayerController playerController;
    private MoveForward moveForward;
    [SerializeField] private List<GameObject> enemiesPrefabs;
    private float spawnRate = 2.0f;
    private float startDelay = 3.0f;

    private Vector3 offset = new Vector3(1, 1, 1);

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
        moveForward = GetComponent<MoveForward>();
        InvokeRepeating("SpawnEnemy", startDelay, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn carrot when user press space bar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(carrot, player.transform.position + offset, player.transform.rotation);
        }

        // Cancel invoke repeating
        if (MainManager.gameOver)
        {
            CancelInvoke();
        }
    }

    private void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, enemiesPrefabs.Count);

        // ABSTRACTION
        Instantiate(enemiesPrefabs[spawnIndex], GenerateSpawnPos(), enemiesPrefabs[spawnIndex].transform.rotation);
    }

    private Vector3 GenerateSpawnPos()
    {
        return new Vector3(MoveForward.xBound, 0, Random.Range(playerController.topBound, playerController.bottomBound));
    }

}
