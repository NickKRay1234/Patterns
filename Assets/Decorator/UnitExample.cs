using UnityEngine;

namespace Decorator
{
    public class UnitExample : MonoBehaviour, ICanBeDamaged
    {
        [SerializeField] private DecoratorExampleControllerUI _controller;
        public void TakeDamage(DamageType Type, int damage)
        {
            _controller.CreateWidgetDamageValue(Type, damage);
            Debug.Log($"Damage received. Type: {Type}, damage: {damage}");
        }
    }
}