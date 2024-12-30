using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.Interaction.Toolkit;

public class WeldingPiece : MonoBehaviour
{
    public void Weld(List<GameObject> WeldingTriggers)
    {
        for (int i = 1; i < WeldingTriggers.Count; i++)
        {
            if (WeldingTriggers[i].transform.parent.parent != transform)
            {
                GameObject oldParent = WeldingTriggers[i].transform.parent.parent.gameObject;
                WeldingTriggers[i].transform.parent.SetParent(transform);
                Destroy(oldParent);
            }
        }
    }
}