using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    [SerializeField]
    private GameObject selectionMarker;
    public GameObject SelectionMarker {  get { return selectionMarker; } }
    
    public static MainUI instance;

    private void Awake()
    {
        instance = this;
    }
}
