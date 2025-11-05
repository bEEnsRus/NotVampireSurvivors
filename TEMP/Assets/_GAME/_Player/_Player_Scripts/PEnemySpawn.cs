using System.Collections;
using UnityEngine;

public class PEnemySpawn : MonoBehaviour
{
    public GameObject _enemy;
    [SerializeField] private GameObject _player;
    void Start()
    {
        StartCoroutine(Enemyspawn());
    }
    public float RandomFloat()
    {
        float roll = Random.Range(1, 3);
        switch (roll)
        {
            case 1:
                return Random.Range(4, 7);
            case 2:
                return Random.Range(-4, -7);
            default:
                break;
        }
        return 1;
    }
    IEnumerator Enemyspawn()
    {
        while (true)
        {
            while (GameStats.enemyCount < 12)
            {
                for (int i = 0; i <= Random.Range(1, 4); i++)
                {
                    Instantiate(_enemy, _player.transform.position + new Vector3(RandomFloat(), RandomFloat(), 0), _player.transform.rotation);
                    GameStats.enemyCount++;
                    //Debug.Log(GameStats.enemyCount);
                }
                yield return new WaitForSeconds(3f);
            }
            yield return null;
        }
    }
}
