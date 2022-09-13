using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    private Camera camera;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ((player1.position + player2.position)/2);
    }

    // Update is called once per frame
    void Update()
    {
        camera = transform.GetComponent<Camera>();
    }

    private void LateUpdate()
    {
        transform.position = offset + (player1.position + player2.position) / 2;
        float distance = Vector3.Distance(player1.position, player2.position);
        camera.orthographicSize = Mathf.Max(distance * (6.4f / 7.83f), 5);
    }
}
