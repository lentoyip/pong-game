using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float horizontalMouseInput = Input.GetAxis("Mouse X");
        transform.Translate(new Vector3(horizontalMouseInput * 0.2f, 0f, 0f));
        
    }
}
