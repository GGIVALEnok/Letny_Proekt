using UnityEngine;

public class RayInteract : MonoBehaviour
{
    public float range = 10f;
    public GameObject InteractText;
    public GameObject WhatInArm3D;
    public int Score;

    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        RaycastHit hit;


        if(Physics.Raycast(origin, direction, out hit, range))
        {
            if(hit.collider.tag == "grabObject" && !WhatInArm3D)
            {
                //Debug.Log("Hit: " + hit.collider.name);
                InteractText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.collider.GetComponent<Grab>().Interact();
                    InteractText.SetActive(false);
                }
    
            }
            else if(hit.collider.tag == "LeaveObject" && WhatInArm3D)
            {
                //Debug.Log("Hit: " + hit.collider.name);
                InteractText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.collider.GetComponent<Leave>().Interact();
                    InteractText.SetActive(false);
                }

            }
            else
            {
                InteractText.SetActive(false);
            }

        }
        else
        {
            InteractText.SetActive(false);
        }
        
    }
}
