namespace ParkingManager
{
    public class Car
    {
        private string _ownerName;

        public Car(string name)
        {
            _ownerName = name;
        }

        public string OwnerName
        {
            get { return _ownerName; }
        }
    }
}