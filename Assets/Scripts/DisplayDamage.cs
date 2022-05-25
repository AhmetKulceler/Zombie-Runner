using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas damageRecievedCanvas;
    [SerializeField] float damageDisplayTime = 0.3f;

    void Start()
    {
        damageRecievedCanvas.enabled = false;
    }

    public void ShowDamageRecievedCanvas()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        damageRecievedCanvas.enabled = true;
        yield return new WaitForSeconds(damageDisplayTime);
        damageRecievedCanvas.enabled = false;
    }
}
