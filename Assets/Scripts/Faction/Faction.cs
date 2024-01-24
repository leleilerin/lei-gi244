using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Nation
{
    Neutral = 0,
    Britain,
    Pirate,
    France,
    Spain,
    Portuguese,
    Dutch
}
public class Faction : MonoBehaviour
{
    [SerializeField] private Nation nation;
    public  Nation Nation
    {
        get { return nation; }
    }

    [Header("Resources")]
    [SerializeField] private int food;
    public int Food
    {
        get { return food; }
    }

    [SerializeField] private int wood;
    public int Wood
    {
        get { return wood; }
    }
    
    [SerializeField] private int gold;
    public int Gold
    {
        get { return gold; }
    }
    
    [SerializeField] private int stone;
    public int Stone
    {
        get { return stone; }
    }
    
}
