using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public event UnityAction<int> HealthChanged;

    public int Health { get => _health; private set => _health = value;}

    public void TakeDamage(int damage)
    {
        Health -= damage;
        HealthChanged.Invoke(Health);
    }

    public void TakeHeal(int heal)
    {
        Health += heal;
        HealthChanged.Invoke(Health);
    }
}
