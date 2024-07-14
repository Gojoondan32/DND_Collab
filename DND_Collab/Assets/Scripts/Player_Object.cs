using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player_Object : NetworkBehaviour
{
    private void Start() {
        Player_Manager.Instance.InputField.onSubmit.AddListener(OnSubmit); // There is no on submit event in the inspector so we have to add it here
    }

    private void OnSubmit(string value) {
        if(!IsOwner) return;

        TextMeshProUGUI text = Instantiate(Player_Manager.Instance.TextPrefab, Vector3.zero, Quaternion.identity, Player_Manager.Instance.TextParent);
        text.text = value;
    }
}
