using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BallController : MonoBehaviour
{
    static float[] reflection = { -1.0f, 1.0f };
    float vx;
    float vy;

    ScoringSystem score;
    GameObject score_card;

    // Start is called before the first frame update
    void Start()
    {
        vx = Random.Range(.1f, .25f) * reflection[(int)Random.Range(0, 2)] * 2;
        vy = Random.Range(.1f, .25f) * reflection[(int)Random.Range(0, 2)] * 2;
        transform.position = new Vector3(0, 0, 0);

        score_card = GameObject.FindWithTag("Score");
        if (score_card != null)
        {
            score = score_card.GetComponent<ScoringSystem>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(vx, 0, vy);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided With: " + other.gameObject.tag);
        if (other.gameObject.CompareTag("SouthWall") || other.gameObject.CompareTag("NorthWall"))
        {
            vy = -vy;
        }
        else if (other.gameObject.CompareTag("EastWall"))
        {
            vx = -vx;
            transform.position = new Vector3(0, 0, 0);
            score.IncScore('e');
        }
        else if (other.gameObject.CompareTag("WestWall"))
        {
            vx = -vx;
            transform.position = new Vector3(0, 0, 0);
            score.IncScore('w');
        }

        if (other.gameObject.CompareTag("Paddle"))
        {
            vx = -vx;
            vx = vx * 1.08f;
        }
    }
}
