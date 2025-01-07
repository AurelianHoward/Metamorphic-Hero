using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField]
    float rawDamage = 100f;
    [SerializeField]
    bool isPickupOnCollision = false;

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
            if (collider.tag == "Enemy")
            {
                collider.gameObject.GetComponent<EnemyHitManager>().Hit(rawDamage);
                Debug.Log("trap activated");
            }
        }
    }



}
