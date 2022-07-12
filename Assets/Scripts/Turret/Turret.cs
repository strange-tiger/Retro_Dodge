using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;
    public Transform Muzzle;
    public float TimeRange = 1.0f;
    public float AimRange = 15f;
    public float RotationSpeed = 0.2f;

    private Vector3 _distance;
    private float _disMag;
    private float _elapsedTime;
    // Update is called once per frame
    void Update()
    {
        _distance = transform.position - Player.transform.position;
        _disMag = _distance.magnitude;
        if (_disMag >= AimRange)
        {
            transform.Rotate(Vector3.up * RotationSpeed);
        }
        else
        {
            transform.LookAt(Player);
            Muzzle = transform;

            _elapsedTime += Time.deltaTime;
            if (_elapsedTime >= TimeRange)
            {
                _elapsedTime = 0f;

                GameObject bullet = Instantiate(BulletPrefab, Muzzle.position, Muzzle.rotation);
            }
        }
    }
}
