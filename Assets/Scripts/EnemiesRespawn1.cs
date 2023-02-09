using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesRespawn1 : MonoBehaviour
{
    private float _initialYPosition = 15f;
    private float _respawnTime;
    
    void Start()
    {
    _respawnTime = Random.Range(1, 3);
    }
    
    void Update()
    {
    _respawnTime -= Time.deltaTime;
    if (_respawnTime < 0)
        Respawn();
    }
    
    private void Respawn()
    {
    var XPosition = Random.Range(-12, 12);
    Instantiate(Resources.Load("Enemy"), new Vector3(XPosition, _initialYPosition, 0), Quaternion.identity);
    _respawnTime = Random.Range(1, 3);
    }
}
