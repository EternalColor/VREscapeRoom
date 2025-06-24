using Unity.Netcode;
using UnityEngine;

namespace VREscapeRoom.Logic
{
    public class CopyTransformFromVRCam : NetworkBehaviour
    {
        private Transform vrCameraTransform;

        private void Awake()
        {
            vrCameraTransform = Camera.main.transform;
        }

        private void Update()
        {
            if (vrCameraTransform != null && IsOwner)
            {
                transform.position = vrCameraTransform.position;
                transform.rotation = vrCameraTransform.rotation;
            }
        }
    }
}