using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Player_Network : NetworkBehaviour
{
    [SerializeField] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsOwner) return;
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        transform.position += new Vector3(inputX, inputY, 0) * _speed * Time.deltaTime;
    }
}
