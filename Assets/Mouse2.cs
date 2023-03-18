using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float verticalMouseInput = Input.GetAxis("Mouse Y");
        transform.Translate(new Vector3(verticalMouseInput * 0.1f, 0f, 0f));
        
    }
}
