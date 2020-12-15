using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private int _damage = 10;

    public void OnButtonClick()
    {
        _healthBar.TakeDamage(_damage);
    }
}
