using System.Collections;
using UnityEngine;

public class Voprosy_ot_persa : MonoBehaviour
{

    public GameObject InteractMysl1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Misl1());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && InteractMysl1.activeInHierarchy) 
        {
            InteractMysl1.SetActive(false);
        }
    }

    private IEnumerator Misl1()
    {
        yield return new WaitForSeconds(10f);
        InteractMysl1.SetActive(true);
    }
}