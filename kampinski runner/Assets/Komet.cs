using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Komet : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject currentObject = gameObject;
        if (collision.gameObject.CompareTag("Projectile") == true)
        {
            Destroy(currentObject);
        }
    }
}
