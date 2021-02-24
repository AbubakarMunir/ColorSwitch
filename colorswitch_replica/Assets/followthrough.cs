using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followthrough : MonoBehaviour
{
    public Transform ballloc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ballloc.position.y>transform.position.y)  //transform.pos.y is height of camera as whole of this followthrough is linked to camera
        {
            transform.position = new Vector3(transform.position.x,ballloc.position.y,transform.position.z);
        }
    }
}
