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
	public class KalturaEventNotificationDispatchJobData : KalturaJobData
	{
		#region Private Fields
		private int _TemplateId = Int32.MinValue;
		private IList<KalturaKeyValue> _ContentParameters;
		#endregion

		#region Properties
		public int TemplateId
		{
			get { return _TemplateId; }
			set 
			{ 
				_TemplateId = value;
				OnPropertyChanged("TemplateId");
			}
		}
		public IList<KalturaKeyValue> ContentParameters
		{
			get { return _ContentParameters; }
			set 
			{ 
				_ContentParameters = value;
				OnPropertyChanged("ContentParameters");
			}
		}
		#endregion

		#region CTor
		public KalturaEventNotificationDispatchJobData()
		{
		}

		public KalturaEventNotificationDispatchJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "templateId":
						this.TemplateId = ParseInt(txt);
						continue;
					case "contentParameters":
						this.ContentParameters = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.ContentParameters.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEventNotificationDispatchJobData");
			kparams.AddIntIfNotNull("templateId", this.TemplateId);
			if (this.ContentParameters != null)
			{
				if (this.ContentParameters.Count == 0)
				{
					kparams.Add("contentParameters:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaKeyValue item in this.ContentParameters)
					{
						kparams.Add("contentParameters:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}
