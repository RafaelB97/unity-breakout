using Source.Components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisPosition1DSystem : MonoBehaviour
{
    [SerializeField] private Player player = null;
    [SerializeField] private string axisName = "Horizontal";
    // Start is called before the first frame update
    void Start()
    {
            Debug.Assert(axisName != null, "The name of the axis must be set");
            Debug.Assert(player != null, "The playar must be assigned to this object");
            if (Mathf.Abs(player.speed ) <= 0.001f) player.speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        player.axis = Input.GetAxis(axisName) * player.speed * Time.deltaTime * (1-player.damp);
    }
}
