using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class GrabPasuda : MonoBehaviour
{
    public Transform Arm_R;
    public float speed = 0;
    float dist;

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
        Arm_R.position = Input.mousePosition;

        speed = (Arm_R.position - lastposition).magnitude;
        lastposition = Arm_R.position;

        dist = (Arm_R.position - transform.position).magnitude;
        if (dist <= 300 && speed >= 100)
        {
            Debug.Log(dirt.color.a);
            dirtColor.a -= 0.01f;
            dirt.color = dirtColor;
        }
    }

}
