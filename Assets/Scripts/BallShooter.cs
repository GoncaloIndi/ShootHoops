using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    private MeshRenderer ballMesh;
    [SerializeField] private bool canShoot = true;
    [SerializeField] private float shootForce = 10;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform ball;

    private void Awake()
    {
        ballMesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && canShoot)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        
        ballMesh.enabled = false;
        canShoot = false;
        StartCoroutine(ResetBall()); 
        GameObject currentBall = Instantiate(ballPrefab, ball.position, ball.rotation);
        var rb = currentBall.GetComponent<Rigidbody>();
        Vector3 vec = ball.forward + (Vector3.up * .5f);
        rb.AddForce(vec * shootForce, ForceMode.Impulse);

    }

    private IEnumerator ResetBall()
    {
        yield return new WaitForSeconds(1);
        canShoot = true;
        ballMesh.enabled = true;
    }
}
