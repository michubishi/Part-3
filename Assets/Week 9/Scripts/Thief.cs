using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        base.Attack();
        SpawnDagger();
        Invoke("SpawnDagger", 0.2f);
        speed = 6;
        Invoke("ResetSpeed", 0.4f);
    }

    void SpawnDagger()
    {
        Instantiate(daggerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }

    void ResetSpeed()
    {
        speed = 3;
    }
}
