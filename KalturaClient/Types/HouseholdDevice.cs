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
	public class HouseholdDevice : ObjectBase
	{
		#region Constants
		public const string HOUSEHOLD_ID = "householdId";
		public const string UDID = "udid";
		public const string NAME = "name";
		public const string BRAND = "brand";
		public const string BRAND_ID = "brandId";
		public const string ACTIVATED_ON = "activatedOn";
		public const string STATUS = "status";
		#endregion

		#region Private Fields
		private int _HouseholdId = Int32.MinValue;
		private string _Udid = null;
		private string _Name = null;
		private string _Brand = null;
		private int _BrandId = Int32.MinValue;
		private long _ActivatedOn = long.MinValue;
		private DeviceStatus _Status = null;
		#endregion

		#region Properties
		public int HouseholdId
		{
			get { return _HouseholdId; }
			set 
			{ 
				_HouseholdId = value;
				OnPropertyChanged("HouseholdId");
			}
		}
		public string Udid
		{
			get { return _Udid; }
			set 
			{ 
				_Udid = value;
				OnPropertyChanged("Udid");
			}
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
		public string Brand
		{
			get { return _Brand; }
			set 
			{ 
				_Brand = value;
				OnPropertyChanged("Brand");
			}
		}
		public int BrandId
		{
			get { return _BrandId; }
			set 
			{ 
				_BrandId = value;
				OnPropertyChanged("BrandId");
			}
		}
		public long ActivatedOn
		{
			get { return _ActivatedOn; }
			set 
			{ 
				_ActivatedOn = value;
				OnPropertyChanged("ActivatedOn");
			}
		}
		public DeviceStatus Status
		{
			get { return _Status; }
		}
		#endregion

		#region CTor
		public HouseholdDevice()
		{
		}

		public HouseholdDevice(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "householdId":
						this._HouseholdId = ParseInt(propertyNode.InnerText);
						continue;
					case "udid":
						this._Udid = propertyNode.InnerText;
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "brand":
						this._Brand = propertyNode.InnerText;
						continue;
					case "brandId":
						this._BrandId = ParseInt(propertyNode.InnerText);
						continue;
					case "activatedOn":
						this._ActivatedOn = ParseLong(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (DeviceStatus)StringEnum.Parse(typeof(DeviceStatus), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaHouseholdDevice");
			kparams.AddIfNotNull("householdId", this._HouseholdId);
			kparams.AddIfNotNull("udid", this._Udid);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("brand", this._Brand);
			kparams.AddIfNotNull("brandId", this._BrandId);
			kparams.AddIfNotNull("activatedOn", this._ActivatedOn);
			kparams.AddIfNotNull("status", this._Status);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HOUSEHOLD_ID:
					return "HouseholdId";
				case UDID:
					return "Udid";
				case NAME:
					return "Name";
				case BRAND:
					return "Brand";
				case BRAND_ID:
					return "BrandId";
				case ACTIVATED_ON:
					return "ActivatedOn";
				case STATUS:
					return "Status";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

