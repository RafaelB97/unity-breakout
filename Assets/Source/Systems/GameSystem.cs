using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private Text scoreText = null;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Hola";
    }
}
