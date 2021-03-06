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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class DeviceFamilyBase : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string DEVICE_LIMIT = "deviceLimit";
		public const string CONCURRENT_LIMIT = "concurrentLimit";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _Name = null;
		private int _DeviceLimit = Int32.MinValue;
		private int _ConcurrentLimit = Int32.MinValue;
		#endregion

		#region Properties
		public long Id
		{
			get { return _Id; }
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public int DeviceLimit
		{
			get { return _DeviceLimit; }
			set 
			{ 
				_DeviceLimit = value;
				OnPropertyChanged("DeviceLimit");
			}
		}
		public int ConcurrentLimit
		{
			get { return _ConcurrentLimit; }
			set 
			{ 
				_ConcurrentLimit = value;
				OnPropertyChanged("ConcurrentLimit");
			}
		}
		#endregion

		#region CTor
		public DeviceFamilyBase()
		{
		}

		public DeviceFamilyBase(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseLong(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "deviceLimit":
						this._DeviceLimit = ParseInt(propertyNode.InnerText);
						continue;
					case "concurrentLimit":
						this._ConcurrentLimit = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeviceFamilyBase");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("deviceLimit", this._DeviceLimit);
			kparams.AddIfNotNull("concurrentLimit", this._ConcurrentLimit);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case NAME:
					return "Name";
				case DEVICE_LIMIT:
					return "DeviceLimit";
				case CONCURRENT_LIMIT:
					return "ConcurrentLimit";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

