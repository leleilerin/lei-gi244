using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera cam;

    [Header("Move")] 
    [SerializeField] private float moveSpeed;

    [SerializeField] private float xInput;
    [SerializeField] private float zInput;

    public static CameraController instance;

}
