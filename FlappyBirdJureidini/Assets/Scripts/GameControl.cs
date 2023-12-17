using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject scoreText;
    public GameObject gameovertext;
    public int score = 0;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if(instance != this)
            Destroy (gameObject);
    }

    private void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;

        Text scoretext = scoreText.GetComponent<Text>();
        scoretext.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        gameovertext.SetActive(true);
        gameOver = true;
    }
}
