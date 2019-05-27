using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkController : NetworkBehaviour 
{
    [SerializeField] private NetworkManager networkManager;

    public void Server()
    {
        NetworkClient host = networkManager.StartHost();

        if (host.isConnected)
            Debug.Log("Host conectado.");
        else
            Debug.Log("Erro ao conectar Host.");
    }

    public void Client()
    {
        NetworkClient client = networkManager.StartClient();
        if (client.isConnected)
            Debug.Log("Cliente conectado.");
        else
            Debug.Log("Erro ao conectar Cliente.");
    }
}
