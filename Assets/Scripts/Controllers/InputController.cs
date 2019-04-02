using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour
{
    public GameObject playerShip;

    public float step = 0.5F;

    void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        float axis = -Input.GetAxis("Horizontal");

        playerShip.transform.Translate(new Vector3((float)(axis * step), 0, 0));
    }

    void Stop()
    {
        Cursor.visible = true;
    }
}
