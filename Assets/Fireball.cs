using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Vector3 positionChange;
    private Vector3 positionInitial;
    private float positionYTemp;
    private float positionY_Initial;
    void Start()
    {
        positionYTemp = positionChange.y;
        positionInitial = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        positionY_Initial = transform.position.y;
        transform.position += positionChange;
        if(positionY_Initial > 5)
        {
            positionChange.y = positionYTemp;
            transform.position = positionInitial;
        }
    }
}
