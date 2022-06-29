using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    [SerializeField] private Guy _guyPrefab;
    [SerializeField] private SpriteRenderer _guyRenderer;
    [SerializeField] private float _timeToSpawn;
    [SerializeField] private Transform _route;

    private Transform[] _points;

   // private int gcount = 0;

    private float _timer;
    // Start is called before the first frame update
    void Start()
    {
        
        _points = new Transform[_route.childCount];
        for (int i = 0; i < _route.childCount; i++)
        {
            _points[i] = _route.GetChild(i);
        }
        _timer = _timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        _guyPrefab.SetColor(_guyRenderer.color);
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
        }

        if (_timer <= 0 /*&& gcount <= 3*/)
        {
            Guy gu = Instantiate(_guyPrefab, transform.position, Quaternion.identity);
            //gcount++;
            gu.Points = _points;
            _timer = _timeToSpawn;
        }
    }
}
