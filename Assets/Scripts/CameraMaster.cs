using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMaster : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            //cam.transform.position=cam.transform.position+ new Vector3(1,0,0);

            var position=cam.transform.position;
            position.x+=1;
            cam.transform.position=position;

            
        }

    }
}
