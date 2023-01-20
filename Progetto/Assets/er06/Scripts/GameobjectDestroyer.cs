using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace er06 {

    public class GameobjectDestroyer : MonoBehaviour
    {
        public UnityEvent OnDestroyFinish;
        public float time;
        [SerializeField] GameObject _gameObject;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(Wait(time));
            Destroy(_gameObject, time + 0.5f);

        }

        IEnumerator Wait(float time)
        {

            yield return new WaitForSeconds(time);
            OnDestroyFinish.Invoke();
        }
    }




}
