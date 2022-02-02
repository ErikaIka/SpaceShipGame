using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    bool toRight = true;
    float sleep = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(sleep);
        MoveEnemy();
        StartCoroutine(Wait());
    }

    void MoveEnemy()
    {
        if (toRight)
        {
            if(transform.position.x > 5.5)
            {
                sleep -= 0.05f;
                toRight = false;
                transform.Translate(Vector3.down);
            }
            else
            {
                transform.Translate(Vector3.right);
            }
        }
        else
        {
            if (transform.position.x < -5.5)
            {
                sleep -= 0.05f;
                toRight = true;
                transform.Translate(Vector3.down);
            }
            else
            {
                transform.Translate(Vector3.left);
            }
        }
        
    }
}
