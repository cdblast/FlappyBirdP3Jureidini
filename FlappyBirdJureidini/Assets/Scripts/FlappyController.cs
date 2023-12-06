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

    public bool isDead = false;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isDead == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigidbody2d.velocity = Vector2.zero;
                rigidbody2d.AddForce(new Vector2(0, upForce));

                animator.SetTrigger("Launch");
            }
        }
    }

    private void OnCollisionEnter2D()
    {
        isDead = true;
        Debug.Log("isDead true");
        animator.SetTrigger("Die");
    }
}
