using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorciaController : MonoBehaviour
{
    [SerializeField] GameObject particleEffect; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Respawn")) {

            particleEffect.SetActive(true);
        }
      
    }
  
}
