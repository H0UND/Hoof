using UnityEngine;

public class HoofTrigger : MonoBehaviour
{
    [SerializeField]
    private Score _score;

    [SerializeField]
    private DirtParticle _dirtParticle;

    [SerializeField]
    private Material _material;

    private float _hardness = 50;
    private float _hardnessInt = 50;
    private float _transparent = 1f;

    private void OnTriggerStay(Collider other)
    {
        if (other.name != "PuttyKnife")
        {
            return;
        }

        if (_hardness > 0)
        {
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                var t = Time.deltaTime;
                _hardness -= t;
                _transparent -= 0.01f * t;
                _material.color = new Color(1f, 1f, 1f, _transparent);
                _dirtParticle.StartParticles();
                UpdateScore();
            }
        }
    }

    private void UpdateScore()
    {
        if (_hardnessInt != (int)_hardness)
        {
            _score.UpdateScore(1);
            _hardnessInt = (int)_hardness;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _dirtParticle.StopParticles();
    }

    private void OnDestroy()
    {
        _material.color = Color.white;
    }
}