using UnityEngine;

public class PlayerAttack1 : MonoBehaviour
{
    [SerializeField] GameObject FirebreathParticals;

    [SerializeField] GameObject FireBreathContainer;

    public bool BreathActive = false;

    [SerializeField] GameObject Sword;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Firebreath();
        Attack();
    }



    void Firebreath()
    {
        while (Input.GetKeyDown("space") & FireBreathContainer == isActiveAndEnabled)
        {
            FirebreathParticals.SetActive(true);

        }
        //FirebreathParticals.SetActive(false);
    }
    
    void Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SoundManager.instance.PlayAtSource("Sword", gameObject);
            Sword.SetActive(true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            Sword.SetActive(false) ;
        }

    }




}
