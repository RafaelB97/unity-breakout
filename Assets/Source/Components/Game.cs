using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Start,
    Current,
    Win,
    Lose,
}
[CreateAssetMenu]
public class Game : ScriptableObject
{

    public State gameState;
    public int maxEnemys;
    public int hitEnemys;
}
