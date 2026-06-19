using UnityEngine;
using UnityEngine.UI;

public class scroll : MonoBehaviour
{
    public Scrollbar Scrollbar;
    public float max;
    public float min;
    float scrolly;
    float value;

    public void Move()
    {
        value = Scrollbar.value;
        scrolly = Mathf.Lerp(min, max, value);
        transform.position = new Vector3(transform.position.x, scrolly, 0);
    }
}
