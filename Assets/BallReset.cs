using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{

    private float positionY;
    private float positionX;

    private Vector3 positionInitial;
    void Start()
    {   
        positionInitial = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    
    void Update()
    {
        positionX = transform.position.x;
        positionY = transform.position.y;
        if(positionY <= -4)
        {
            positionInitial.x -= 0.5f;
            transform.position = positionInitial;
        }
        if(positionInitial.x <= -4)
        {
            positionInitial.x = 4;
        }
    }
}
