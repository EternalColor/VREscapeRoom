using Unity.Netcode;
using UnityEngine;

namespace VREscapeRoom.Logic
{
    public class CopyTransformFromVRHands : NetworkBehaviour
    {
        [SerializeField] 
        private string handTag;

        private GameObject handGameObject;
        
        private void Start()
        {
           handGameObject = GameObject.FindWithTag(handTag);
        }
        
        private void Update()
        {
            if (handGameObject != null&& IsOwner)
            {
                transform.position = handGameObject.transform.position;
                transform.rotation = handGameObject.transform.rotation;
            }
        }
    }
}

