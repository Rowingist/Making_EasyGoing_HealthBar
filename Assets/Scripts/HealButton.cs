using UnityEngine;

public class HealButton : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private int _healPower = 10;

    public void OnButtonClick()
    {
        _healthBar.TakeHeal(_healPower);
    }
}
