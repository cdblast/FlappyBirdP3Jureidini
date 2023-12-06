using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtful : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        FlappyController controller = other.GetComponent<FlappyController>();
        if (controller != null)
        {
            controller.isDead = true;
        }
    }
}
