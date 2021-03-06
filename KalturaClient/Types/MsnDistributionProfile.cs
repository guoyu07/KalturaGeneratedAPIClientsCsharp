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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class MsnDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string DOMAIN = "domain";
		public const string CS_ID = "csId";
		public const string SOURCE = "source";
		public const string SOURCE_FRIENDLY_NAME = "sourceFriendlyName";
		public const string PAGE_GROUP = "pageGroup";
		public const string SOURCE_FLAVOR_PARAMS_ID = "sourceFlavorParamsId";
		public const string WMV_FLAVOR_PARAMS_ID = "wmvFlavorParamsId";
		public const string FLV_FLAVOR_PARAMS_ID = "flvFlavorParamsId";
		public const string SL_FLAVOR_PARAMS_ID = "slFlavorParamsId";
		public const string SL_HD_FLAVOR_PARAMS_ID = "slHdFlavorParamsId";
		public const string MSNVIDEO_CAT = "msnvideoCat";
		public const string MSNVIDEO_TOP = "msnvideoTop";
		public const string MSNVIDEO_TOP_CAT = "msnvideoTopCat";
		#endregion

		#region Private Fields
		private string _Username = null;
		private string _Password = null;
		private string _Domain = null;
		private string _CsId = null;
		private string _Source = null;
		private string _SourceFriendlyName = null;
		private string _PageGroup = null;
		private int _SourceFlavorParamsId = Int32.MinValue;
		private int _WmvFlavorParamsId = Int32.MinValue;
		private int _FlvFlavorParamsId = Int32.MinValue;
		private int _SlFlavorParamsId = Int32.MinValue;
		private int _SlHdFlavorParamsId = Int32.MinValue;
		private string _MsnvideoCat = null;
		private string _MsnvideoTop = null;
		private string _MsnvideoTopCat = null;
		#endregion

		#region Properties
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		public string Domain
		{
			get { return _Domain; }
			set 
			{ 
				_Domain = value;
				OnPropertyChanged("Domain");
			}
		}
		public string CsId
		{
			get { return _CsId; }
			set 
			{ 
				_CsId = value;
				OnPropertyChanged("CsId");
			}
		}
		public string Source
		{
			get { return _Source; }
			set 
			{ 
				_Source = value;
				OnPropertyChanged("Source");
			}
		}
		public string SourceFriendlyName
		{
			get { return _SourceFriendlyName; }
			set 
			{ 
				_SourceFriendlyName = value;
				OnPropertyChanged("SourceFriendlyName");
			}
		}
		public string PageGroup
		{
			get { return _PageGroup; }
			set 
			{ 
				_PageGroup = value;
				OnPropertyChanged("PageGroup");
			}
		}
		public int SourceFlavorParamsId
		{
			get { return _SourceFlavorParamsId; }
			set 
			{ 
				_SourceFlavorParamsId = value;
				OnPropertyChanged("SourceFlavorParamsId");
			}
		}
		public int WmvFlavorParamsId
		{
			get { return _WmvFlavorParamsId; }
			set 
			{ 
				_WmvFlavorParamsId = value;
				OnPropertyChanged("WmvFlavorParamsId");
			}
		}
		public int FlvFlavorParamsId
		{
			get { return _FlvFlavorParamsId; }
			set 
			{ 
				_FlvFlavorParamsId = value;
				OnPropertyChanged("FlvFlavorParamsId");
			}
		}
		public int SlFlavorParamsId
		{
			get { return _SlFlavorParamsId; }
			set 
			{ 
				_SlFlavorParamsId = value;
				OnPropertyChanged("SlFlavorParamsId");
			}
		}
		public int SlHdFlavorParamsId
		{
			get { return _SlHdFlavorParamsId; }
			set 
			{ 
				_SlHdFlavorParamsId = value;
				OnPropertyChanged("SlHdFlavorParamsId");
			}
		}
		public string MsnvideoCat
		{
			get { return _MsnvideoCat; }
			set 
			{ 
				_MsnvideoCat = value;
				OnPropertyChanged("MsnvideoCat");
			}
		}
		public string MsnvideoTop
		{
			get { return _MsnvideoTop; }
			set 
			{ 
				_MsnvideoTop = value;
				OnPropertyChanged("MsnvideoTop");
			}
		}
		public string MsnvideoTopCat
		{
			get { return _MsnvideoTopCat; }
			set 
			{ 
				_MsnvideoTopCat = value;
				OnPropertyChanged("MsnvideoTopCat");
			}
		}
		#endregion

		#region CTor
		public MsnDistributionProfile()
		{
		}

		public MsnDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "username":
						this._Username = propertyNode.InnerText;
						continue;
					case "password":
						this._Password = propertyNode.InnerText;
						continue;
					case "domain":
						this._Domain = propertyNode.InnerText;
						continue;
					case "csId":
						this._CsId = propertyNode.InnerText;
						continue;
					case "source":
						this._Source = propertyNode.InnerText;
						continue;
					case "sourceFriendlyName":
						this._SourceFriendlyName = propertyNode.InnerText;
						continue;
					case "pageGroup":
						this._PageGroup = propertyNode.InnerText;
						continue;
					case "sourceFlavorParamsId":
						this._SourceFlavorParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "wmvFlavorParamsId":
						this._WmvFlavorParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "flvFlavorParamsId":
						this._FlvFlavorParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "slFlavorParamsId":
						this._SlFlavorParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "slHdFlavorParamsId":
						this._SlHdFlavorParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "msnvideoCat":
						this._MsnvideoCat = propertyNode.InnerText;
						continue;
					case "msnvideoTop":
						this._MsnvideoTop = propertyNode.InnerText;
						continue;
					case "msnvideoTopCat":
						this._MsnvideoTopCat = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaMsnDistributionProfile");
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("domain", this._Domain);
			kparams.AddIfNotNull("csId", this._CsId);
			kparams.AddIfNotNull("source", this._Source);
			kparams.AddIfNotNull("sourceFriendlyName", this._SourceFriendlyName);
			kparams.AddIfNotNull("pageGroup", this._PageGroup);
			kparams.AddIfNotNull("sourceFlavorParamsId", this._SourceFlavorParamsId);
			kparams.AddIfNotNull("wmvFlavorParamsId", this._WmvFlavorParamsId);
			kparams.AddIfNotNull("flvFlavorParamsId", this._FlvFlavorParamsId);
			kparams.AddIfNotNull("slFlavorParamsId", this._SlFlavorParamsId);
			kparams.AddIfNotNull("slHdFlavorParamsId", this._SlHdFlavorParamsId);
			kparams.AddIfNotNull("msnvideoCat", this._MsnvideoCat);
			kparams.AddIfNotNull("msnvideoTop", this._MsnvideoTop);
			kparams.AddIfNotNull("msnvideoTopCat", this._MsnvideoTopCat);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case DOMAIN:
					return "Domain";
				case CS_ID:
					return "CsId";
				case SOURCE:
					return "Source";
				case SOURCE_FRIENDLY_NAME:
					return "SourceFriendlyName";
				case PAGE_GROUP:
					return "PageGroup";
				case SOURCE_FLAVOR_PARAMS_ID:
					return "SourceFlavorParamsId";
				case WMV_FLAVOR_PARAMS_ID:
					return "WmvFlavorParamsId";
				case FLV_FLAVOR_PARAMS_ID:
					return "FlvFlavorParamsId";
				case SL_FLAVOR_PARAMS_ID:
					return "SlFlavorParamsId";
				case SL_HD_FLAVOR_PARAMS_ID:
					return "SlHdFlavorParamsId";
				case MSNVIDEO_CAT:
					return "MsnvideoCat";
				case MSNVIDEO_TOP:
					return "MsnvideoTop";
				case MSNVIDEO_TOP_CAT:
					return "MsnvideoTopCat";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

