using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float scrollSpeed = -1.5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = new Vector2 (scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //if (isDead == true)
    }
}
