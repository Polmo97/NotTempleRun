using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparoFreccia : MonoBehaviour
{
    [SerializeField] GameObject freccia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            freccia.SetActive(true);
        }
    }
}
