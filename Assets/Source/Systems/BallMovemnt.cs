using System;
using Source.Components;
using UnityEditor;
using UnityEngine;

namespace Source.Systems
{
    public class BallMovemnt : MonoBehaviour
    {
        [SerializeField] private Transform ball = null;
        [SerializeField] private Ball ballPro = null;

        private void Start()
        {
            ballPro.axis.x = (float) 0;
            ballPro.axis.x = (float) 0;
            ballPro.dic.x = (float) 1;
            ballPro.dic.y = (float) 1;
        }
        
        private void FixedUpdate()
        {
            // ball.Translate(ballDic.vec2.x, ballDic.vec2.y, 0);
            // ball.Translate(0, ballDic.vec2.y, 0);
            // ball.Translate(ballDic.vec2.x, 0, 0);
            print(ballPro.axis.x + " " + ballPro.axis.y);
            print("-------------------");
            ballPro.axis.x = ballPro.dic.x * ballPro.speed * Time.deltaTime;
            ballPro.axis.y = ballPro.dic.y * ballPro.speed * Time.deltaTime;
            ball.Translate(ballPro.axis.x, ballPro.axis.y, 0);
        }
    }
}