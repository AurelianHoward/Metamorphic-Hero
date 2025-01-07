using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public float PlayerMaxHealth = 100f;
    float playerCurrentHealth;

    [SerializeField] string Menu = "Menu";


    public Slider HealthSlider;

    void Start()
    {
        playerCurrentHealth = PlayerMaxHealth;
    }

    private void Update()
    {
        if (playerCurrentHealth > PlayerMaxHealth)
        {
            playerCurrentHealth = PlayerMaxHealth;
        }
    }
    public void Hit(float rawDamage)
    {
        playerCurrentHealth -= rawDamage;
        SetHealthSlider();


        if (playerCurrentHealth <= 0)
        {
            OnDeath();
        }
    }

    void SetHealthSlider()
    {
        if (HealthSlider != null)
        {
            HealthSlider.value = NormalisedHitPoints();
        }
    }

    float NormalisedHitPoints()
    {
        return playerCurrentHealth / PlayerMaxHealth;
    }
    public void Heal(float rawDamage)
    {
        playerCurrentHealth += rawDamage;
        SetHealthSlider();

        Debug.Log("Yay: " + playerCurrentHealth.ToString());

        if (playerCurrentHealth <= 0)
        {
            Debug.Log("TODO: GAME OVER - YOU DIED/1");
        }
    }
    void OnDeath()
    {
        Cursor.visible = true;
        Debug.Log("TODO: GAME OVER - YOU DIED");
        SceneManager.LoadScene(Menu);
    }
}
