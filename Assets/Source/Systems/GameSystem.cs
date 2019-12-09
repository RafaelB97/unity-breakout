using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private Transform ball = null;
    [SerializeField] private Game game = null;
    [SerializeField] private Text scoreText = null;

    private void Start()
    {
        game.hitEnemys = 0;
        game.gameState = State.Start;
    }

    // Update is called once per frame
    void Update()
    {

        switch (game.gameState)
        {
            case State.Start:
                if (Input.GetButton("Submit"))
                {
                    print("Pew");
                    game.gameState = State.Current;
                    ball.gameObject.SetActive(true);
                    ball.SetPositionAndRotation(new Vector3(5,7,(float)1.5), ball.rotation);

                }
                break;
            case State.Current:
                scoreText.text = "Score: " + game.hitEnemys;
                if (game.hitEnemys == game.maxEnemys)
                {
                    game.gameState = State.Win;
                }
                break;
            case State.Win:
                print("GANASTE");
                SceneManager.LoadScene(0);
                break;
            case State.Lose:
                SceneManager.LoadScene(0);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
