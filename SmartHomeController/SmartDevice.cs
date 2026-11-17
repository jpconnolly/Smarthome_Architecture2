using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    public class SmartDevice
    {
        // private fields
        private int deviceID;
        private string deviceName;
        private bool status;

        // public properties
        public int DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }

        public string DeviceName
        {
            get { return deviceName; }
            set { deviceName = value; }
        }

        public bool Status
        {
            get { return status; }
            set {  status = value; }
        }

        // Parameterised constructor
        public SmartDevice(int smartDeviceID, string smartDeviceName, bool smartDeviceStatus)
        {
            DeviceID = smartDeviceID;
            DeviceName = smartDeviceName;
            Status = smartDeviceStatus;
        }

        // Methods
        public void TurnOn()
        {

        }

        public void TurnOff()
        {

        }

        public virtual void GetStatus()
        {

        }
    }
}
