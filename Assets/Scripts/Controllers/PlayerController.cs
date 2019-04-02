using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private enum MachineGunStates {
        Cooldown,
        Ready
    }

    public int score;

    public int lives;

    public GameObject playerShip;

    public GameObject playerRocket;

    public float step = 0.5F;

    public float machineGunTimeout = 0.001F;

    private float machineGunTimeLeft = 0;

    void Start()
    {
        Cursor.visible = false;
    }

    private void MachineGunUpdade()
    {
        if (machineGunTimeLeft > 0)
        {
            machineGunTimeLeft -= Time.deltaTime;
        }
    }

    private void MachineGunFire() {
        if (machineGunTimeLeft <= 0)
        {
            Instantiate(playerRocket, playerShip.transform.position, playerShip.transform.rotation);
            machineGunTimeLeft = machineGunTimeout;
        }
    }

    private void Update() {
        MachineGunUpdade();
    }

    private void FixedUpdate()
    {
        float axis = -Input.GetAxis("Horizontal");

        playerShip.transform.Translate(new Vector3((float)(axis * step), 0, 0));

        if (Input.GetButton("Fire1"))
            MachineGunFire();
    }

    void Stop()
    {
        Cursor.visible = true;
    }
}
