using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VREscapeRoom.Logic;

public class OpenDoorTriggerGroup : TriggerGroup
{
    [SerializeField] 
    private Vector3 EndPosDL;
    
    [SerializeField] 
    private Vector3 EndPosDR;
    
    [SerializeField] 
    private GameObject DoorLeft;
    
    [SerializeField] 
    private GameObject DoorRight;
    
    protected override void IsTriggeredValueChanged(bool previousValue, bool newValue)
    {
        base.IsTriggeredValueChanged(previousValue, newValue);
        StartCoroutine(LerpPosition(DoorLeft, EndPosDL, 4f));
        StartCoroutine(LerpPosition(DoorRight, EndPosDR, 4f));
    }
    
    private IEnumerator LerpPosition(GameObject door, Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = door.transform.localPosition;
        while (time < duration)
        {
            door.transform.localPosition = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        door.transform.localPosition = targetPosition;
    }
}
