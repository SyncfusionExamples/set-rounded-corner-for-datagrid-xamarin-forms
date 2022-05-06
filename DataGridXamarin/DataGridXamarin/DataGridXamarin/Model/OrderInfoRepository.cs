﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataGridXamarin
{
    #region OrderInfoRepository
    public class OrderInfoRepository
    {
        #region Fields
        private ObservableCollection<OrderInfo> orderInfo;
        #endregion

        #region Constructor
        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
        }
        #endregion

        #region Methods
        public ObservableCollection<OrderInfo> GenerateOrders()
        {
            orderInfo.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            orderInfo.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "México D.F."));
            orderInfo.Add(new OrderInfo(1003, "Ant Fuller", "Mexico", "ANTON", "México D.F."));
            orderInfo.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1005, "Tim Adams", "Sweden", "BERGS", "Luleå"));
            orderInfo.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(1007, "Andrew Fuller", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(1008, "Martin King", "Spain", "BOLID", "Madrid"));
            orderInfo.Add(new OrderInfo(1009, "Lenny Lin", "France", "BONAP", "Marseille"));
            orderInfo.Add(new OrderInfo(1010, "John Carter", "Canada", "BOTTM", "Tsawassen"));
            orderInfo.Add(new OrderInfo(1011, "Lauro King", "UK", "AROUT", "London"));
            orderInfo.Add(new OrderInfo(1012, "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
            orderInfo.Add(new OrderInfo(1013, "Alfki Kyle", "France", "BLONP", "Strasbourg"));
            orderInfo.Add(new OrderInfo(1014, "Gina Irene", "UK", "AROUT", "London"));

            return orderInfo;
        }
        #endregion
    }
    #endregion
}
