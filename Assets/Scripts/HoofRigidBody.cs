using UnityEngine;

public class HoofRigidBody : MonoBehaviour
{
    [SerializeField]
    private Score _score;

    private Rigidbody _rigidbody;
    private int _hardness = 10;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name != "PuttyKnife")
        {
            return;
        }
        if (_hardness <= 0)
        {
            _rigidbody.useGravity = true;
        }
        else
        {
            _hardness--;
            _score.UpdateScore(1);
        }
    }
}