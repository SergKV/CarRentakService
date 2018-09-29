using Core.Common.Core;

namespace CarRental.Client.Entities
{
    public class Car : TempObjectBase
    {
        int carId;
        string description;
        string color;
        int year;
        decimal rentalPrice;
        bool currentlyRented;

        public int CarId
        {
            get
            {
                return carId;
            }
            set
            {
                if (carId != value)
                {
                    carId = value;
                    // OnPropertyChanged("CarId");
                    OnPropertyChanged(() => CarId);
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description != null)
                {
                    description = value;
                    OnPropertyChanged("description");
                }
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (color != null)
                {
                    color = value;
                    OnPropertyChanged("color");
                }
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (year != 0)
                {
                    year = value;
                    OnPropertyChanged("year");
                }
            }
        }

        public decimal RentalPrice
        {
            get
            {
                return rentalPrice;
            }
            set
            {
                if (rentalPrice != 0)
                {
                    rentalPrice = value;
                    OnPropertyChanged("rentalPrice");
                }
            }
        }

        public bool CurrentlyRented
        {
            get
            {
                return currentlyRented;
            }
            set
            {
                currentlyRented = value;
            }
        }
    }
}
