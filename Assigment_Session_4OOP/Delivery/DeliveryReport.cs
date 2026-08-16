using Assigment_Session_4OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_Session_4OOP.Delivery
{
    internal class DeliveryReport
    {
        void PrintShipment(ITrackable shipment)
        {
            shipment.GetTrackingStatus();
        }
        void PrintInsurance(IInsurable shipment)
        {
            shipment.CalculateInsurance();
        }
    }
}
