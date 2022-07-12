using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;

    //public float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private float _elapsedTime;
    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if( _elapsedTime >= Random.Range(1.0f, 2.0f))
        {
            _elapsedTime = 0f;

            GameObject bullet = Instantiate(BulletPrefab, transform);
            bullet.transform.LookAt(Player);
        }
    }
}
