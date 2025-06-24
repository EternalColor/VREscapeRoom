using System;
using Unity.Netcode;
using UnityEngine;

namespace VREscapeRoom.Logic
{
    /// <summary>
    /// Trigger group consists of multiple networked triggers
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public abstract class TriggerGroup : NetworkBehaviour
    {
        [SerializeField] 
        protected NetworkedTrigger[] triggers;

        private AudioSource sfxAudioSource;

        private void Awake()
        {
            sfxAudioSource = GetComponent<AudioSource>();
        }

        public override void OnNetworkSpawn()
        {
            for (int i = 0; i < triggers.Length; ++i)
            {
                triggers[i].IsTriggered.OnValueChanged += IsTriggeredValueChanged;
            }
        }

        public override void OnNetworkDespawn()
        {
            for (int i = 0; i < triggers.Length; ++i)
            {
                triggers[i].IsTriggered.OnValueChanged -= IsTriggeredValueChanged;
            }
        }

        protected virtual void IsTriggeredValueChanged(bool previousValue, bool newValue)
        {
           sfxAudioSource.PlayOneShot(sfxAudioSource.clip);
        }
    }
}