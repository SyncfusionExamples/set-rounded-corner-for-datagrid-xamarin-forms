using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataGridXamarin
{
    #region OrderInfo
    public class OrderInfo : INotifyPropertyChanged
    {
        #region Fields
        private int orderID;
        private string customerID;
        private string customer;
        private string shipCity;
        private string shipCountry;
        #endregion

        #region Properties
        public int OrderID
        {
            get { return orderID; }
            set
            {
                this.orderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        public string CustomerID
        {
            get { return customerID; }
            set
            {
                this.customerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        public string ShipCountry
        {
            get { return shipCountry; }
            set
            {
                this.shipCountry = value;
                RaisePropertyChanged("ShipCountry");
            }
        }

        public string Customer
        {
            get { return this.customer; }
            set
            {
                this.customer = value;
                RaisePropertyChanged("Customer");
            }
        }

        public string ShipCity
        {
            get { return shipCity; }
            set
            {
                this.shipCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }
        #endregion

        #region Constructor
        public OrderInfo(int orderId, string customerId, string country, string customer, string shipCity)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Customer = customer;
            this.ShipCountry = country;
            this.ShipCity = shipCity;
        }
        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
    #endregion
}
