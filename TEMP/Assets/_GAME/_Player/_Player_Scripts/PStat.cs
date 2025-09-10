using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PStat : MonoBehaviour
{
    public int health;
    [SerializeField] private BoxCollider2D _hitBox;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit!");
        if (collision.gameObject.CompareTag("enemyCharacter"))
        {
            Debug.Log("enemy hit");
            health -= 10;
        }

    }
    private void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }
        
       }

}
