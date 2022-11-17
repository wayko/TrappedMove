using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState GameStates;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
       ChangeState(GameState.GenerateGrid);
    }


   public void ChangeState(GameState newState)
    {
        GameStates = newState;

        switch(newState)
        {
            case GameState.GenerateGrid:
                //GridManager.Instance.GenerateGrid();
                break;
            case GameState.player1chip:
                break;
            case GameState.player2chip:
                break;
            case GameState.player3chip:
                break;
            case GameState.player4chip:
                break;
            case GameState.player1Turn:
                break;
            case GameState.player2Turn:
                break;
            case GameState.player3Turn:
                break;
            case GameState.player4Turn:
                break;
            case GameState.playerVictory:
                break;
            case GameState.playerLose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }

       

    }

    public enum GameState
    {
        GenerateGrid,
        player1chip,
        player2chip,
        player3chip,
        player4chip,
        player1Turn,
        player2Turn,
        player3Turn,
        player4Turn,
        playerVictory,
        playerLose
    }
}
