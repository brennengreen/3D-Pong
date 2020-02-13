using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string MovementTag;
    public bool canMoveUp = true;
    public bool canMoveDown = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(MovementTag + "Up") && canMoveUp)
        {
            transform.position = transform.position + new Vector3(0, 0, 1);
        }
        if (Input.GetButton(MovementTag + "Down") && canMoveDown)
        {
            transform.position = transform.position + new Vector3(0, 0, -1);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NorthWall"))
        {
            canMoveUp = false;
        } else if (other.gameObject.CompareTag("SouthWall"))
        {
            canMoveDown = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NorthWall"))
        {
            canMoveUp = true;
        }
        else if (other.gameObject.CompareTag("SouthWall"))
        {
            canMoveDown = true;
        }
    }
}
