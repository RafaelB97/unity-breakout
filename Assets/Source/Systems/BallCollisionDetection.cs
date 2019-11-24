using System.Numerics;
using Source.Components;
using UnityEngine;
using UnityEngine.UIElements;
using Vector2 = System.Numerics.Vector2;
using Vector3 = UnityEngine.Vector3;

namespace Source.Systems
{
    public class BallCollisionDetection : MonoBehaviour
    {
        [SerializeField] private Vector2D dic = null;
        [SerializeField] private Transform ball = null;
        private void OnCollisionEnter(Collision other)
        {
            switch (other.collider.tag)
            {
                case "Vertical":
                    // print("Chocaste con la pared");
                    dic.vec2.x = dic.vec2.x * (float) -1;
                    break;
                case "Horizontal":
                    // print("Chocaste con el suelo");
                    dic.vec2.y = dic.vec2.y * (float)-1;
                    break;
                case "Enemy":
                    Vector3 minPos = other.collider.transform.position;
                    Vector3 maxPos = new Vector3(minPos.x + 2, minPos.y + 1, minPos.z);
                    Vector3 ballPos = ball.position;
                    
                    // print("Pegaste a un enemigo");
                    print("Enemy min " + minPos.x + " " + minPos.y + " " + minPos.z);
                    print("Enemy max " + maxPos.x + " " + maxPos.y + " " + maxPos.z);
                    print("Ball " + ballPos.x + " " + ballPos.y);
                    /*
                    if (minPos.y > ballPos.y)
                    {
                        print("Choco por abajo");
                        dic.vec2.y = dic.vec2.y * (float)-1;
                        other.gameObject.SetActive(false);
                    }
                    else if ((maxPos.y - .2) < ballPos.y)
                    {
                        print("Choco por arriba");
                        dic.vec2.y = dic.vec2.y * (float)-1;
                        other.gameObject.SetActive(false);
                    }
                    else if (minPos.x >= ballPos.x)
                    {
                        print("Choco por la derecha");
                        dic.vec2.x = dic.vec2.x * (float) -1;
                        other.gameObject.SetActive(false);
                    }
                    else if (maxPos.x <= ballPos.x)
                    {
                        print("Choco por la izquierda");
                        dic.vec2.x = dic.vec2.x * (float) -1;
                        other.gameObject.SetActive(false);
                    }
                    */
                    if (ballPos.x <= minPos.x ^ ballPos.x >= maxPos.x)
                    {
                        print("Chocaste vertical");
                        dic.vec2.x = dic.vec2.x * (float) -1;
                        other.gameObject.SetActive(false);
                    }
                    else
                    {
                        print("Chocaste horizontal");
                        dic.vec2.y = dic.vec2.y * (float)-1;
                        other.gameObject.SetActive(false);
                    }
                    print("-----------------------------------------------------");
                    break;
            }
        }
    }
}
