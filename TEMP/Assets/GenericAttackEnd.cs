using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericAttackEnd : MonoBehaviour
{
    public Animator myAnimator;
    void Start()
    {
        myAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!myAnimator.isActiveAndEnabled)
        {
            Debug.Log("over");
            Destroy(gameObject);
        }
    }
}
