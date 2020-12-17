using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _image;
    [SerializeField] private Player _player;

    private Slider _slider;

    private void OnEnable()
    {
        _player.HealthChanged += ChangeSliderValue;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= ChangeSliderValue;
    }

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _player.Health;
        _slider.value = _player.Health;
        _image.color = _gradient.Evaluate(1f);
    }

    public void ChangeSliderValue(int changedValue)
    {
        _slider.DOValue(changedValue, 0.3f).SetEase(Ease.Linear);

        _image.color = _gradient.Evaluate(_slider.normalizedValue);
    }
}
