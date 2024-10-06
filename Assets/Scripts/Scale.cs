using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale += _scale * _speed * Time.deltaTime;
    }
}