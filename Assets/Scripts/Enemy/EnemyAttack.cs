using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    float rawDamage = 5f;
    [SerializeField]
    bool isPickupOnCollision = false;

    float AttackReady = 1;

    // Start is called before the first frame update
    void Start()
    {

        if (isPickupOnCollision)
        {
            gameObject.GetComponent<Collider>().isTrigger = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider collider)
    {
        if (isPickupOnCollision)
        {
            if (collider.tag == "Player")
            {
                if (AttackReady > 11)
                {
                    AttackReady = 1;
                    collider.gameObject.GetComponent<PlayerStats>().Hit(rawDamage);
                    Debug.Log("Enemy Attacked");
                }
                else
                {
                    AttackReady += 1;
                }
            }
        }
    }
}
