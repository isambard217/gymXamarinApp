using System;



namespace WeActiveApp.Models {
    
    public class Device {

		public string DeviceId { get; set; }
		public string Manufacturer { get; set; }
		public string Model { get; set; }
		public string Platform { get; set; }
		public string PlatformVersion { get; set; }
		public string AppVersion { get; set; }

		public Device() {

            /*
			DeviceId = DeviceInfo.DeviceInfo.Hardware.DeviceId;
			Manufacturer = DeviceInfo.Hardware.Manufacturer;
			Model = DeviceInfo.Hardware.Model;
			Platform = DeviceInfo.Hardware.OS.ToString();
			PlatformVersion = DeviceInfo.Hardware.OperatingSystem;
			AppVersion = DeviceInfo.App.Version;
			*/
		}


    
    }
}
