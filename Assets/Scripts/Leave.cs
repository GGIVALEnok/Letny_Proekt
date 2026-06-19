using UnityEngine;

public class Leave : MonoBehaviour
{
    public GameObject player;
    public GameObject whatToLeave;
    public Transform LeavePoint;


    public void Interact()
    {
        whatToLeave = player.GetComponent<RayInteract>().WhatInArm3D;
        GameObject objectToLeave = Instantiate(whatToLeave, LeavePoint.position, LeavePoint.rotation);
        player.GetComponent<RayInteract>().WhatInArm3D = null;
        GameObject.FindWithTag("grabUI").SetActive(false);
        GameObject.FindWithTag("grabUI").SetActive(false);
    }
}
