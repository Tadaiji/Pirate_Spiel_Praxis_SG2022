using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float Score = 0;

    public BoxCollider2D box;

    [SerializeField]
    public Text ScoreUi;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void FixedUpdate()
    {
        Score += 1;
        ScoreUi.text = "Score: " + Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(speed, 0, 0);


        if (Input.anyKey)
        {
            Vector3 jump = new Vector3(0, speed, 0);
            movement += jump;
        }
        movement *= Time.deltaTime;
        transform.Translate(movement);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if(coll.gameObject.tag == "Collectable")
        {
            Debug.Log("Hit");
            Score += 100;
        }

    }
}
