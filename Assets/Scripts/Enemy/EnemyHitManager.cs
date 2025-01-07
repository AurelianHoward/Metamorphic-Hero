using UnityEngine;
using static SoundManager;

public class EnemyHitManager : MonoBehaviour
{
    [SerializeField]
    float hitPoints = 30;

    public void Hit(float rawDamage)
    {
        hitPoints -= rawDamage;

        Debug.Log("OUCH: " + hitPoints.ToString());

        if (hitPoints <= 0)
        {
            OnDeath();
        }
    }

    void OnDeath()
    {
        SoundManager.instance.PlayAtSource("EnemyDeath", gameObject);
        Destroy(gameObject);
    }
}
