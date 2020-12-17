using UnityEngine;

public class HealButton : MonoBehaviour
{
    [SerializeField] private Player _player;

    private int _healPower = 10;

    public void OnButtonClick()
    {
        _player.TakeHeal(_healPower);
    }
}
