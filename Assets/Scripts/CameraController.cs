using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera cam;

    [Header("Move")] 
    [SerializeField] private float moveSpeed;

    [SerializeField] private Transform corner1;
    [SerializeField] private Transform corner2;

    [SerializeField] private float xInput;
    [SerializeField] private float zInput;

    public static CameraController instance;

    void Awake()
    {
        instance = this;
        cam = Camera.main;
    }

    void Start()
    {
        moveSpeed = 50;
    }

    private void MoveByKB()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        Vector3 dir = (transform.forward * zInput) + (transform.right * xInput);

        transform.position += dir * moveSpeed * Time.deltaTime;
        transform.position = Clamp(corner1.position, corner2.position);
    }

    void Update()
    {
        MoveByKB();
    }
    
    private Vector3 Clamp(Vector3 lowerLeft, Vector3 topRight)
    {
        Vector3 pos = new Vector3(Mathf.Clamp(transform.position.x, lowerLeft.x, topRight.x),
            transform.position.y,
            Mathf.Clamp(transform.position.z, lowerLeft.z, topRight.z));

        return pos;
    }
}
