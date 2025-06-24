namespace VREscapeRoom.Logic
{
    /// <summary>
    /// A riddle is associated with triggers. When all triggers are triggered the riddle is solved.
    /// </summary>3bg5t
    public abstract class Riddle : TriggerGroup
    {
        protected abstract void OnRiddleSolved();
        
        protected override void IsTriggeredValueChanged(bool previousValue, bool newValue)
        {
            base.IsTriggeredValueChanged(previousValue, newValue);
            
            if (!newValue)
            {
                return;
            }

            CheckIfRiddleIsSolved();
        }

        private void CheckIfRiddleIsSolved()
        {
            bool allTriggered = true;
            for (int i = 0; i < triggers.Length; ++i)
            {
                if (!triggers[i].IsTriggered.Value)
                {
                    allTriggered = false;
                    break;
                }
            }

            if (allTriggered)
            {
                OnRiddleSolved();
            }
        }
    }
}