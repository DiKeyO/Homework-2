using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Opendoor : MonoBehaviour {

    public float interectDistance = 0f;
    private Animator anim; 
    void Start ()
    {
        anim = GetComponent<Animator>();
    }
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("door");
            
        }
        if (Input.GetKeyDown (KeyCode.Mouse0))
        {
        
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast (ray, out hit, interectDistance))
            {
                if (hit.collider.CompareTag ("Cube (2)"))
                {
                    //hit.collider.transform.parent.GetComponent<Gate>().changeGateState(); 
                }
            }
        }
    } 
}

      