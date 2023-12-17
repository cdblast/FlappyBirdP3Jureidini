using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        FlappyController controller = other.GetComponent<FlappyController>();
        if (controller != null)
        {
            GameControl.instance.BirdScored();
        }
    }
}
