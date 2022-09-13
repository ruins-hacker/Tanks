using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
    public GameObject shell;
    public Transform shellPosition;
    public KeyCode keyCode = KeyCode.Space;
    public AudioClip audioClip;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            audio.volume = 0.5f;
            audio.Stop();
            audio.PlayOneShot(audioClip);
            GameObject go = GameObject.Instantiate(shell, shellPosition.position, shellPosition.rotation);
            go.tag = this.tag;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * 10;
        }
    }
}
