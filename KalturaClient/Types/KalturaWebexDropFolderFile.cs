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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaWebexDropFolderFile : KalturaDropFolderFile
	{
		#region Private Fields
		private int _RecordingId = Int32.MinValue;
		private string _WebexHostId = null;
		private string _Description = null;
		private string _ConfId = null;
		private string _ContentUrl = null;
		#endregion

		#region Properties
		public int RecordingId
		{
			get { return _RecordingId; }
			set 
			{ 
				_RecordingId = value;
				OnPropertyChanged("RecordingId");
			}
		}
		public string WebexHostId
		{
			get { return _WebexHostId; }
			set 
			{ 
				_WebexHostId = value;
				OnPropertyChanged("WebexHostId");
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
		public string ConfId
		{
			get { return _ConfId; }
			set 
			{ 
				_ConfId = value;
				OnPropertyChanged("ConfId");
			}
		}
		public string ContentUrl
		{
			get { return _ContentUrl; }
			set 
			{ 
				_ContentUrl = value;
				OnPropertyChanged("ContentUrl");
			}
		}
		#endregion

		#region CTor
		public KalturaWebexDropFolderFile()
		{
		}

		public KalturaWebexDropFolderFile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "recordingId":
						this.RecordingId = ParseInt(txt);
						continue;
					case "webexHostId":
						this.WebexHostId = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "confId":
						this.ConfId = txt;
						continue;
					case "contentUrl":
						this.ContentUrl = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaWebexDropFolderFile");
			kparams.AddIntIfNotNull("recordingId", this.RecordingId);
			kparams.AddStringIfNotNull("webexHostId", this.WebexHostId);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("confId", this.ConfId);
			kparams.AddStringIfNotNull("contentUrl", this.ContentUrl);
			return kparams;
		}
		#endregion
	}
}
