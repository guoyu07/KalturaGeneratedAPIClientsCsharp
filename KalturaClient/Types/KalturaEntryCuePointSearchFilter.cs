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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaEntryCuePointSearchFilter : KalturaSearchItem
	{
		#region Private Fields
		private string _CuePointsFreeText = null;
		private string _CuePointTypeIn = null;
		private int _CuePointSubTypeEqual = Int32.MinValue;
		#endregion

		#region Properties
		public string CuePointsFreeText
		{
			get { return _CuePointsFreeText; }
			set 
			{ 
				_CuePointsFreeText = value;
				OnPropertyChanged("CuePointsFreeText");
			}
		}
		public string CuePointTypeIn
		{
			get { return _CuePointTypeIn; }
			set 
			{ 
				_CuePointTypeIn = value;
				OnPropertyChanged("CuePointTypeIn");
			}
		}
		public int CuePointSubTypeEqual
		{
			get { return _CuePointSubTypeEqual; }
			set 
			{ 
				_CuePointSubTypeEqual = value;
				OnPropertyChanged("CuePointSubTypeEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaEntryCuePointSearchFilter()
		{
		}

		public KalturaEntryCuePointSearchFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "cuePointsFreeText":
						this.CuePointsFreeText = txt;
						continue;
					case "cuePointTypeIn":
						this.CuePointTypeIn = txt;
						continue;
					case "cuePointSubTypeEqual":
						this.CuePointSubTypeEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEntryCuePointSearchFilter");
			kparams.AddStringIfNotNull("cuePointsFreeText", this.CuePointsFreeText);
			kparams.AddStringIfNotNull("cuePointTypeIn", this.CuePointTypeIn);
			kparams.AddIntIfNotNull("cuePointSubTypeEqual", this.CuePointSubTypeEqual);
			return kparams;
		}
		#endregion
	}
}
