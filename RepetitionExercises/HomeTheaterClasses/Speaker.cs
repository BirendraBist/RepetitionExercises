namespace RepetitionExercises
{
    // This class models speakers , which can turned up and down ,
    // and where we can increase and decrease the volume.
    public class Speaker
    {
        private const int MinVolume = 0;
        private const int MaxVolume = 100;

        private bool _isOn;
        private int _currentVolume;

        public Speaker()
        {
            _currentVolume = 0;
            _isOn = false;
        }

        public bool IsOn
        {
            get { return _isOn; }
        }

        public int CurrentVolume
        {
            get { return _currentVolume; }
        }

        // Shift between the turn up and turn down states.
        // when speakers turn down , the volume is set to 0.
        public void ToggleOnOff()
        {
            _isOn = !_isOn;

            if (!_isOn)
            {
                _currentVolume = 0;
            }
        }

        // Increase the volume for the speakers, unless we reach the maximum value
        public void IncreaseVolume()
        {
            if (_currentVolume < MaxVolume && IsOn)
            {
                _currentVolume++;
            }
        }

        // Decrease the volume for speakers, unless we reach the minimal volume
        public void DecreaseVolume()
        {
            if (_currentVolume > MinVolume && IsOn)
            {
                _currentVolume--;
            }
        } 
    }
}