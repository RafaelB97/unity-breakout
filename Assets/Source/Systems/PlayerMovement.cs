using Source.Components;
using UnityEngine;

namespace Source.Systems
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Transform pawnTransform = null;
        [SerializeField] private Player player = null;
        [SerializeField] private BooleanValue left = null;
        [SerializeField] private BooleanValue right = null;

        private void Start()
        {
            Debug.Assert(pawnTransform != null, "No hay figura perra");
            Debug.Assert(player != null, "No hay juego");
            Debug.Assert(left != null, "Left not detected in Movement");
            Debug.Assert(right != null, "Right not detected in Movement");
            left.value = false;
            right.value = false;
        }

        private void Update()
        {
            // pawnTransform.Translate(axis, 0, 0);
            if (left.value == false && player.axis < 0)
            {
                // print(axis.value);
                pawnTransform.Translate(player.axis, 0, 0);
                var newPosition = pawnTransform.position;
                player.pos = newPosition.x;
                // right.value = false;
            }
            if (right.value == false && player.axis > 0)
            {
                // print(axis.value);
                pawnTransform.Translate(player.axis, 0, 0);
                var newPosition = pawnTransform.position;
                player.pos = newPosition.x;
                // left.value = false;
            }
        }

    }

}