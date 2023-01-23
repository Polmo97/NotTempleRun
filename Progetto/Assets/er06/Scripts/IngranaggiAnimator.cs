using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class IngranaggiAnimator : MonoBehaviour
    {
        [SerializeField] private Animator obj;
        [SerializeField] bool ingranaggi = false;
        private float offset;
        public void GiroOrario()
        {
            if (ingranaggi)
                obj.SetFloat("AnimationSpeed", 1f);
            else
                obj.SetBool("Inverti", true);
        }

        public void GiroAntiorario()
        {
            if (ingranaggi)
                obj.SetFloat("AnimationSpeed", -1f);
            else
                obj.SetBool("Inverti", false);
        }
    }
}

