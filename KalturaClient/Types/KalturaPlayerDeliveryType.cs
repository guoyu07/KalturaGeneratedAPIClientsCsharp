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
	public class KalturaPlayerDeliveryType : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private string _Label = null;
		private IList<KalturaKeyValue> _Flashvars;
		private string _MinVersion = null;
		private bool? _EnabledByDefault = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		public new IList<KalturaKeyValue> Flashvars
		{
			get { return _Flashvars; }
			set 
			{ 
				_Flashvars = value;
				OnPropertyChanged("Flashvars");
			}
		}
		public string MinVersion
		{
			get { return _MinVersion; }
			set 
			{ 
				_MinVersion = value;
				OnPropertyChanged("MinVersion");
			}
		}
		public bool? EnabledByDefault
		{
			get { return _EnabledByDefault; }
			set 
			{ 
				_EnabledByDefault = value;
				OnPropertyChanged("EnabledByDefault");
			}
		}
		#endregion

		#region CTor
		public KalturaPlayerDeliveryType()
		{
		}

		public KalturaPlayerDeliveryType(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = txt;
						continue;
					case "label":
						this._Label = txt;
						continue;
					case "flashvars":
						this._Flashvars = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Flashvars.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "minVersion":
						this._MinVersion = txt;
						continue;
					case "enabledByDefault":
						this._EnabledByDefault = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPlayerDeliveryType");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("label", this.Label);
			kparams.AddIfNotNull("flashvars", this.Flashvars);
			kparams.AddIfNotNull("minVersion", this.MinVersion);
			kparams.AddIfNotNull("enabledByDefault", this.EnabledByDefault);
			return kparams;
		}
		#endregion
	}
}

