using System.Collections;
using System.Collections.Generic;
using Source.Components;
using UnityEngine;

public class BallAxisPosition : MonoBehaviour
{
    [SerializeField] private Vector2D dic = null;
    [SerializeField] private Vector2D ballAxis = null;
    [SerializeField] private FloatValue speed = null;
    [SerializeField] private FloatValue dampening = null;
    // Start is called before the first frame update
    void Start()
    {
        dic.vec2.x = (float) 0.5;
        dic.vec2.y = (float) 0.5;
    }

    // Update is called once per frame
    void Update()
    {
        var rad = Mathf.Deg2Rad * 45;
        // ballAxis.vec2.x = dic.vec2.x * (speed * Time.deltaTime + (1 - dampening));
        // ballAxis.vec2.y = dic.vec2.y * (speed * Time.deltaTime + (1 - dampening));
        var a = (1 * Mathf.Cos(rad));
        ballAxis.vec2.x = dic.vec2.x * (a * speed * Time.deltaTime + (1 - dampening));

        var b = (1 * Mathf.Sin(rad));
        ballAxis.vec2.y = dic.vec2.y * (b * speed * Time.deltaTime + (1 - dampening));
    }
}
