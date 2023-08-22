using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float power = 1;
    // Start is called before the first frame update
    void Start()
    {

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

    }


}
