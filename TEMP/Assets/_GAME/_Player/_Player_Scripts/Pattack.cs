using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Pattack : MonoBehaviour
{
    #region Data
    [SerializeField] private GameObject _swordAttack;
    [SerializeField] private GameObject _player;
    #endregion
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        Instantiate(_swordAttack, _player.transform);
        Debug.Log("clicked");
    }
}
