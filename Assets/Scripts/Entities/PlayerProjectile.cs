using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour
{
    public float speed = 0.05F;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, -speed, 0));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Did i hit it?");
        Destroy(gameObject);
    }
}
