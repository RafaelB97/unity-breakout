using System;
using Source.Components;
using UnityEditor;
using UnityEngine;

namespace Source.Systems
{
    public class BallMovemnt : MonoBehaviour
    {
        [SerializeField] private Transform ball = null;
        [SerializeField] private Vector2D ballAxis = null;

        private void Start()
        {
            ballAxis.vec2.x = (float) 0;
            ballAxis.vec2.y = (float) 0;
        }
        private void Update()
        {
            ball.Translate(ballAxis.vec2.x, ballAxis.vec2.y, 0);
            // ball.Translate(transform.right);
        }
    }
}