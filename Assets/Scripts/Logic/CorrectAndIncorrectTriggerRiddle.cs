using UnityEngine;

namespace VREscapeRoom.Logic
{
    public class CorrectAndIncorrectTriggerRiddle : Riddle
    {
        [SerializeField] private GameObject particleSystem;
        [SerializeField] private NetworkedTrigger[] incorrectTrigger;

        public override void OnNetworkSpawn()
        {
            for (int i = 0; i < incorrectTrigger.Length; ++i)
            {
                incorrectTrigger[i].IsTriggered.OnValueChanged += IncorrectTriggerValueChanged;
            }
            
            for (int i = 0; i < triggers.Length; ++i)
            {
                triggers[i].IsTriggered.OnValueChanged += IsTriggeredValueChanged;
            }
        }

        public override void OnNetworkDespawn()
        {
            for (int i = 0; i < incorrectTrigger.Length; ++i)
            {
                incorrectTrigger[i].IsTriggered.OnValueChanged -= IncorrectTriggerValueChanged;
            }
            for (int i = 0; i < triggers.Length; ++i)
            {
                triggers[i].IsTriggered.OnValueChanged -= IsTriggeredValueChanged;
            }
        }

        protected override void OnRiddleSolved()
        {
            particleSystem.SetActive(true); 
        }

        private void IncorrectTriggerValueChanged(bool previousValue, bool newValue)
        {
            if (newValue)
            {
                ResetRiddle();
            }
        }

        private void ResetRiddle()
        {
            for (int i = 0; i < incorrectTrigger.Length; i++)
            {
                incorrectTrigger[i].IsTriggered.Value = false;
            }

            for (int i = 0; i < triggers.Length; ++i)
            {
                triggers[i].IsTriggered.Value = false;
            }
        }
    }
}