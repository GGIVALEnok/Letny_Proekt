using UnityEngine;

public class Grab : MonoBehaviour
{
    //public Animator Door;
    public GameObject player;
    public GameObject arm;
    public GameObject WhatInArmSprite;
    public GameObject WhatIAm;
    //public string WhatInArmTxt;
    
    public void Interact()
    {
        //Door.SetBool("Key", true);
        arm.SetActive(true);
        WhatInArmSprite.SetActive(true);
        player.GetComponent<RayInteract>().WhatInArm3D = WhatIAm;
        Destroy(gameObject);
    }


}
