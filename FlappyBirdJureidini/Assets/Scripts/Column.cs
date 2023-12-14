using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        FlappyController controller = other.GetComponent<FlappyController>();
        if (controller != null)
        {
            controller.BirdScored ();
        }
    }
}
