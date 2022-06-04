using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public Object Test;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(speed,0,0);
        

        if (Input.anyKey)
        {
            Vector3 jump = new Vector3(0,speed,0);
            movement += jump;
        }
        movement *= Time.deltaTime;
        transform.Translate(movement);



    }
}
