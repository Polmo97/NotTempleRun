using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace er06 {

    public class ChestController : MonoBehaviour
    {
        public UnityEvent OnChestOpen;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Key"))
            {
                Debug.Log("SUDSSAUAH" +
                    "");
                OnChestOpen.Invoke();

            }
        }
    }



}
