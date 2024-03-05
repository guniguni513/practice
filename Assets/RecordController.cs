using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RecordController : MonoBehaviour
{
    float rotSpeed = 0;
    void Start()
    {
    Application.targetFrameRate = 60;    
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButton(0)){
        this.rotSpeed = 6;
       } 
       transform.Rotate(0,this.rotSpeed,0);
    }
}
