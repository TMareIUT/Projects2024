using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] KeyCode upInput;
    [SerializeField] KeyCode downInput;
    private float speed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(upInput))
        {
            transform.Translate(Vector3.up * speed);
        }
        if (Input.GetKey(downInput))
        {
            transform.Translate(Vector3.down * speed);
        }
    }
}
