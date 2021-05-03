using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.BaranKazan.ProjectHermes
{
    public class Motion : MonoBehaviour
    {

        public float speed;
        
        //Main character
        private Rigidbody rig;
        // Start is called before the first frame update
        private void Start()
        {
            Camera.main.enabled = false;
            rig = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            float tempHMove = Input.GetAxisRaw("Horizontal");
            float tempVMove = Input.GetAxisRaw("Vertical");
            Vector3 tempDirection = new Vector3(tempHMove, 0, tempVMove);
            tempDirection.Normalize();
            rig.velocity = transform.TransformDirection(tempDirection) * (speed * Time.deltaTime);


        }
    }    
}

