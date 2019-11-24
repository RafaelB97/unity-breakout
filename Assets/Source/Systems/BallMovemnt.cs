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
        [SerializeField] private Vector2D ballDic = null;

        private void Start()
        {
            ballAxis.vec2.x = (float) 0;
            ballAxis.vec2.y = (float) 0;
        }
        private void FixedUpdate()
        {
            ball.Translate(ballDic.vec2.x, ballDic.vec2.y, 0);
            // ball.Translate(0, ballDic.vec2.y, 0);
            // ball.Translate(ballDic.vec2.x, 0, 0);
        }
    }
}