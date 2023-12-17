using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public GameObject prefab;
    public int columnPoolSize = 5;
    public float spawnRate = 5f;
    public float minHeight = -1.5f;
    public float maxHeight = -0f;

    private GameObject[] columns;
    private int currentColumn = 0;
    private Vector2 objectPoolPosition = new Vector2(-15, -25);
    private float spawnXPosition = 10f;
    private float timeSinceLastSpawned;

    private void Start()
    {
        timeSinceLastSpawned = 0f;
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(prefab, objectPoolPosition, Quaternion.identity);
        }
    }

    private void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;
            float spawnYPosition = Random.Range(minHeight, maxHeight);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColumn++;
            
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
    }
}