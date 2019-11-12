using Source.Components;
using UnityEngine;
namespace Source.Systems
{
    public class BallCollisionDetection : MonoBehaviour
    {
        [SerializeField] private Vector2D dic = null;
        private void OnCollisionEnter(Collision other)
        {
            switch (other.collider.tag)
            {
                case "LeftWall":
                    print("Chocaste con la pared izquierda");
                    dic.vec2.x = (float) 0.5;
                    break;
                case "RightWall":
                    print("Chocaste con la pared derecha");
                    dic.vec2.x = (float) -0.5;
                    break;
                case "Floor":
                    print("Choacaste con el suelo");
                    dic.vec2.y = (float) 0.5;
                    break;
                case "Roof":
                    print("Chocaste con el techo");
                    dic.vec2.y = (float) -0.5;
                    break;
            }
        }
    }
}