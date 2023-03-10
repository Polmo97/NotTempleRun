using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class PallinaController : MonoBehaviour
    {
        Vector3 posizioneIniziale;
        [SerializeField] GameObject spawnChiaveLocation;
        [SerializeField] GameObject chiave;
        [SerializeField] Rigidbody rigidbody;
        [SerializeField] ConstantForce constantForce;
        // Start is called before the first frame update
        void Start()
        {
            posizioneIniziale = this.transform.position;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Respawn")
            {
                transform.position = posizioneIniziale;
                rigidbody.velocity = new Vector3(0, 0, 0);
            }

            if (other.gameObject.tag == "Traguardo")
            {
                GameObject chiaveSpawnata = Instantiate(chiave, spawnChiaveLocation.transform.position, spawnChiaveLocation.transform.rotation);
                Destroy(this.gameObject);
            }
            if (other.gameObject.tag == "GameController")
            {
                constantForce.force = new Vector3(-3f, 11f, 0);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "GameController")
            {
                constantForce.force = new Vector3(0, 0, 0);
            }
        }
    }
}
