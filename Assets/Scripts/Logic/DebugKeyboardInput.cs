#if UNITY_EDITOR

using UnityEngine;

namespace VREscapeRoom.Logic
{
    public class DebugKeyboardInput : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * (Time.deltaTime * 6);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * (Time.deltaTime * 6);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.forward * (Time.deltaTime * 6);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.back * (Time.deltaTime * 6);
            }
        }
    }
}

#endif