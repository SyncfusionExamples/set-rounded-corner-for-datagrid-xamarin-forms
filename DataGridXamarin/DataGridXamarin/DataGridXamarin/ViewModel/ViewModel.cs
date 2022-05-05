using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DataGridXamarin
{
    #region ViewModel
    public class ViewModel : INotifyPropertyChanged
    {
        #region Fields
        private OrderInfoRepository orderRepository;
        private ObservableCollection<OrderInfo> ordersInfo;

        #endregion

        #region Constructor
        public ViewModel()
        {
            orderRepository = new OrderInfoRepository();
            GenerateRows();
        }
        #endregion

        #region Properties
        public ObservableCollection<OrderInfo> OrdersInfo
        {
            get { return ordersInfo; }
            set
            {
                ordersInfo = value;
                RaisePropertyChanged("OrdersInfo");
            }
        }
        #endregion

        #region Private method
        private void GenerateRows()
        {
            ordersInfo = orderRepository.GenerateOrders();
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
