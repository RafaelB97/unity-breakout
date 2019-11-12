using Source.Components;
using UnityEngine;

namespace Source.Systems
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Transform pawnTransform = null;
        [SerializeField] private FloatValue axis = null;
        [SerializeField] private FloatValue platerPosition = null;
        [SerializeField] private BooleanValue left = null;
        [SerializeField] private BooleanValue right = null;

        private void Start()
        {
            Debug.Assert(pawnTransform != null, "No hay figura perra");
            Debug.Assert(axis != null, "No controlador perra");
            Debug.Assert(platerPosition != null, "No hay posision incial perra");
            Debug.Assert(left != null, "Left not detected in Movement");
            Debug.Assert(right != null, "Right not detected in Movement");
            left.value = false;
            right.value = false;
        }

        private void Update()
        {
            // pawnTransform.Translate(axis, 0, 0);
            if (left.value == false && axis.value < 0)
            {
                // print(axis.value);
                pawnTransform.Translate(axis, 0, 0);
                var newPosition = pawnTransform.position;
                platerPosition.value = newPosition.x;
                // right.value = false;
            }
            if (right.value == false && axis.value > 0)
            {
                // print(axis.value);
                pawnTransform.Translate(axis, 0, 0);
                var newPosition = pawnTransform.position;
                platerPosition.value = newPosition.x;
                // left.value = false;
            }
        }

    }

}