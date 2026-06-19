using System.Collections;
using UnityEngine;

public class RayInteract : MonoBehaviour
{
    public float range = 10f;
    public float ochered = -1f;
    public GameObject InteractText;
    public GameObject WhatInArm3D;
    public GameObject Odejda1;
    public GameObject Odejda2;
    public GameObject Tarelka;
    public int Score;
    public bool tarelka = false;

    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        RaycastHit hit;


        if(Physics.Raycast(origin, direction, out hit, range))
        {
            if(hit.collider.tag == "grabObject" && !WhatInArm3D && !tarelka)
            {
                //Debug.Log("Hit: " + hit.collider.name);
                InteractText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.collider.GetComponent<Grab>().Interact();
                    InteractText.SetActive(false);
                    Odejda1.SetActive(true);
                    StartCoroutine(MOdejda1());
                }
                /*else if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.collider.GetComponent<Grab>().Interact();
                    InteractText.SetActive(false);
                    Odejda2.SetActive(true);
                }
                */
            }
            else if(hit.collider.tag == "LeaveObject" && WhatInArm3D && !tarelka)
            {
                //Debug.Log("Hit: " + hit.collider.name);
                InteractText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.collider.GetComponent<Leave>().Interact();
                    InteractText.SetActive(false);
                }

            }
            else if (hit.collider.tag == "tarelka" && !WhatInArm3D && !tarelka)
            {
                //Debug.Log("Hit: " + hit.collider.name);
                InteractText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.collider.GetComponent<Grab>().Interact();
                    InteractText.SetActive(false);
                    tarelka = true;
                    Tarelka.SetActive(true);
                    StartCoroutine(MTarelka());
                }

            }
            else if (hit.collider.tag == "LeaveTarelka" && WhatInArm3D && tarelka)
            {
                //Debug.Log("Hit: " + hit.collider.name);
                InteractText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.F))
                {
                    hit.collider.GetComponent<LeaveTarelka>().Interact_Wash();
                    InteractText.SetActive(false);
                    tarelka = false;
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

    private IEnumerator MOdejda1()
    {
        yield return new WaitForSeconds(5f);
        Odejda1.SetActive(false);
    }
    private IEnumerator MTarelka()
    {
        yield return new WaitForSeconds(5f);
        Tarelka.SetActive(false);
    }

}
