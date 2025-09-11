using UnityEngine;

public class PAttack : MonoBehaviour
{
    #region Data
    [SerializeField] private GameObject _swordAttackL;
    [SerializeField] private GameObject _swordAttackR;
    [SerializeField] private GameObject _player;
    public int swordDmg;
    #endregion
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        Vector2 _pScreenPos = Camera.main.WorldToScreenPoint(_player.transform.position);
        if (CursorXPos(_pScreenPos, Input.mousePosition) == -1)
        {
            Instantiate(_swordAttackR, _player.transform);
            Debug.Log("right side attack");
        }
        else
        {
            Instantiate(_swordAttackL, _player.transform);
            Debug.Log("left side attack");
        }
    }

    public int CursorXPos(Vector2 _playerPos, Vector2 _pScreenPos)
    {
        if(_playerPos.x - _pScreenPos.x < 0)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}
