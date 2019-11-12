using System;
using System.Collections;
using System.Collections.Generic;
using Source.Components;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private BooleanValue left = null;
    [SerializeField] private BooleanValue right = null;

    void Start()
    {
        Debug.Assert(left != null, "Left not detected in collision");
        Debug.Assert(right != null, "Right not detected in collision");
    }
    private void OnCollisionEnter(Collision other)
    { 
       switch (other.collider.tag)
       {
           case "LeftWall":
               print("Chocaste con la pared izquierda");
               left.value = true;
               break;
           case "RightWall":
               print("Chocaste con la pared derecha");
               right.value = true;
               break;
       }
       
    }
    private void OnCollisionExit(Collision other)
    { 
       switch (other.collider.tag)
       {
           case "LeftWall":
               print("Deschocaste con la pared izquierda");
               left.value = false;
               break;
           case "RightWall":
               print("deschocaste con la pared derecha");
               right.value = false;
               break;
       }
       
    }
}
