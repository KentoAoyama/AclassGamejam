using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int _1pWinCount;
    public static int _2pWinCount;
    public static bool _1pWinner;
    public static bool _2pWinner;
    public static bool _amh;


    void OnEnable()
    {
        _1pWinCount = 0;
        _2pWinCount = 0;
        _1pWinner = false;
        _2pWinner = false;
    }
}
