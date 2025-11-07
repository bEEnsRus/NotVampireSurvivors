using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int enemyAtk;
    [SerializeField] private int enemyHp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerAttack"))
        {
            enemyHp -= GameStats.playerAttack;
            if (enemyHp > 0)
                return;
            GameStats.enemyCount -= 1;
            GameStats.EnemyDeath(Random.Range(1, 2), gameObject.transform.position);
            Destroy(gameObject);
        }
    }
}
