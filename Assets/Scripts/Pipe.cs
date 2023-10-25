using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Pipe : MonoBehaviour
{

    public float movingSpeed ;
    // Start is called before the first frame update
    private void OnEnable()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left*Time.deltaTime*movingSpeed;


    }

}
