using UnityEngine;

public class SoundProximityInteraction : MonoBehaviour
{
    // This code changes the sphere's color based on how far it is from the other image target
    public float maxDistance = 0.5f;
    public GameObject target;
    public AudioClip audioClip;
    private AudioSource audioSource;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        // gives a distance between the two objects
        float distance = Vector3.Distance(this.transform.position, target.transform.position);

        if (distance <= maxDistance)
        {
            Debug.Log("Sound is playing");
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            Debug.Log("Sound is stopped");
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }
    
    public void OnTargetLost()
    {
        audioSource.Stop();
    }
}
