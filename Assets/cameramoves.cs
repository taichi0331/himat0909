﻿using UnityEngine;
using System.Collections;

public class cameramoves : MonoBehaviour {


    public GameObject player ;
    private Vector3 offset = Vector3.zero;

    void Start()
    {
       
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = player.transform.position.x + offset.x;
        //newPosition.y = player.transform.position.y + offset.y;
        newPosition.z = player.transform.position.z + offset.z;
        transform.position = newPosition;
    }
}
