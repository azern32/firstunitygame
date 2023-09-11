using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float power = 1;
    public float forceConstant = 1;
    public GameObject graivtyPoint;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("posisi gravitypoint" + graivtyPoint.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log(gameObject.transform.position.x);
            gameObject.transform.position += Vector3.left * power;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log(gameObject.transform.position.x);
            gameObject.transform.position += Vector3.right * power;
        }

        Force2Objects(gameObject, graivtyPoint, true);

    }

    void Force2Objects(GameObject player, GameObject gravityPoint, Boolean attract)
    {
        int pullForce = attract ? 1 : -1;
        float distance = player.transform.position.x - gravityPoint.transform.position.x;

        if (distance != 0)
        {

        }
    }

}
