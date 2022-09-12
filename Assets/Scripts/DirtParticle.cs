using UnityEngine;

public class DirtParticle : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem _particle1;

    [SerializeField]
    private ParticleSystem _particle2;

    public void StartParticles()
    {
        if (!_particle1.isPlaying)
        {
            _particle1.Play();
        }
        if (!_particle2.isPlaying)
        {
            _particle2.Play();
        }
    }

    public void StopParticles()
    {
        if (_particle1.isPlaying)
        {
            _particle1.Stop();
        }
        if (_particle2.isPlaying)
        {
            _particle2.Stop();
        }
    }
}