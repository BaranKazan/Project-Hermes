using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

namespace Com.BaranKazan.ProjectHermes
{
    public class Look : MonoBehaviour
    {
        public static bool cursorLocked = true;
        
        public Transform player;
        public Transform cams;

        public float xSensivity;
        public float ySensivity;
        public float maxAngle;

        private Quaternion camCenter;

        // Start is called before the first frame update
        void Start()
        {
            camCenter = cams.localRotation;
        }

        // Update is called once per frame

        void Update()
        {
            SetY();
            SetX();
            UpdateCursorLocked();
        }

        void SetY()
        {
            float tempInput = Input.GetAxis("Mouse Y") * ySensivity * Time.deltaTime;
            Quaternion tempAdjustment = Quaternion.AngleAxis(tempInput, -Vector3.right);
            Quaternion tempDelta = cams.localRotation * tempAdjustment;
            
            if(Quaternion.Angle(camCenter, tempDelta) < maxAngle)
                cams.localRotation = tempDelta;
        }
        
        void SetX()
        {
            float tempInput = Input.GetAxis("Mouse X") * xSensivity * Time.deltaTime;
            Quaternion tempAdjustment = Quaternion.AngleAxis(tempInput, Vector3.up);
            Quaternion tempDelta = player.localRotation * tempAdjustment;
            player.localRotation = tempDelta;
        }

        void UpdateCursorLocked()
        {
            if (cursorLocked)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    cursorLocked = false;
                }
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    cursorLocked = true;
                }
            }
        }
        
    }
}