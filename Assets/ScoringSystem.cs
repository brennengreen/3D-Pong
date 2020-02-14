using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    private int score_east;
    private int score_west;

    // Start is called before the first frame update
    void Start()
    {
        score_east = 0;
        score_west = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetScore(char side)
    {
        if (side == 'e')
        {
            return score_east;
        }
        else
        {
            return score_west;
        }
    }

    public char GetScoreChar(char side)
    {
        if (side == 'e')
        {
            return (char)score_east;
        }
        else
        {
            return (char)score_west;
        }
    }

    public void IncScore(char side)
    {
        if (side == 'e')
        {
            score_east++;
        }
        else if (side == 'w')
        {
            score_west++;
        }
    }
}
