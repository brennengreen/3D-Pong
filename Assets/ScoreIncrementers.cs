using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrementers : MonoBehaviour
{
    ScoringSystem score;
    GameObject score_card;
    public char side_char; 
    int curr_score;

    // Start is called before the first frame update
    void Start()
    {
        curr_score = 0;
        score_card = GameObject.FindWithTag("Score");
        if (score_card != null)
        {
            score = score_card.GetComponent<ScoringSystem>();
        }
        else
        {
            Debug.Log("DIDNT FIND CARD");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score != null && score.GetScore(side_char) > curr_score)
        {
            curr_score++;
            Debug.Log("GOOOOAALLLLL! " + side_char + ": " + curr_score); 
        }
    }
}
