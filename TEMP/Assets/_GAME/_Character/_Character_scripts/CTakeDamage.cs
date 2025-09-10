using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTakeDamage : MonoBehaviour
{
    public int health;

    private void Update()
    {
        if (health <= 0)
        {
           Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit!");
        if (collision.gameObject.CompareTag("playerAttack"))
        {
            health -= 10;
        }

    }
}
