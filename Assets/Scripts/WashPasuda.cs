using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.UI;
public class WashPasuda : MonoBehaviour
{
    public Transform Arm_L;
    public float speed = 0;
    float dist;
    public LeaveTarelka LeaveTarelka;

    public Image dirt;
    Color dirtColor = Color.white;

    Vector3 lastposition = Vector3.zero;
    Vector3 mouse;

    private void Start()
    {
        dirtColor.a = 1f;
        dirt.color = dirtColor;

    }

    private void FixedUpdate()
    {
        transform.position = Input.mousePosition;

        speed = (transform.position - lastposition).magnitude;
        lastposition = transform.position;  

        dist = (Arm_L.position - transform.position).magnitude;
        if (dist <= 300 && speed >= 100)
        {
            Debug.Log(dirt.color.a);
            if (dirtColor.a >= 0.7f)
            {
                dirtColor.a -= 0.01f;
                dirt.color = dirtColor;

            }

            else if (dirtColor.a <= 0.7f && dirtColor.a >= 0)
            {
                dirtColor.a -= 0.1f;
                dirt.color = dirtColor;
            }
            else
            {
                LeaveTarelka.Interact_Tarelka();

            }
        }
    }

}
