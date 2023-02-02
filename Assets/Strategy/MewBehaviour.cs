using TMPro;

namespace Strategy
{
    public class MewBehaviour : ISpeak
    {
        private TextMeshProUGUI _text;
        public MewBehaviour(TextMeshProUGUI text)
        {
            _text = text;
        }
        
        public void Speak()
        {
            ShowSpeak(_text, "Mew! Mew! Mew!");
        }

        private void ShowSpeak(TextMeshProUGUI text, string message)
        {
            _text.gameObject.SetActive(true);
            text.text = message;
        }
    }
}