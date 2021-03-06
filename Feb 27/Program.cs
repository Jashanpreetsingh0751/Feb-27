﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb_27
{
    class Program
    {
        static void Main(string[] args)
        {
             private readonly ShippingCalculator _shippingCalculator;
        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }
        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1);


        }
        }
    }


