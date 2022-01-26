using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Vector3 posEnemy;
    public Transform posEnemyTransform;

    // Start is called before the first frame update
    void Start()
    {
        posEnemy.Set(posEnemyTransform.position.x, posEnemyTransform.position.y, 0);
        InvokeRepeating("MoveEnemy", 0.8f, 0.8f);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveEnemy()
    {
        transform.Translate(Vector3.right);

        if (transform.position.x == 6f)
        {
            transform.position = posEnemy;


        }
    }
}
