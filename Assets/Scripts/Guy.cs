using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] Rigidbody2D _rigidbody2D;
    [SerializeField] private SpriteRenderer _renderer;
    public Transform[] Points;

    private int _index;
    private Transform _currentPoint;
    private bool _collision;

    private readonly RaycastHit2D[] _results = new RaycastHit2D[16];

    public void SetColor (Color color)
    {
        if (color != null)
           _renderer.color = color;
    }

    // Start is called before the first frame update
    void Start()
    {
        _index = 0;
        _collision = false; 
        _currentPoint = Points[_index];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(gameObject.name);
        Debug.Log(collision.gameObject.name);
        _collision = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _collision = false;
        Debug.Log("Exit " + gameObject.name);
        Debug.Log("Exit " + collision.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 direction = _currentPoint.position - transform.position;
        //Debug.DrawRay(transform.position, direction * 10, Color.red);

        //var collisionCount = _rigidbody2D.Cast(direction, _results, 7);
       // Debug.Log(collisionCount);

        if (!_collision)
        {
            transform.position = Vector3.MoveTowards(transform.position, _currentPoint.position, _speed * Time.deltaTime);

            if (transform.position == _currentPoint.position)
            {
                _index++;
                if (_index >= Points.Length)
                {
                    // Destroy(gameObject);
                }
                else
                {
                    _currentPoint = Points[_index];
                }
            }
        }            
    }
}
