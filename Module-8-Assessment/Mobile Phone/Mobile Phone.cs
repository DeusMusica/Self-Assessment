namespace Mobile_Phone
{
    class Mobile_Phone
    {
        private string _model;
        private string _manufacturer;
        private string _price;
        private string _owner;
        private string _batteryModel;
        private string _idleTime;
        private string _hoursTalked;
        private string _screenSize;
        private string _screenColor;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        public string BatteryModel
        {
            get { return _batteryModel; }
            set { _batteryModel = value; }
        }

        public string IdleTime
        {
            get { return _idleTime; }
            set { _idleTime = value; }
        }
        public string HoursTalked
        {
            get { return _hoursTalked; }
            set { _hoursTalked = value; }
        }
        public string ScreenSize
        {
            get { return _screenSize; }
            set { _screenSize = value; }
        }
        public string ScreenColor
        {
            get { return _screenColor; }
            set { _screenColor = value; }
        }
    }
}
