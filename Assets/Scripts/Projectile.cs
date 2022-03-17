using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public LayerMask collision;
    float speed = 10;

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
    void Start()
    {
        Object.Destroy(gameObject, 2.0f);
    }
    // Update is called once per frame
    void Update()
    {
        float moveDistance = speed * Time.deltaTime;
        CheckCollisions (moveDistance);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    void CheckCollisions(float moveDistance)
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray,out hit, moveDistance, collision, QueryTriggerInteraction.Collide))
        {
            OnHitObject(hit);
        }
    }
    void OnHitObject(RaycastHit hit)
    {
        GameObject.Destroy(gameObject);
    }
}
