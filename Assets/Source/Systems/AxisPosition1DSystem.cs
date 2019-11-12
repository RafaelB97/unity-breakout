using Source.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisPosition1DSystem : MonoBehaviour
{
    [SerializeField] private FloatValue axis = null;
    [SerializeField] private FloatValue speed = null;
    [SerializeField] private FloatValue dampening = null;
    [SerializeField] private string axisName = "Horizontal";
    // Start is called before the first frame update
    void Start()
    {
            Debug.Assert(axis != null, "A FloatValue for controller axis must be assigned to this object");
            Debug.Assert(speed != null, "A FloatValue for speed must be assigned to this object");
            Debug.Assert(dampening != null, "A FloatValue for speed must be assigned to this object");
            Debug.Assert(axisName != null, "The name of the axis must be set");
            if (Mathf.Abs(speed ) <= 0.001f) speed.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        axis.value = Input.GetAxis(axisName) * speed * Time.deltaTime * (1-dampening);
    }
}
