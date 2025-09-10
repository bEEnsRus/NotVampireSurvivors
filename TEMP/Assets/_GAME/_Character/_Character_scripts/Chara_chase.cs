using UnityEngine;

public class Chara_chase : MonoBehaviour
{
    [SerializeField] private Vector2 _enemyPos;
    [SerializeField] private Rigidbody2D _enemyRb;
    [SerializeField] private GameObject _player;
    [SerializeField] private float _enemySpeed;
    private void Start()
    {
        if (_player == null)
            _player = GameObject.FindWithTag("Player");
    }
    public void Update()
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, _player.transform.position, _enemySpeed);
    }
}
