namespace RepetitionExercises
{
    // This class models a very simple Blu-Ray player,
    // which can turn on and turn down and each player can starte and stop
    // og stoppes
    public class BluRayPlayer
    {
        private bool _isOn;
        private bool _isPlaying;

        public BluRayPlayer()
        {
            _isOn = false;
            _isPlaying = false;
        }

        public bool IsOn
        {
            get { return _isOn; }
        }

        public bool IsPlaying
        {
            get { return _isPlaying; }
        }

        
        // Shift between the "Turn On" and the "Turn off" states for the system.
        // You do it by performing this operation on all devices of the system.

        public void ToggleOnOff()
        {
            _isOn = !_isOn;

            if (!_isOn)
            {
                Stop();
            }
        }

        // Start playing. can take place only if player is turned On .
        public void Play()
        {
            if (IsOn)
            {
                _isPlaying = true;
            }
        }

        // Stop playing
        public void Stop()
        {
            _isPlaying = false;
        }
    }
}