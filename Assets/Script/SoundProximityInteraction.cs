using UnityEngine;
using Vuforia;

public class SoundProximityInteraction : MonoBehaviour
{
    public float maxDistance = 0.5f;
    public GameObject target;
    public AudioClip audioClip;
    private AudioSource audioSource;
    private bool isThisTargetVisible = false;
    private bool isOtherTargetVisible = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    void Update()
    {
        // this should make sure that no audio is played if either target is not visible
        if (!isThisTargetVisible || !isOtherTargetVisible)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            return;
        }
    
        // takes the distance and if it is less than the max distance, sound is played
        // otherwise sound is stopped
        float distance = Vector3.Distance(this.transform.position, target.transform.position);

        if (distance <= maxDistance)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
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
        audioSource.Stop();
    }

    public void OnSecondTargetFound()
    {
        isOtherTargetVisible = true;
    }

    public void OnSecondTargetLost()
    {
        isOtherTargetVisible = false;
        audioSource.Stop();
    }
}