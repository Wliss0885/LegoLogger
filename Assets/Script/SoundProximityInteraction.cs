using UnityEngine;
using Vuforia;

public class SoundProximityInteraction : MonoBehaviour
{
    // max distance for the sound to be played
    public float maxDistance = 0.5f;
    // target object
    public GameObject target;
    // audio clip to be played when both objects are in proximity
    public AudioClip audioClip;
    // the source object's audio source
    private AudioSource audioSource;
    // booleans to check if either target is visible
    private bool isThisTargetVisible = false;
    private bool isOtherTargetVisible = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get the audio source and set the clip to be played
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }

    // Update is called once per frame
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