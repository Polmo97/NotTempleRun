using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace er06 {
    public class ActiveMeshRenderer : MonoBehaviour
    {
        [SerializeField] MeshRenderer mesh;

        private void Start()
        {
            mesh.enabled = false; 
        }
        public void ActiveMesh() {


            mesh.enabled = true; 
        }
    }



}

