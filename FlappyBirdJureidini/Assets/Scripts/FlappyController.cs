using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

public class FlappyController : MonoBehaviour
{
    public int maxHealth = 1;
    private Rigidbody2D rigidbody2d;
    public float upForce = 200f;

    public int health {  get { return currentHealth; } }
    int currentHealth;

    public float timeInvincible = 2.0f;
    bool isInvincible;
    float invincibleTimer;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if (maxHealth > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody2d.velocity = Vector2.zero;
                rigidbody2d.AddForce(new Vector2(0, upForce));
            }
        }
    }

    public void ChangeHealth(int amount)
    {
        if (amount < 0)
        {
            if (isInvincible)
                return;
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }


    }
}
