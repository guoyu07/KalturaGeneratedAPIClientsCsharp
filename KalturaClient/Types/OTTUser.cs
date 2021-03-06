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
	public class OTTUser : BaseOTTUser
	{
		#region Constants
		public const string HOUSEHOLD_ID = "householdId";
		public const string EMAIL = "email";
		public const string ADDRESS = "address";
		public const string CITY = "city";
		public const string COUNTRY = "country";
		public const string ZIP = "zip";
		public const string PHONE = "phone";
		public const string AFFILIATE_CODE = "affiliateCode";
		public const string EXTERNAL_ID = "externalId";
		public const string USER_TYPE = "userType";
		public const string DYNAMIC_DATA = "dynamicData";
		public const string IS_HOUSEHOLD_MASTER = "isHouseholdMaster";
		public const string SUSPENTION_STATE = "suspentionState";
		public const string USER_STATE = "userState";
		#endregion

		#region Private Fields
		private int _HouseholdId = Int32.MinValue;
		private string _Email = null;
		private string _Address = null;
		private string _City = null;
		private Country _Country;
		private string _Zip = null;
		private string _Phone = null;
		private string _AffiliateCode = null;
		private string _ExternalId = null;
		private OTTUserType _UserType;
		private IDictionary<string, StringValue> _DynamicData;
		private bool? _IsHouseholdMaster = null;
		private HouseholdSuspentionState _SuspentionState = null;
		private UserState _UserState = null;
		#endregion

		#region Properties
		public int HouseholdId
		{
			get { return _HouseholdId; }
		}
		public string Email
		{
			get { return _Email; }
			set 
			{ 
				_Email = value;
				OnPropertyChanged("Email");
			}
		}
		public string Address
		{
			get { return _Address; }
			set 
			{ 
				_Address = value;
				OnPropertyChanged("Address");
			}
		}
		public string City
		{
			get { return _City; }
			set 
			{ 
				_City = value;
				OnPropertyChanged("City");
			}
		}
		public Country Country
		{
			get { return _Country; }
			set 
			{ 
				_Country = value;
				OnPropertyChanged("Country");
			}
		}
		public string Zip
		{
			get { return _Zip; }
			set 
			{ 
				_Zip = value;
				OnPropertyChanged("Zip");
			}
		}
		public string Phone
		{
			get { return _Phone; }
			set 
			{ 
				_Phone = value;
				OnPropertyChanged("Phone");
			}
		}
		public string AffiliateCode
		{
			get { return _AffiliateCode; }
			set 
			{ 
				_AffiliateCode = value;
				OnPropertyChanged("AffiliateCode");
			}
		}
		public string ExternalId
		{
			get { return _ExternalId; }
			set 
			{ 
				_ExternalId = value;
				OnPropertyChanged("ExternalId");
			}
		}
		public OTTUserType UserType
		{
			get { return _UserType; }
			set 
			{ 
				_UserType = value;
				OnPropertyChanged("UserType");
			}
		}
		public IDictionary<string, StringValue> DynamicData
		{
			get { return _DynamicData; }
			set 
			{ 
				_DynamicData = value;
				OnPropertyChanged("DynamicData");
			}
		}
		public bool? IsHouseholdMaster
		{
			get { return _IsHouseholdMaster; }
		}
		public HouseholdSuspentionState SuspentionState
		{
			get { return _SuspentionState; }
		}
		public UserState UserState
		{
			get { return _UserState; }
		}
		#endregion

		#region CTor
		public OTTUser()
		{
		}

		public OTTUser(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "householdId":
						this._HouseholdId = ParseInt(propertyNode.InnerText);
						continue;
					case "email":
						this._Email = propertyNode.InnerText;
						continue;
					case "address":
						this._Address = propertyNode.InnerText;
						continue;
					case "city":
						this._City = propertyNode.InnerText;
						continue;
					case "country":
						this._Country = ObjectFactory.Create<Country>(propertyNode);
						continue;
					case "zip":
						this._Zip = propertyNode.InnerText;
						continue;
					case "phone":
						this._Phone = propertyNode.InnerText;
						continue;
					case "affiliateCode":
						this._AffiliateCode = propertyNode.InnerText;
						continue;
					case "externalId":
						this._ExternalId = propertyNode.InnerText;
						continue;
					case "userType":
						this._UserType = ObjectFactory.Create<OTTUserType>(propertyNode);
						continue;
					case "dynamicData":
						{
							string key;
							this._DynamicData = new Dictionary<string, StringValue>();
							foreach(XmlElement arrayNode in propertyNode.ChildNodes)
							{
								key = arrayNode["itemKey"].InnerText;;
								this._DynamicData[key] = ObjectFactory.Create<StringValue>(arrayNode);
							}
						}
						continue;
					case "isHouseholdMaster":
						this._IsHouseholdMaster = ParseBool(propertyNode.InnerText);
						continue;
					case "suspentionState":
						this._SuspentionState = (HouseholdSuspentionState)StringEnum.Parse(typeof(HouseholdSuspentionState), propertyNode.InnerText);
						continue;
					case "userState":
						this._UserState = (UserState)StringEnum.Parse(typeof(UserState), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaOTTUser");
			kparams.AddIfNotNull("householdId", this._HouseholdId);
			kparams.AddIfNotNull("email", this._Email);
			kparams.AddIfNotNull("address", this._Address);
			kparams.AddIfNotNull("city", this._City);
			kparams.AddIfNotNull("country", this._Country);
			kparams.AddIfNotNull("zip", this._Zip);
			kparams.AddIfNotNull("phone", this._Phone);
			kparams.AddIfNotNull("affiliateCode", this._AffiliateCode);
			kparams.AddIfNotNull("externalId", this._ExternalId);
			kparams.AddIfNotNull("userType", this._UserType);
			kparams.AddIfNotNull("dynamicData", this._DynamicData);
			kparams.AddIfNotNull("isHouseholdMaster", this._IsHouseholdMaster);
			kparams.AddIfNotNull("suspentionState", this._SuspentionState);
			kparams.AddIfNotNull("userState", this._UserState);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HOUSEHOLD_ID:
					return "HouseholdId";
				case EMAIL:
					return "Email";
				case ADDRESS:
					return "Address";
				case CITY:
					return "City";
				case COUNTRY:
					return "Country";
				case ZIP:
					return "Zip";
				case PHONE:
					return "Phone";
				case AFFILIATE_CODE:
					return "AffiliateCode";
				case EXTERNAL_ID:
					return "ExternalId";
				case USER_TYPE:
					return "UserType";
				case DYNAMIC_DATA:
					return "DynamicData";
				case IS_HOUSEHOLD_MASTER:
					return "IsHouseholdMaster";
				case SUSPENTION_STATE:
					return "SuspentionState";
				case USER_STATE:
					return "UserState";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

