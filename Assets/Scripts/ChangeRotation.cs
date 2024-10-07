using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_rotate * _speed * Time.deltaTime);
    }
}