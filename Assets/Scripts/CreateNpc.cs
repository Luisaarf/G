using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNpc : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] private Transform firePoint;
    [SerializeField] private float npcCreationCooldown;
    [SerializeField] private GameObject adultNpc;
    [SerializeField] private float cooldownTimer = Mathf.Infinity;

    void InstantiateNpc()
    {

        Instantiate(adultNpc, transform.position, transform.rotation, this.transform);
        cooldownTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownTimer > npcCreationCooldown)
        {
            InstantiateNpc();
        }
        cooldownTimer += Time.deltaTime;
    }
}
