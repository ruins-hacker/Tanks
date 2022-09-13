using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMoveMent : MonoBehaviour
{
    private Rigidbody rigidbody;
    public int num = 1;
    public float speed = 5;
    public float anguSpeed = 30;
    public AudioClip[] audioClips;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody>();
        audioSource = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("HorizontalPlayer" + num);
        float v = Input.GetAxis("VerticalPlayer" + num);
        rigidbody.velocity = v * transform.forward * speed;
        rigidbody.angularVelocity = h * transform.up * anguSpeed;
        if(Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1)
        {
            if(audioSource.isPlaying == false)
            {
                audioSource.volume = 0.1f;
                audioSource.PlayOneShot(audioClips[1]);
            }
        } else
        {
            if (audioSource.isPlaying == false)
            {
                audioSource.volume = 0.1f;
                audioSource.PlayOneShot(audioClips[0]);
            }
        }
        
    }
}
