using UnityEngine;

public class Pattack : MonoBehaviour
{
    #region Data
    [SerializeField] private GameObject _swordAttack;
    [SerializeField] private GameObject _player;
    private float deltaTime; //time passed since last click
    private Vector2 _clickPos; //where last click happened
    #endregion
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        //Debug.Log(GetMousePos());
        Instantiate(_swordAttack, _player.transform);
        Debug.Log("clicked");
    }

    private Vector2 GetMousePos()
    {
        deltaTime += Time.deltaTime;
        if (deltaTime > 0)
        {
            Event _event = Event.current;
            _clickPos = _event.mousePosition;
        }
        return _clickPos;
    }
}
