using System.Collections;
using UnityEngine;

public class Voprosy_ot_persa : MonoBehaviour
{

    public GameObject M1;
    public GameObject Odejda1;
    public GameObject Odejda2;
    public GameObject Tarelka;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Misl1());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && M1.activeInHierarchy) 
        {
            M1.SetActive(false);
        }
        /*
        else if (Input.GetMouseButtonDown(0) && Odejda2.activeInHierarchy)
        {
            Odejda2.SetActive(false);
        }
        else if (Input.GetMouseButtonDown(0) && Tarelka.activeInHierarchy)
        {
            Tarelka.SetActive(false);
        }*/
    }
    private IEnumerator Misl1()
    {
        yield return new WaitForSeconds(3f);
        M1.SetActive(true);
    }
}