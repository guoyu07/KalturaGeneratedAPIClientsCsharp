// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2017  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class HouseholdDeviceAddRequestBuilder : StandaloneRequestBuilder<HouseholdDevice>
	{
		#region Constants
		public const string DEVICE = "device";
		#endregion

		public HouseholdDevice Device
		{
			set;
			get;
		}

		public HouseholdDeviceAddRequestBuilder()
			: base("householddevice", "add")
		{
		}

		public HouseholdDeviceAddRequestBuilder(HouseholdDevice device)
			: this()
		{
			this.Device = device;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("device"))
				kparams.AddIfNotNull("device", Device);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<HouseholdDevice>(result);
		}
	}

	public class HouseholdDeviceAddByPinRequestBuilder : StandaloneRequestBuilder<HouseholdDevice>
	{
		#region Constants
		public const string DEVICE_NAME = "deviceName";
		public const string PIN = "pin";
		#endregion

		public string DeviceName
		{
			set;
			get;
		}
		public string Pin
		{
			set;
			get;
		}

		public HouseholdDeviceAddByPinRequestBuilder()
			: base("householddevice", "addByPin")
		{
		}

		public HouseholdDeviceAddByPinRequestBuilder(string deviceName, string pin)
			: this()
		{
			this.DeviceName = deviceName;
			this.Pin = pin;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("deviceName"))
				kparams.AddIfNotNull("deviceName", DeviceName);
			if (!isMapped("pin"))
				kparams.AddIfNotNull("pin", Pin);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<HouseholdDevice>(result);
		}
	}

	public class HouseholdDeviceDeleteRequestBuilder : StandaloneRequestBuilder<bool>
	{
		#region Constants
		public const string UDID = "udid";
		#endregion

		public string Udid
		{
			set;
			get;
		}

		public HouseholdDeviceDeleteRequestBuilder()
			: base("householddevice", "delete")
		{
		}

		public HouseholdDeviceDeleteRequestBuilder(string udid)
			: this()
		{
			this.Udid = udid;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class HouseholdDeviceGeneratePinRequestBuilder : StandaloneRequestBuilder<DevicePin>
	{
		#region Constants
		public const string UDID = "udid";
		public const string BRAND_ID = "brandId";
		#endregion

		public string Udid
		{
			set;
			get;
		}
		public int BrandId
		{
			set;
			get;
		}

		public HouseholdDeviceGeneratePinRequestBuilder()
			: base("householddevice", "generatePin")
		{
		}

		public HouseholdDeviceGeneratePinRequestBuilder(string udid, int brandId)
			: this()
		{
			this.Udid = udid;
			this.BrandId = brandId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			if (!isMapped("brandId"))
				kparams.AddIfNotNull("brandId", BrandId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DevicePin>(result);
		}
	}

	public class HouseholdDeviceGetRequestBuilder : StandaloneRequestBuilder<HouseholdDevice>
	{
		#region Constants
		#endregion


		public HouseholdDeviceGetRequestBuilder()
			: base("householddevice", "get")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<HouseholdDevice>(result);
		}
	}

	public class HouseholdDeviceUpdateRequestBuilder : StandaloneRequestBuilder<HouseholdDevice>
	{
		#region Constants
		public const string UDID = "udid";
		public const string DEVICE = "device";
		#endregion

		public string Udid
		{
			set;
			get;
		}
		public HouseholdDevice Device
		{
			set;
			get;
		}

		public HouseholdDeviceUpdateRequestBuilder()
			: base("householddevice", "update")
		{
		}

		public HouseholdDeviceUpdateRequestBuilder(string udid, HouseholdDevice device)
			: this()
		{
			this.Udid = udid;
			this.Device = device;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			if (!isMapped("device"))
				kparams.AddIfNotNull("device", Device);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<HouseholdDevice>(result);
		}
	}

	public class HouseholdDeviceUpdateStatusRequestBuilder : StandaloneRequestBuilder<bool>
	{
		#region Constants
		public const string UDID = "udid";
		public const string STATUS = "status";
		#endregion

		public string Udid
		{
			set;
			get;
		}
		public DeviceStatus Status
		{
			set;
			get;
		}

		public HouseholdDeviceUpdateStatusRequestBuilder()
			: base("householddevice", "updateStatus")
		{
		}

		public HouseholdDeviceUpdateStatusRequestBuilder(string udid, DeviceStatus status)
			: this()
		{
			this.Udid = udid;
			this.Status = status;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			if (!isMapped("status"))
				kparams.AddIfNotNull("status", Status);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}


	public class HouseholdDeviceService
	{
		private HouseholdDeviceService()
		{
		}

		public static HouseholdDeviceAddRequestBuilder Add(HouseholdDevice device)
		{
			return new HouseholdDeviceAddRequestBuilder(device);
		}

		public static HouseholdDeviceAddByPinRequestBuilder AddByPin(string deviceName, string pin)
		{
			return new HouseholdDeviceAddByPinRequestBuilder(deviceName, pin);
		}

		public static HouseholdDeviceDeleteRequestBuilder Delete(string udid)
		{
			return new HouseholdDeviceDeleteRequestBuilder(udid);
		}

		public static HouseholdDeviceGeneratePinRequestBuilder GeneratePin(string udid, int brandId)
		{
			return new HouseholdDeviceGeneratePinRequestBuilder(udid, brandId);
		}

		public static HouseholdDeviceGetRequestBuilder Get()
		{
			return new HouseholdDeviceGetRequestBuilder();
		}

		public static HouseholdDeviceUpdateRequestBuilder Update(string udid, HouseholdDevice device)
		{
			return new HouseholdDeviceUpdateRequestBuilder(udid, device);
		}

		public static HouseholdDeviceUpdateStatusRequestBuilder UpdateStatus(string udid, DeviceStatus status)
		{
			return new HouseholdDeviceUpdateStatusRequestBuilder(udid, status);
		}
	}
}
