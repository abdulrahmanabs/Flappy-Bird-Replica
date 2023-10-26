using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Pipe : MonoBehaviour
{

    public float movingSpeed ;
    Camera cam;
    
    // Start is called before the first frame update
    private void Awake()
    {
        cam = Camera.main; 

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.gameState != GameManager.GameState.Play)
            return;

        transform.position += Vector3.left*Time.deltaTime*movingSpeed;
        if (isOutsideCameraBorder())
            gameObject.SetActive(false);
        
    }

    private bool isOutsideCameraBorder()
    {
        Vector3 ScreenPos = cam.WorldToScreenPoint(Vector3.zero-new Vector3(3,3));
        if (transform.position.x < ScreenPos.x  )
            return true;
        return false;
    }

}
