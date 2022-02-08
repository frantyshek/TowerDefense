using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    [SerializeField] int damage = 1;
    [SerializeField] ParticleSystem part;
    List<ParticleCollisionEvent> colEvents = new List<ParticleCollisionEvent>();
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        
    }
    
    void OnParticleCollision(GameObject other)
    {
        int numColEvents = part.GetCollisionEvents(other, colEvents);

        if(other.TryGetComponent(out EnemyHP health))
        {
            health.TakeDamage(damage);
        }   
    }

}
