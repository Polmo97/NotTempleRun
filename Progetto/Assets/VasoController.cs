using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasoController : MonoBehaviour
{
    [SerializeField] GameObject particleEffect;
    [SerializeField] GameObject oggettoNascosto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        oggettoNascosto.transform.position = transform.position;
        Instantiate(particleEffect, this.transform.position, particleEffect.transform.rotation);
        oggettoNascosto.SetActive(true);
        this.gameObject.SetActive(false);
       
    }
}
