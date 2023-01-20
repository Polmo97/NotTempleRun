using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class StoneController : MonoBehaviour
    {
        int counter = 0;
        [SerializeField] GameObject particleEffect;
        [SerializeField] GameObject fire;
        bool dentroFuoco = false;
        // Start is called before the first frame update



        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Legno"))
            {
                dentroFuoco = true;

            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (dentroFuoco)
            {
                if (collision.gameObject.CompareTag("Stone"))
                {
                    counter++;
                    Debug.Log("CONTA" + counter);
                    ContactPoint contact = collision.contacts[0];
                    Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
                    Vector3 pos = contact.point;
                    Instantiate(particleEffect, pos, rot);
                    if (counter >= 3)
                    {
                        fire.SetActive(true);
                    }
                }
            }
        }
    }
}

