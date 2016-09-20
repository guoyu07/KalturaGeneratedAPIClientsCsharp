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
// Copyright (C) 2006-2016  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaCEError : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private int _PartnerId = Int32.MinValue;
		private string _Browser = null;
		private string _ServerIp = null;
		private string _ServerOs = null;
		private string _PhpVersion = null;
		private string _CeAdminEmail = null;
		private string _Type = null;
		private string _Description = null;
		private string _Data = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string Browser
		{
			get { return _Browser; }
			set 
			{ 
				_Browser = value;
				OnPropertyChanged("Browser");
			}
		}
		public string ServerIp
		{
			get { return _ServerIp; }
			set 
			{ 
				_ServerIp = value;
				OnPropertyChanged("ServerIp");
			}
		}
		public string ServerOs
		{
			get { return _ServerOs; }
			set 
			{ 
				_ServerOs = value;
				OnPropertyChanged("ServerOs");
			}
		}
		public string PhpVersion
		{
			get { return _PhpVersion; }
			set 
			{ 
				_PhpVersion = value;
				OnPropertyChanged("PhpVersion");
			}
		}
		public string CeAdminEmail
		{
			get { return _CeAdminEmail; }
			set 
			{ 
				_CeAdminEmail = value;
				OnPropertyChanged("CeAdminEmail");
			}
		}
		public string Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		#endregion

		#region CTor
		public KalturaCEError()
		{
		}

		public KalturaCEError(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "browser":
						this._Browser = txt;
						continue;
					case "serverIp":
						this._ServerIp = txt;
						continue;
					case "serverOs":
						this._ServerOs = txt;
						continue;
					case "phpVersion":
						this._PhpVersion = txt;
						continue;
					case "ceAdminEmail":
						this._CeAdminEmail = txt;
						continue;
					case "type":
						this._Type = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "data":
						this._Data = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCEError");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("browser", this.Browser);
			kparams.AddIfNotNull("serverIp", this.ServerIp);
			kparams.AddIfNotNull("serverOs", this.ServerOs);
			kparams.AddIfNotNull("phpVersion", this.PhpVersion);
			kparams.AddIfNotNull("ceAdminEmail", this.CeAdminEmail);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("data", this.Data);
			return kparams;
		}
		#endregion
	}
}

