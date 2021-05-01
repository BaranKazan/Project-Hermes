using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.Baran.ProjectHermes
{

    public class NewBehaviourScript : MonoBehaviour
    {

        public float speed;
        private Rigibody rig;
        fl

        private void Start()
        {
            rig = GetComponent<Rigibody>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            float tempVMove = Input.Get;
            float tempHMove;
        }
    }
}
