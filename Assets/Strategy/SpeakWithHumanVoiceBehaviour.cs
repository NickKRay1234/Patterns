using TMPro;

namespace Strategy
{
    public class SpeakWithHumanVoiceBehaviour : ISpeak
    {
        private TextMeshProUGUI _text;
        public SpeakWithHumanVoiceBehaviour(TextMeshProUGUI text)
        {
            _text = text;
        }
        
        public void Speak()
        {
            ShowSpeak(_text, "Hello! I speak English.");
        }

        private void ShowSpeak(TextMeshProUGUI text, string message)
        {
            _text.gameObject.SetActive(true);
            text.text = message;
        }
    }
}
