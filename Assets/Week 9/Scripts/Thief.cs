using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;
    float dashSpeed = 7;
    Coroutine dashing;
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        if(dashing != null)
        {
            StopCoroutine(dashing);
        }
        dashing = StartCoroutine(Dash());

    }
    
    void ResetSpeed()
    {
        speed = 3;
    }

    IEnumerator Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = dashSpeed;
        while (speed > 3)
        {
            yield return null;
        }

        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        yield return new WaitForSeconds(0.2f);
        Instantiate(daggerPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }


}
