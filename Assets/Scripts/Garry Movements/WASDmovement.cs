using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDmovement : MonoBehaviour{
    float speed;
    public Animator animator;
    public GameObject DanceParty;
    // Start is called before the first frame update
    void Start(){
        //RigidBody rigidBody = GetComponent<RigidBody>();
        speed = 7.0f;
    }

    // Update is called once per frame
    void Update(){
        //playermovement
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(0, -1, 0);
            animator.SetBool("Walk",true);
            
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(0, 1, 0);
            animator.SetBool("Walk",true);
            
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            animator.SetBool("Walk",true);
           
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
            animator.SetBool("Walk",true);
           
        }
        if(Input.GetKey(KeyCode.P)){
            animator.SetBool("Dancing", true);
            DanceParty.SetActive(true);

        }
        else if(!Input.anyKey){
            animator.SetBool("Walk", false);
            animator.SetBool("Dancing", false);
            DanceParty.SetActive(false);

        }

    }
}
