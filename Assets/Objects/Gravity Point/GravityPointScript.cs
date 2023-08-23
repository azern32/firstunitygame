using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPointScript : MonoBehaviour
{
    public float size = 1;
    public GameObject theObject;
    // Start is called before the first frame update
    void Start()
    {
        theObject.transform.localScale = new Vector3(
            theObject.transform.localScale.x + size,
            theObject.transform.localScale.y + size,
            theObject.transform.localScale.z
        );
    }

    // Update is called once per frame
    void Update()
    {
    }
}
