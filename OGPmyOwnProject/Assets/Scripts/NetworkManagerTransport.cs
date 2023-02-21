using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;

public class NetworkManagerTransport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NetworkManager.Singleton.GetComponent<UnityTransport>().SetConnectionData(
    "127.0.0.1",  // The IP address is a string
    (ushort)12345, // The port number is an unsigned short
    "0.0.0.0" // The server listen address is a string.
); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
