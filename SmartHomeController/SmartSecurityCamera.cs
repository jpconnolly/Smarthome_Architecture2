using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SmartHomeController
{
    internal class SmartSecurityCamera : SmartDevice
    {
        // private fields 
        private string resolutionStatus;
        private bool recordingStatus;


        // public properties
        public string ResolutionStatus
        {
            get { return ResolutionStatus; }
            set { ResolutionStatus = value; }
        }


        public bool RecordingStatus
        {
            get { return RecordingStatus; }
            set { RecordingStatus = value; }
        }


        // constructor
        public SmartSecurityCamera(
        
            bool RecordingStatus,
            int SmartDeviceID,
            string smartDeviceName,
            bool smartDeviceStatus) : base(SmartDeviceID, smartDeviceName, smartDeviceStatus)

        {
         
        }

        // Methods 

        public void StartRecording()
        {

        }

        public void StopRecording()
        {

        }

        public override void GetStatus()
        {

        }
    }
}
