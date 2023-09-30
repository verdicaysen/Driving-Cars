using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Driver : MonoBehaviour
{
  
   [SerializeField] float turnSpeed = 2f;
   [SerializeField]float moveSpeed = 0.1f;
   
    
    void Start()
    {
 
    }

    
    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }

    

}

