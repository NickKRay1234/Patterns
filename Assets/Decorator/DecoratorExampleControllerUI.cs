using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Decorator
{
    public class DecoratorExampleControllerUI : MonoBehaviour
    {
        [SerializeField] private UnitExample _unit;
        [SerializeField] private Button _buttonDamage;
        [SerializeField] private WidgetDamageValue _widgetDamageValue;
        [SerializeField] private Transform _damageValuesContainer;


        private Dictionary<DamageType, Color> _damageColorMap = new Dictionary<DamageType, Color>
        {
            { DamageType.Physical, Color.white },
            { DamageType.Electrical, Color.yellow },
            { DamageType.Water, Color.blue }
        };

        private void OnEnable()
        {
            _buttonDamage.onClick.AddListener(OnButtonDamageClick);
        }

        private void OnDisable()
        {
            _buttonDamage.onClick.RemoveListener(OnButtonDamageClick);
        }

        public void CreateWidgetDamageValue(DamageType damageType, int damage)
        {
            var color = _damageColorMap[damageType];
            var widget = Instantiate(_widgetDamageValue, _damageValuesContainer);
            var _maxDistance = 0.5f;
            var randomOffset = Random.insideUnitCircle * _maxDistance;
            var position = _damageValuesContainer.position + new Vector3(randomOffset.x, randomOffset.y, 0f);
            widget.transform.position = position;
        
            widget.SetValue(damage.ToString());
            widget.SetColor(color);
            widget.Handle_AnimationOver();
        }

        private void OnButtonDamageClick()
        {
            Debug.Log("Damage");
            IAbility ability = new Ability(10, DamageType.Physical);
            ability.ApplyDamage(_unit);
        }
    }
}