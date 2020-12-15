using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private int _maxHealthValue;
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _image;

    private Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _maxHealthValue;
        _slider.value = _maxHealthValue;
        _image.color = _gradient.Evaluate(1f);
    }

    public void TakeHeal(int healValue)
    {
        ChangeSliderValue(healValue);
    }

    public void TakeDamage(int damageValue)
    {
        ChangeSliderValue(-damageValue);
    }

    private void ChangeSliderValue(int changingValue)
    {
        _slider.DOValue(_slider.value + changingValue, 0.3f).SetEase(Ease.Linear);

        _image.color = _gradient.Evaluate(_slider.normalizedValue);
    }
}
