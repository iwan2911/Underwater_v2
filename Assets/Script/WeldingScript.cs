using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeldingScript : MonoBehaviour
{
    public ParticleSystem sparksEffect;
    public AudioSource weldingSound;
    [SerializeField] List<GameObject> WeldingTriggers;

    private void OnTriggerEnter(Collider other)
    {
        WeldingTriggers.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        WeldingTriggers.Remove(other.gameObject);
    }

    public void StartWelding()
    {
        if (WeldingTriggers.Count > 1)
        {
            sparksEffect.Play();
            weldingSound.Play();
            WeldingTriggers[0].transform.parent.parent.GetComponent<WeldingPiece>().Weld(WeldingTriggers);
        }
    }

    public void StopWelding()
    {
        sparksEffect.Stop();
        weldingSound.Stop();
    }
}