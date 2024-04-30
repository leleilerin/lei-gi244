using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    private Animator anim;

    private Unit unit;

    private void ChooseAnimation(Unit u)
    {
        anim.SetBool("IsIdle", false);
        anim.SetBool("IsMove", false);
        anim.SetBool("IsAttack", false);
        anim.SetBool("IsBuild", false);
        anim.SetBool("IsChopping", false);
        anim.SetBool("IsDead", false);

        switch (u.State)
        {
            case UnitState.Idle:
                anim.SetBool("IsIdle", true);
                unit.UnitWeapon.SetActive(false);
                break;
            case UnitState.Move:
                anim.SetBool("IsMove", true);
                unit.UnitWeapon.SetActive(false);
                break;
            case UnitState.MoveToBuild:
                anim.SetBool("IsMove", true);
                unit.UnitWeapon.SetActive(false);
                break;
            case UnitState.BuildProgress:
                anim.SetBool("IsBuild", true);
                unit.UnitWeapon.SetActive(true);
                break;
            case UnitState.AttackUnit:
                anim.SetBool("IsAttack", true);
                unit.UnitWeapon.SetActive(true);
                break;
            case UnitState.AttackBuilding:
                anim.SetBool("IsAttack", true);
                unit.UnitWeapon.SetActive(true);
                break;
            case UnitState.Gather:
                anim.SetBool("IsChopping", true);
                unit.UnitWeapon.SetActive(true);
                break;
            case UnitState.MoveToResource:
                anim.SetBool("IsMove", true);
                unit.UnitWeapon.SetActive(false);
                break;
            case UnitState.DeliverToHQ:
                anim.SetBool("IsMove", true);
                unit.UnitWeapon.SetActive(false);
                break;
            case UnitState.StoreAtHQ:
                anim.SetBool("IsIdle", true);
                unit.UnitWeapon.SetActive(false);
                break;
            case UnitState.MoveToEnemy:
                anim.SetBool("IsMove", true);
                unit.UnitWeapon.SetActive(false);
                break;
            case UnitState.MoveToEnemyBuilding:
                anim.SetBool("IsMove", true);
                unit.UnitWeapon.SetActive(false);
                break;
            case UnitState.Die:
                anim.SetBool("IsDead", true);
                unit.UnitWeapon.SetActive(false);
                break;
        }
    }
    
    void Start()
    {
        anim = GetComponent<Animator>();
        unit = GetComponent<Unit>();
    }

    // Update is called once per frame
    void Update()
    {
        ChooseAnimation(unit);
    }
}
