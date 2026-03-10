using UnityEngine;
using System.Collections.Generic;

public class ProximityInteraction : MonoBehaviour
{
    public GameObject target;
    public GameObject particles;

    void Start()
    {
    }

    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.transform.position);

        if (distanceToTarget < 1 && particles.activeSelf == false)
        {
            particles.SetActive(true);
        }
        else if (distanceToTarget > 1 && particles.activeSelf == true)
        {
            particles.SetActive(false);
        }
    }
}