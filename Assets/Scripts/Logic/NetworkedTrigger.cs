using System;
using Unity.Netcode;
using UnityEngine;

namespace VREscapeRoom.Logic
{
    /// <summary>
    /// A trigger that works for multiplayer
    /// </summary>
    public class NetworkedTrigger : NetworkBehaviour
    {
        public NetworkVariable<bool> IsTriggered;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag.Equals(Tags.Player))
            {
                IsTriggered.Value = !IsTriggered.Value;
            }
        }
    }
}