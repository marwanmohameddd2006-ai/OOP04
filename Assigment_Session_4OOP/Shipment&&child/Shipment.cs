using Assigment_Session_4OOP.Delivery;
using Assigment_Session_4OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_Session_4OOP.Shipment__child
{
    internal abstract class Shipment
    {
        #region Attrbiutes
        private string? trackingcode;
        private string? description;
        private double weight;
        private decimal deliveryfee;
        private DeliveryAddress destination;
        #endregion

        #region Properties
        public string? TrackingCode
        {
            get
            {
                return trackingcode;
            }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingcode = value;
            }
        }

        public string? Description
        {
            get { return description; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                    weight = value;


            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryfee; }

            private set
            {
                if (value > 0)
                    deliveryfee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public abstract decimal EstimatedCost { get; }

        #endregion

        #region Constructor
        public Shipment(string? TC)
        {
            TrackingCode = TC;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Zag", "ELgalla", 27);
        }
        public Shipment(string? TC, string? Des, double Wg, decimal DelF)
        {
            TrackingCode = TC;
            Description = Des;
            Weight = Wg;
            DeliveryFee = DelF;
            //Destination = Dest;
        }

        #endregion

        #region Method
        public override string ToString()
        {
            return $"{TrackingCode}";
        }
        public abstract string PrintShipment(); //Print Shipment


        public void UpdateDeliveryFee(decimal fee)
        {
            DeliveryFee = fee;
        }
        public void Settracking(string track)
        {
            TrackingCode = track;
        }

        public void weight_update(double WG)
        {
            Weight += WG;
        }
        public void weight_update(double extraPcking, bool i)
        {
            if (i)
                Weight += (extraPcking);


        }

        #endregion
    }
}
