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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class LiveEntry : MediaEntry
	{
		#region Constants
		public const string OFFLINE_MESSAGE = "offlineMessage";
		public const string RECORD_STATUS = "recordStatus";
		public const string DVR_STATUS = "dvrStatus";
		public const string DVR_WINDOW = "dvrWindow";
		public const string LAST_ELAPSED_RECORDING_TIME = "lastElapsedRecordingTime";
		public const string LIVE_STREAM_CONFIGURATIONS = "liveStreamConfigurations";
		public const string RECORDED_ENTRY_ID = "recordedEntryId";
		public const string PUSH_PUBLISH_ENABLED = "pushPublishEnabled";
		public const string PUBLISH_CONFIGURATIONS = "publishConfigurations";
		public const string FIRST_BROADCAST = "firstBroadcast";
		public const string LAST_BROADCAST = "lastBroadcast";
		public const string CURRENT_BROADCAST_START_TIME = "currentBroadcastStartTime";
		public const string RECORDING_OPTIONS = "recordingOptions";
		public const string LIVE_STATUS = "liveStatus";
		#endregion

		#region Private Fields
		private string _OfflineMessage = null;
		private RecordStatus _RecordStatus = (RecordStatus)Int32.MinValue;
		private DVRStatus _DvrStatus = (DVRStatus)Int32.MinValue;
		private int _DvrWindow = Int32.MinValue;
		private int _LastElapsedRecordingTime = Int32.MinValue;
		private IList<LiveStreamConfiguration> _LiveStreamConfigurations;
		private string _RecordedEntryId = null;
		private LivePublishStatus _PushPublishEnabled = (LivePublishStatus)Int32.MinValue;
		private IList<LiveStreamPushPublishConfiguration> _PublishConfigurations;
		private int _FirstBroadcast = Int32.MinValue;
		private int _LastBroadcast = Int32.MinValue;
		private float _CurrentBroadcastStartTime = Single.MinValue;
		private LiveEntryRecordingOptions _RecordingOptions;
		private EntryServerNodeStatus _LiveStatus = (EntryServerNodeStatus)Int32.MinValue;
		#endregion

		#region Properties
		public string OfflineMessage
		{
			get { return _OfflineMessage; }
			set 
			{ 
				_OfflineMessage = value;
				OnPropertyChanged("OfflineMessage");
			}
		}
		public RecordStatus RecordStatus
		{
			get { return _RecordStatus; }
			set 
			{ 
				_RecordStatus = value;
				OnPropertyChanged("RecordStatus");
			}
		}
		public DVRStatus DvrStatus
		{
			get { return _DvrStatus; }
			set 
			{ 
				_DvrStatus = value;
				OnPropertyChanged("DvrStatus");
			}
		}
		public int DvrWindow
		{
			get { return _DvrWindow; }
			set 
			{ 
				_DvrWindow = value;
				OnPropertyChanged("DvrWindow");
			}
		}
		public int LastElapsedRecordingTime
		{
			get { return _LastElapsedRecordingTime; }
			set 
			{ 
				_LastElapsedRecordingTime = value;
				OnPropertyChanged("LastElapsedRecordingTime");
			}
		}
		public IList<LiveStreamConfiguration> LiveStreamConfigurations
		{
			get { return _LiveStreamConfigurations; }
			set 
			{ 
				_LiveStreamConfigurations = value;
				OnPropertyChanged("LiveStreamConfigurations");
			}
		}
		public string RecordedEntryId
		{
			get { return _RecordedEntryId; }
			set 
			{ 
				_RecordedEntryId = value;
				OnPropertyChanged("RecordedEntryId");
			}
		}
		public LivePublishStatus PushPublishEnabled
		{
			get { return _PushPublishEnabled; }
			set 
			{ 
				_PushPublishEnabled = value;
				OnPropertyChanged("PushPublishEnabled");
			}
		}
		public IList<LiveStreamPushPublishConfiguration> PublishConfigurations
		{
			get { return _PublishConfigurations; }
			set 
			{ 
				_PublishConfigurations = value;
				OnPropertyChanged("PublishConfigurations");
			}
		}
		public int FirstBroadcast
		{
			get { return _FirstBroadcast; }
		}
		public int LastBroadcast
		{
			get { return _LastBroadcast; }
		}
		public float CurrentBroadcastStartTime
		{
			get { return _CurrentBroadcastStartTime; }
			set 
			{ 
				_CurrentBroadcastStartTime = value;
				OnPropertyChanged("CurrentBroadcastStartTime");
			}
		}
		public LiveEntryRecordingOptions RecordingOptions
		{
			get { return _RecordingOptions; }
			set 
			{ 
				_RecordingOptions = value;
				OnPropertyChanged("RecordingOptions");
			}
		}
		public EntryServerNodeStatus LiveStatus
		{
			get { return _LiveStatus; }
		}
		#endregion

		#region CTor
		public LiveEntry()
		{
		}

		public LiveEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "offlineMessage":
						this._OfflineMessage = txt;
						continue;
					case "recordStatus":
						this._RecordStatus = (RecordStatus)ParseEnum(typeof(RecordStatus), txt);
						continue;
					case "dvrStatus":
						this._DvrStatus = (DVRStatus)ParseEnum(typeof(DVRStatus), txt);
						continue;
					case "dvrWindow":
						this._DvrWindow = ParseInt(txt);
						continue;
					case "lastElapsedRecordingTime":
						this._LastElapsedRecordingTime = ParseInt(txt);
						continue;
					case "liveStreamConfigurations":
						this._LiveStreamConfigurations = new List<LiveStreamConfiguration>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._LiveStreamConfigurations.Add(ObjectFactory.Create<LiveStreamConfiguration>(arrayNode));
						}
						continue;
					case "recordedEntryId":
						this._RecordedEntryId = txt;
						continue;
					case "pushPublishEnabled":
						this._PushPublishEnabled = (LivePublishStatus)ParseEnum(typeof(LivePublishStatus), txt);
						continue;
					case "publishConfigurations":
						this._PublishConfigurations = new List<LiveStreamPushPublishConfiguration>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PublishConfigurations.Add(ObjectFactory.Create<LiveStreamPushPublishConfiguration>(arrayNode));
						}
						continue;
					case "firstBroadcast":
						this._FirstBroadcast = ParseInt(txt);
						continue;
					case "lastBroadcast":
						this._LastBroadcast = ParseInt(txt);
						continue;
					case "currentBroadcastStartTime":
						this._CurrentBroadcastStartTime = ParseFloat(txt);
						continue;
					case "recordingOptions":
						this._RecordingOptions = ObjectFactory.Create<LiveEntryRecordingOptions>(propertyNode);
						continue;
					case "liveStatus":
						this._LiveStatus = (EntryServerNodeStatus)ParseEnum(typeof(EntryServerNodeStatus), txt);
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
				kparams.AddReplace("objectType", "KalturaLiveEntry");
			kparams.AddIfNotNull("offlineMessage", this._OfflineMessage);
			kparams.AddIfNotNull("recordStatus", this._RecordStatus);
			kparams.AddIfNotNull("dvrStatus", this._DvrStatus);
			kparams.AddIfNotNull("dvrWindow", this._DvrWindow);
			kparams.AddIfNotNull("lastElapsedRecordingTime", this._LastElapsedRecordingTime);
			kparams.AddIfNotNull("liveStreamConfigurations", this._LiveStreamConfigurations);
			kparams.AddIfNotNull("recordedEntryId", this._RecordedEntryId);
			kparams.AddIfNotNull("pushPublishEnabled", this._PushPublishEnabled);
			kparams.AddIfNotNull("publishConfigurations", this._PublishConfigurations);
			kparams.AddIfNotNull("firstBroadcast", this._FirstBroadcast);
			kparams.AddIfNotNull("lastBroadcast", this._LastBroadcast);
			kparams.AddIfNotNull("currentBroadcastStartTime", this._CurrentBroadcastStartTime);
			kparams.AddIfNotNull("recordingOptions", this._RecordingOptions);
			kparams.AddIfNotNull("liveStatus", this._LiveStatus);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OFFLINE_MESSAGE:
					return "OfflineMessage";
				case RECORD_STATUS:
					return "RecordStatus";
				case DVR_STATUS:
					return "DvrStatus";
				case DVR_WINDOW:
					return "DvrWindow";
				case LAST_ELAPSED_RECORDING_TIME:
					return "LastElapsedRecordingTime";
				case LIVE_STREAM_CONFIGURATIONS:
					return "LiveStreamConfigurations";
				case RECORDED_ENTRY_ID:
					return "RecordedEntryId";
				case PUSH_PUBLISH_ENABLED:
					return "PushPublishEnabled";
				case PUBLISH_CONFIGURATIONS:
					return "PublishConfigurations";
				case FIRST_BROADCAST:
					return "FirstBroadcast";
				case LAST_BROADCAST:
					return "LastBroadcast";
				case CURRENT_BROADCAST_START_TIME:
					return "CurrentBroadcastStartTime";
				case RECORDING_OPTIONS:
					return "RecordingOptions";
				case LIVE_STATUS:
					return "LiveStatus";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}
