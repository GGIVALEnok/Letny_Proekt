using UnityEngine;
using UnityEngine.UI;

public class LeaveTarelka : MonoBehaviour
{
    public GameObject player;
    public GameObject whatToLeave;
    public Transform LeavePoint;
    public GameObject Gubka;

    public void Interact_Wash()
    {
        Gubka.SetActive(true);
        player.GetComponent<FirstPersonLook>().enabled = false;
        GetComponent<Rigidbody>().freezeRotation = false;
    }
    public void Interact_Tarelka()
    {
        whatToLeave = player.GetComponent<RayInteract>().WhatInArm3D;
        GameObject objectToLeave = Instantiate(whatToLeave, LeavePoint.position, LeavePoint.rotation);
        player.GetComponent<RayInteract>().WhatInArm3D = null;
        GameObject.FindWithTag("grabUI").SetActive(false);
        GameObject.FindWithTag("grabUI").SetActive(false);
        player.GetComponent<FirstPersonLook>().enabled = true;
        //player.GetComponent<RayInteract>().Score += 1;
        GetComponent<Rigidbody>().freezeRotation = true;

    }
}
