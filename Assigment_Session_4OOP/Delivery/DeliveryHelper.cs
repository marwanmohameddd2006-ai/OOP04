using Assigment_Session_4OOP.Shipment__child;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_Session_4OOP.Delivery
{
    internal class DeliveryHelper
    {
        public string PrintShipmentDetails(Shipment shipment)
        {
            return shipment.PrintShipment();
        }
    }
}
