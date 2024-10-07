using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(_movementDirection * _speed * Time.deltaTime);
    }
}