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
        // this should make sure that no audio is played if either target is not visible
        if (!isThisTargetVisible || !isOtherTargetVisible)
        {
            particles.SetActive(false);
            return;
        }
        
        // takes the distance and if it is less than the max distance, particled enabled
        // otherwise particles disabled
        float distanceToTarget = Vector3.Distance(transform.position, target.transform.position);

        if (distanceToTarget < 0.3f)
        {
            particles.SetActive(true);
        }
        else
        {
            particles.SetActive(false);
        }
    }
    
    // these methods are just to ensure that the audio is only played if the target is visible
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