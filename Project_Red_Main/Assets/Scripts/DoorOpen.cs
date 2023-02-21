using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Inventory inventory;
    public Animator anim;

    public bool lockedDoor;

    public void OnTriggerEnter(Collider other)
    {
        if (!lockedDoor)
        {
            anim.Play("DoorOpen");
        }
    }

    public void OnTriggerStay(Collider other)
    {

        if (lockedDoor && Input.GetKeyDown(KeyCode.E) && inventory.vialAmount >= 1)
        {
            inventory.DepleateVial();
            anim.Play("DoorOpen");
        }
    }
}
