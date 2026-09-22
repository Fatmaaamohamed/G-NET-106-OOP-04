using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_106_OOP_04
{
    internal class StandardShipment: Shipment , ITrackable , IInsurable
    {
        
        public StandardShipment(string trackingCode)
            : base(trackingCode)
        {
        }

        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {


        }

        #region Question03

        public override decimal EstimatedCost => DeliveryFee;

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination   : {Destination?.GetFullAddress()}");
        }

        #endregion

        #region Question04
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }
        #endregion


        #region Question05
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
        #endregion
    }
}
