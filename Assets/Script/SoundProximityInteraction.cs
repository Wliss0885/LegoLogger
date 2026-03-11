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
        if (!isThisTargetVisible || !isOtherTargetVisible)
        {
            if (audioSource.isPlaying)
            {
                Debug.Log("Sound is stopped - target out of frame");
                audioSource.Stop();
            }
            return;
        }

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

    public void OnTargetFound()
    {
        isThisTargetVisible = true;
    }

    public void OnTargetLost()
    {
        isThisTargetVisible = false;
        audioSource.Stop();
    }

    public void OnOtherTargetFound()
    {
        isOtherTargetVisible = true;
    }

    public void OnOtherTargetLost()
    {
        isOtherTargetVisible = false;
        audioSource.Stop();
    }
}