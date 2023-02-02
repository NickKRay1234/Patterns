using TMPro;

namespace Strategy
{
    public class SleepBehaviour : ISleep
    {
        private TextMeshProUGUI _text;
        public SleepBehaviour(TextMeshProUGUI text)
        {
            _text = text;
        }
        
        public void Sleep()
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