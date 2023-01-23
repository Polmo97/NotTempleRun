using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {

    public class SparoFreccia : MonoBehaviour
    {
        [SerializeField] GameObject freccia;
        // Start is called before the first frame update
        private void OnTriggerStay(Collider other)
        {
            Debug.Log("wewuehwuhwu" + other.gameObject.tag);
            if (other.gameObject.tag == "Player"){

                freccia.SetActive(true);
            }
        }
    }

        //    private void OnTriggerStay(Collider other)
        //{
            
        //    
        //}
}
