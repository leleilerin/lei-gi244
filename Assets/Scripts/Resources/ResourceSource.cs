using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum ResourceType
{
    Food,
    Wood,
    Gold,
    Stone
}
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private string rsrcName;
    public string RsrcName { get { return rsrcName; } }

    [SerializeField] private Sprite rsrcPic;
    public Sprite RsrcPic { get { return rsrcPic; } }

    [SerializeField] private ResourceType rsrcType;
    public ResourceType RsrcType { get { return rsrcType; } }

    [SerializeField] private int quantity;
    public int Quantity { get { return quantity; } set { quantity = value; } }

    [SerializeField] private int maxQuantity;

    [SerializeField] private GameObject selectionVisual;
    public GameObject SelectionVisual { get { return selectionVisual; } }
    
    //Selection Ring
    [SerializeField]
    private UnityEvent onRsrcQuantityChange;
    [SerializeField]
    private UnityEvent onInfoQuantityChange;
}
