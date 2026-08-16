using Assigment_Session_4OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_Session_4OOP.Shipment__child
{
    internal class StandardShipment:Shipment, IInsurable, ITrackable
    {
        public StandardShipment(string? TC, string? Des, double Wg, decimal DelF) : base(TC, Des, Wg, DelF)
        { }

        public override string PrintShipment()
        {
            return $"StandardShipment\n\nTrackingCode: {TrackingCode}  \nDes: {Description}  \nWeight: {Weight}kg  \nDeliveryFee: {DeliveryFee} EG \nEstimatedCost: {EstimatedCost}";

        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready";
        }

        public decimal CalculateInsurance()
        {
            return 0.05m * EstimatedCost;
        }

        public override decimal EstimatedCost => (DeliveryFee + ((decimal)Weight * 5));

    }
}
