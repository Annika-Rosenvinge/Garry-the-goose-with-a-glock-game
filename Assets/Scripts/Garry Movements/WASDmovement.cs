using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDmovement : MonoBehaviour{
    float speed;
    // Start is called before the first frame update
    void Start(){
        //RigidBody rigidBody = GetComponent<RigidBody>();
        speed = 5.0f;
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(0, -1, 0);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }

    }
}