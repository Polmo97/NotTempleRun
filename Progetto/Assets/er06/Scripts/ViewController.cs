using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    [SerializeField] private GameObject pianoNero;
    // Start is called before the first frame update
    void Start()
    {
        pianoNero.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Scenario")
            pianoNero.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Scenario")
            pianoNero.SetActive(false);
    }
}
