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
        [SerializeField] private Transform ball = null;
        [SerializeField] private Ball ballPro = null;
        [SerializeField] private Game game = null;
        
        private void OnCollisionEnter(Collision other)
        {
            switch (other.collider.tag)
            {
                case "Vertical":
                    // print("Chocaste con la pared");
                    ballPro.dic.x = ballPro.dic.x * (float) -1;
                    break;
                case "Horizontal":
                    // print("Chocaste con el suelo");
                    ballPro.dic.y = ballPro.dic.y * (float) -1;
                    break;
                case "Enemy":
                    var minPos = other.collider.transform.position;
                    var maxPos = new Vector3(minPos.x + 2, minPos.y + 1, minPos.z);
                    var ballPos = ball.position;
                    
                    // print("Pegaste a un enemigo");
                    // print("Enemy min " + minPos.x + " " + minPos.y + " " + minPos.z);
                    // print("Enemy max " + maxPos.x + " " + maxPos.y + " " + maxPos.z);
                    // print("Ball " + ballPos.x + " " + ballPos.y);
                    if (ballPos.x <= minPos.x ^ ballPos.x >= maxPos.x)
                    {
                        // print("Chocaste vertical");
                        ballPro.dic.x = ballPro.dic.x * (float) -1;
                        other.gameObject.SetActive(false);
                        game.hitEnemys = game.hitEnemys + 1;
                    }
                    else
                    {
                        // print("Chocaste horizontal");
                        ballPro.dic.y = ballPro.dic.y * (float) -1;
                        other.gameObject.SetActive(false);
                        game.hitEnemys = game.hitEnemys + 1;
                    }
                    // print("-----------------------------------------------------");
                    break;
            }
        }
    }
}
