using UnityEngine;

public class TankHealth : MonoBehaviour
{
    public enum TankType
    {
        Player,
        Mob
    }

    [Header("Tank Type")]
    public TankType tankType = TankType.Mob;

    [Header("Health")]
    public int maxHP = 3;

    [Header("Effect")]
    public GameObject tankExplosionPrefab;
    public float explosionLifeTime = 3f;

    [Header("Audio")]
    public AudioClip tankExplosionClip;
    public float tankExplosionVolume = 1f;

    private int currentHP;
    private bool isDead = false;

    private void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHP -= damage;

        Debug.Log(gameObject.name + " HP: " + currentHP);

        if (currentHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;

        isDead = true;

        if (tankExplosionClip != null)
        {
            AudioSource.PlayClipAtPoint(tankExplosionClip, transform.position, tankExplosionVolume);
        }

        CreateTankExplosion();

        if (tankType == TankType.Player)
        {
            Debug.Log("Player »ç¸Á");

            if (GameManager.Instance != null)
            {
                GameManager.Instance.PlayerDead();
            }

            gameObject.SetActive(false);
        }
        else if (tankType == TankType.Mob)
        {
            Debug.Log("Mob »ç¸Á - Kill Count Áõ°¡");

            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddKill();
            }

            Destroy(gameObject);
        }
    }

    private void CreateTankExplosion()
    {
        if (tankExplosionPrefab == null) return;

        GameObject effect = Instantiate(
            tankExplosionPrefab,
            transform.position,
            Quaternion.identity
        );

        Destroy(effect, explosionLifeTime);
    }
}