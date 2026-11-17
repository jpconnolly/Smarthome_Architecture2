using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat : SmartDevice
    {
        // private fields
        private double currentTemperature;
        private double targetTemperature;

        // public properties
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }

        public double TargetTemperature
        {
            get { return targetTemperature; }
            set { targetTemperature = value; }
        }
        // constructor

        public SmartThermostat(int smartDeviceID,
            string smartDeviceName,
            bool smartDeviceStatus,
            double currentTemperature,
            double targetTemperature) : base(smartDeviceID, smartDeviceName, smartDeviceStatus)
        {
        
        }
         
        public void SetTemperature()
        {

        }

        public void SetCurrentTemperature()
        {

        }

        public override void GetStatus()
        {

        }

    }
}
