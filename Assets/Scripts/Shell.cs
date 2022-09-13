using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject shellExplosion;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        GameObject.Instantiate(shellExplosion, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);
        if(other.tag == "Tank1")
        {
            other.SendMessage("triggerTank1");
        } else if(other.tag == "Tank2") {
            other.SendMessage("triggerTank2");
        }
    }
}
