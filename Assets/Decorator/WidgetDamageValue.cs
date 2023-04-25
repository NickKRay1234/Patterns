using UnityEngine;
using UnityEngine.UI;

namespace Decorator
{
    public class WidgetDamageValue : MonoBehaviour
    {
        [SerializeField] private Text _textValue;

        public void SetValue(string newValue)
        {
            _textValue.text = newValue;
        }

        public void SetColor(Color color)
        {
            _textValue.color = color;
        }

        public void Handle_AnimationOver()
        {
            Destroy(gameObject);
        }
    }
}