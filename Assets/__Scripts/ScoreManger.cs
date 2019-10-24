using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eScoreEvent
{
    draw,
    mine,
    mineGold,
    gameWin,
    gameLoss
}

public class ScoreManger : MonoBehaviour
{
    static private ScoreManager S;

    static public int SCORE_FROM_PREV_ROUND = 0;
    static public int HIGH_SCORE = 0;

    [Header("Set Dynamically")]
    public int chain = 0;
    public int scoreRun = 0;
    public int score = 0;

    void Awake()
    {
        if (S == null)
        {
            S = this;
        }
        else
        {
            Debug.LogError("ERROR: ScoreManger.Awake(): S is already set!");
        }
        score += SCORE_FROM_PREV_ROUND;
        SCORE_FROM_PREV_ROUND = 0;
    }static public void EVENT(eScoreEvent evt)
    {
        try
        {
            S.Event()
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
