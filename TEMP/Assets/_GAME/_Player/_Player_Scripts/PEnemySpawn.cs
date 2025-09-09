using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PEnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    [SerializeField] private GameObject _player;   
    void Start()
    {
        StartCoroutine(Enemyspawn());
    }

    void Update()
    {
        
    }
    IEnumerator Enemyspawn()
    {
        int enemycount = 0;
        while (enemycount < 12)
        {
            Instantiate(enemy, _player.transform.position + new Vector3(Random.Range(-4, -7), Random.Range(4, 7), 0), _player.transform.rotation);
            Instantiate(enemy, _player.transform.position + new Vector3(Random.Range(4, 7), Random.Range(4, 7), 0), _player.transform.rotation);
            Instantiate(enemy, _player.transform.position + new Vector3(Random.Range(-4, -7), Random.Range(-4, -7), 0), _player.transform.rotation);
            Instantiate(enemy, _player.transform.position + new Vector3(Random.Range(4, 7), Random.Range(-4, -7), 0), _player.transform.rotation);
            enemycount += 4;
            yield return null;
        }
    }
}
