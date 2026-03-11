using UnityEngine;
using System.Collections.Generic;

public class ParticleProximityInteraction : MonoBehaviour
{
    public GameObject target;
    public GameObject particles;
    private bool isThisTargetVisible = false;
    private bool isOtherTargetVisible = false;

    void Start()
    {
    }

    void Update()
    {
        if (!isThisTargetVisible || !isOtherTargetVisible)
        {
            particles.SetActive(false);
            return;
        }
        
        float distanceToTarget = Vector3.Distance(transform.position, target.transform.position);

        if (distanceToTarget < 0.5f)
        {
            particles.SetActive(true);
        }
        else
        {
            particles.SetActive(false);
        }
    }
    
    public void OnFirstTargetFound()
    {
        isThisTargetVisible = true;
    }

    public void OnFirstTargetLost()
    {
        isThisTargetVisible = false;
        particles.SetActive(false);
    }

    public void OnSecondTargetFound()
    {
        isOtherTargetVisible = true;
    }

    public void OnSecondTargetLost()
    {
        isOtherTargetVisible = false;
        particles.SetActive(false);
    }
}