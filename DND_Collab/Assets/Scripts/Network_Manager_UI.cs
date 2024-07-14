using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Netcode;
using UnityEngine.UI;

public class Network_Manager_UI : MonoBehaviour
{
    [SerializeField] private Button _serverBtn;
    [SerializeField] private Button _hostBtn;
    [SerializeField] private Button _clientBtn;

    private void Awake() {
        _serverBtn.onClick.AddListener(() => NetworkManager.Singleton.StartServer());
        _hostBtn.onClick.AddListener(() => NetworkManager.Singleton.StartHost());
        _clientBtn.onClick.AddListener(() => NetworkManager.Singleton.StartClient());    
    }
}
