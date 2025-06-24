using UnityEngine;
using UnityEngine.UI;

namespace VREscapeRoom.Logic
{
    public class DisplayTextTriggerGroup : TriggerGroup
    {
        [SerializeField] 
        private Text worldSpaceText;

        protected override void IsTriggeredValueChanged(bool previousValue, bool newValue)
        {
            base.IsTriggeredValueChanged(previousValue, newValue);
            worldSpaceText.enabled = newValue;
        }
    }
}