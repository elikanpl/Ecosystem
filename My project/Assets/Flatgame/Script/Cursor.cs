using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.D))
        {
            //vectors have direction and magnitude
            //equivalent of x += 1; in GML
            //Use this. to be specific about what you are referring to. It refers to the specific instance of the object you attached the script to
            vel += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            vel -= new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            vel += new Vector3(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            vel -= new Vector3(0, speed, 0);
        }

        //save inputs into a value that affects the player once at the end so you don't get weird issues when pressing two keys at once
        this.transform.position += vel * 0.8f;
    }
}