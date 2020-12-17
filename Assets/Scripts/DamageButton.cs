using UnityEngine;

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Player _player;

    private int _damage = 10;

    public void OnButtonClick()
    {
        _player.TakeDamage(_damage);
    }
}
