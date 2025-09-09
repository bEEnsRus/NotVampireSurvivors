using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_chase : MonoBehaviour
{
    [SerializeField] private Vector2 _enemyPos;
    [SerializeField] private Rigidbody2D _enemyRb;
    public float _enemySpeed;
    private Vector2 _enemyDir;
    public GameObject _playerChr;
    private void Start()
    {
        if (_playerChr == null)
            _playerChr = GameObject.FindWithTag("playerCharacter");
    }
    public void Update()
    {
        _enemyDir = (_playerChr.transform.position - transform.position).normalized;
        _enemyRb.velocity = _enemySpeed * Time.fixedDeltaTime * _enemyDir;

    }
}
