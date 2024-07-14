using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    public static Player_Manager Instance { get; private set; }

    [SerializeField] private TMP_InputField _inputField;
    public TMP_InputField InputField { get { return _inputField; } }

    [SerializeField] private TextMeshProUGUI _textPrefab;
    public TextMeshProUGUI TextPrefab { get { return _textPrefab; } }

    [SerializeField] private Transform _textParent; // The text parent handles the positioning and scale of the text
    public Transform TextParent { get { return _textParent; } }

    private void Awake()
    {
        if(Instance == null) Instance = this;
        else Destroy(gameObject);

    }
}
