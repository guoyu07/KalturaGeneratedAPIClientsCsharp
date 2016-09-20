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
	public class KalturaMediaInfo : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _FlavorAssetId = null;
		private int _FileSize = Int32.MinValue;
		private string _ContainerFormat = null;
		private string _ContainerId = null;
		private string _ContainerProfile = null;
		private int _ContainerDuration = Int32.MinValue;
		private int _ContainerBitRate = Int32.MinValue;
		private string _VideoFormat = null;
		private string _VideoCodecId = null;
		private int _VideoDuration = Int32.MinValue;
		private int _VideoBitRate = Int32.MinValue;
		private KalturaBitRateMode _VideoBitRateMode = (KalturaBitRateMode)Int32.MinValue;
		private int _VideoWidth = Int32.MinValue;
		private int _VideoHeight = Int32.MinValue;
		private float _VideoFrameRate = Single.MinValue;
		private float _VideoDar = Single.MinValue;
		private int _VideoRotation = Int32.MinValue;
		private string _AudioFormat = null;
		private string _AudioCodecId = null;
		private int _AudioDuration = Int32.MinValue;
		private int _AudioBitRate = Int32.MinValue;
		private KalturaBitRateMode _AudioBitRateMode = (KalturaBitRateMode)Int32.MinValue;
		private int _AudioChannels = Int32.MinValue;
		private int _AudioSamplingRate = Int32.MinValue;
		private int _AudioResolution = Int32.MinValue;
		private string _WritingLib = null;
		private string _RawData = null;
		private string _MultiStreamInfo = null;
		private int _ScanType = Int32.MinValue;
		private string _MultiStream = null;
		private int _IsFastStart = Int32.MinValue;
		private string _ContentStreams = null;
		private int _ComplexityValue = Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public int FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		public string ContainerFormat
		{
			get { return _ContainerFormat; }
			set 
			{ 
				_ContainerFormat = value;
				OnPropertyChanged("ContainerFormat");
			}
		}
		public string ContainerId
		{
			get { return _ContainerId; }
			set 
			{ 
				_ContainerId = value;
				OnPropertyChanged("ContainerId");
			}
		}
		public string ContainerProfile
		{
			get { return _ContainerProfile; }
			set 
			{ 
				_ContainerProfile = value;
				OnPropertyChanged("ContainerProfile");
			}
		}
		public int ContainerDuration
		{
			get { return _ContainerDuration; }
			set 
			{ 
				_ContainerDuration = value;
				OnPropertyChanged("ContainerDuration");
			}
		}
		public int ContainerBitRate
		{
			get { return _ContainerBitRate; }
			set 
			{ 
				_ContainerBitRate = value;
				OnPropertyChanged("ContainerBitRate");
			}
		}
		public string VideoFormat
		{
			get { return _VideoFormat; }
			set 
			{ 
				_VideoFormat = value;
				OnPropertyChanged("VideoFormat");
			}
		}
		public string VideoCodecId
		{
			get { return _VideoCodecId; }
			set 
			{ 
				_VideoCodecId = value;
				OnPropertyChanged("VideoCodecId");
			}
		}
		public int VideoDuration
		{
			get { return _VideoDuration; }
			set 
			{ 
				_VideoDuration = value;
				OnPropertyChanged("VideoDuration");
			}
		}
		public int VideoBitRate
		{
			get { return _VideoBitRate; }
			set 
			{ 
				_VideoBitRate = value;
				OnPropertyChanged("VideoBitRate");
			}
		}
		public KalturaBitRateMode VideoBitRateMode
		{
			get { return _VideoBitRateMode; }
			set 
			{ 
				_VideoBitRateMode = value;
				OnPropertyChanged("VideoBitRateMode");
			}
		}
		public int VideoWidth
		{
			get { return _VideoWidth; }
			set 
			{ 
				_VideoWidth = value;
				OnPropertyChanged("VideoWidth");
			}
		}
		public int VideoHeight
		{
			get { return _VideoHeight; }
			set 
			{ 
				_VideoHeight = value;
				OnPropertyChanged("VideoHeight");
			}
		}
		public float VideoFrameRate
		{
			get { return _VideoFrameRate; }
			set 
			{ 
				_VideoFrameRate = value;
				OnPropertyChanged("VideoFrameRate");
			}
		}
		public float VideoDar
		{
			get { return _VideoDar; }
			set 
			{ 
				_VideoDar = value;
				OnPropertyChanged("VideoDar");
			}
		}
		public int VideoRotation
		{
			get { return _VideoRotation; }
			set 
			{ 
				_VideoRotation = value;
				OnPropertyChanged("VideoRotation");
			}
		}
		public string AudioFormat
		{
			get { return _AudioFormat; }
			set 
			{ 
				_AudioFormat = value;
				OnPropertyChanged("AudioFormat");
			}
		}
		public string AudioCodecId
		{
			get { return _AudioCodecId; }
			set 
			{ 
				_AudioCodecId = value;
				OnPropertyChanged("AudioCodecId");
			}
		}
		public int AudioDuration
		{
			get { return _AudioDuration; }
			set 
			{ 
				_AudioDuration = value;
				OnPropertyChanged("AudioDuration");
			}
		}
		public int AudioBitRate
		{
			get { return _AudioBitRate; }
			set 
			{ 
				_AudioBitRate = value;
				OnPropertyChanged("AudioBitRate");
			}
		}
		public KalturaBitRateMode AudioBitRateMode
		{
			get { return _AudioBitRateMode; }
			set 
			{ 
				_AudioBitRateMode = value;
				OnPropertyChanged("AudioBitRateMode");
			}
		}
		public int AudioChannels
		{
			get { return _AudioChannels; }
			set 
			{ 
				_AudioChannels = value;
				OnPropertyChanged("AudioChannels");
			}
		}
		public int AudioSamplingRate
		{
			get { return _AudioSamplingRate; }
			set 
			{ 
				_AudioSamplingRate = value;
				OnPropertyChanged("AudioSamplingRate");
			}
		}
		public int AudioResolution
		{
			get { return _AudioResolution; }
			set 
			{ 
				_AudioResolution = value;
				OnPropertyChanged("AudioResolution");
			}
		}
		public string WritingLib
		{
			get { return _WritingLib; }
			set 
			{ 
				_WritingLib = value;
				OnPropertyChanged("WritingLib");
			}
		}
		public string RawData
		{
			get { return _RawData; }
			set 
			{ 
				_RawData = value;
				OnPropertyChanged("RawData");
			}
		}
		public string MultiStreamInfo
		{
			get { return _MultiStreamInfo; }
			set 
			{ 
				_MultiStreamInfo = value;
				OnPropertyChanged("MultiStreamInfo");
			}
		}
		public int ScanType
		{
			get { return _ScanType; }
			set 
			{ 
				_ScanType = value;
				OnPropertyChanged("ScanType");
			}
		}
		public string MultiStream
		{
			get { return _MultiStream; }
			set 
			{ 
				_MultiStream = value;
				OnPropertyChanged("MultiStream");
			}
		}
		public int IsFastStart
		{
			get { return _IsFastStart; }
			set 
			{ 
				_IsFastStart = value;
				OnPropertyChanged("IsFastStart");
			}
		}
		public string ContentStreams
		{
			get { return _ContentStreams; }
			set 
			{ 
				_ContentStreams = value;
				OnPropertyChanged("ContentStreams");
			}
		}
		public int ComplexityValue
		{
			get { return _ComplexityValue; }
			set 
			{ 
				_ComplexityValue = value;
				OnPropertyChanged("ComplexityValue");
			}
		}
		#endregion

		#region CTor
		public KalturaMediaInfo()
		{
		}

		public KalturaMediaInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "flavorAssetId":
						this._FlavorAssetId = txt;
						continue;
					case "fileSize":
						this._FileSize = ParseInt(txt);
						continue;
					case "containerFormat":
						this._ContainerFormat = txt;
						continue;
					case "containerId":
						this._ContainerId = txt;
						continue;
					case "containerProfile":
						this._ContainerProfile = txt;
						continue;
					case "containerDuration":
						this._ContainerDuration = ParseInt(txt);
						continue;
					case "containerBitRate":
						this._ContainerBitRate = ParseInt(txt);
						continue;
					case "videoFormat":
						this._VideoFormat = txt;
						continue;
					case "videoCodecId":
						this._VideoCodecId = txt;
						continue;
					case "videoDuration":
						this._VideoDuration = ParseInt(txt);
						continue;
					case "videoBitRate":
						this._VideoBitRate = ParseInt(txt);
						continue;
					case "videoBitRateMode":
						this._VideoBitRateMode = (KalturaBitRateMode)ParseEnum(typeof(KalturaBitRateMode), txt);
						continue;
					case "videoWidth":
						this._VideoWidth = ParseInt(txt);
						continue;
					case "videoHeight":
						this._VideoHeight = ParseInt(txt);
						continue;
					case "videoFrameRate":
						this._VideoFrameRate = ParseFloat(txt);
						continue;
					case "videoDar":
						this._VideoDar = ParseFloat(txt);
						continue;
					case "videoRotation":
						this._VideoRotation = ParseInt(txt);
						continue;
					case "audioFormat":
						this._AudioFormat = txt;
						continue;
					case "audioCodecId":
						this._AudioCodecId = txt;
						continue;
					case "audioDuration":
						this._AudioDuration = ParseInt(txt);
						continue;
					case "audioBitRate":
						this._AudioBitRate = ParseInt(txt);
						continue;
					case "audioBitRateMode":
						this._AudioBitRateMode = (KalturaBitRateMode)ParseEnum(typeof(KalturaBitRateMode), txt);
						continue;
					case "audioChannels":
						this._AudioChannels = ParseInt(txt);
						continue;
					case "audioSamplingRate":
						this._AudioSamplingRate = ParseInt(txt);
						continue;
					case "audioResolution":
						this._AudioResolution = ParseInt(txt);
						continue;
					case "writingLib":
						this._WritingLib = txt;
						continue;
					case "rawData":
						this._RawData = txt;
						continue;
					case "multiStreamInfo":
						this._MultiStreamInfo = txt;
						continue;
					case "scanType":
						this._ScanType = ParseInt(txt);
						continue;
					case "multiStream":
						this._MultiStream = txt;
						continue;
					case "isFastStart":
						this._IsFastStart = ParseInt(txt);
						continue;
					case "contentStreams":
						this._ContentStreams = txt;
						continue;
					case "complexityValue":
						this._ComplexityValue = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaMediaInfo");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("flavorAssetId", this.FlavorAssetId);
			kparams.AddIfNotNull("fileSize", this.FileSize);
			kparams.AddIfNotNull("containerFormat", this.ContainerFormat);
			kparams.AddIfNotNull("containerId", this.ContainerId);
			kparams.AddIfNotNull("containerProfile", this.ContainerProfile);
			kparams.AddIfNotNull("containerDuration", this.ContainerDuration);
			kparams.AddIfNotNull("containerBitRate", this.ContainerBitRate);
			kparams.AddIfNotNull("videoFormat", this.VideoFormat);
			kparams.AddIfNotNull("videoCodecId", this.VideoCodecId);
			kparams.AddIfNotNull("videoDuration", this.VideoDuration);
			kparams.AddIfNotNull("videoBitRate", this.VideoBitRate);
			kparams.AddIfNotNull("videoBitRateMode", this.VideoBitRateMode);
			kparams.AddIfNotNull("videoWidth", this.VideoWidth);
			kparams.AddIfNotNull("videoHeight", this.VideoHeight);
			kparams.AddIfNotNull("videoFrameRate", this.VideoFrameRate);
			kparams.AddIfNotNull("videoDar", this.VideoDar);
			kparams.AddIfNotNull("videoRotation", this.VideoRotation);
			kparams.AddIfNotNull("audioFormat", this.AudioFormat);
			kparams.AddIfNotNull("audioCodecId", this.AudioCodecId);
			kparams.AddIfNotNull("audioDuration", this.AudioDuration);
			kparams.AddIfNotNull("audioBitRate", this.AudioBitRate);
			kparams.AddIfNotNull("audioBitRateMode", this.AudioBitRateMode);
			kparams.AddIfNotNull("audioChannels", this.AudioChannels);
			kparams.AddIfNotNull("audioSamplingRate", this.AudioSamplingRate);
			kparams.AddIfNotNull("audioResolution", this.AudioResolution);
			kparams.AddIfNotNull("writingLib", this.WritingLib);
			kparams.AddIfNotNull("rawData", this.RawData);
			kparams.AddIfNotNull("multiStreamInfo", this.MultiStreamInfo);
			kparams.AddIfNotNull("scanType", this.ScanType);
			kparams.AddIfNotNull("multiStream", this.MultiStream);
			kparams.AddIfNotNull("isFastStart", this.IsFastStart);
			kparams.AddIfNotNull("contentStreams", this.ContentStreams);
			kparams.AddIfNotNull("complexityValue", this.ComplexityValue);
			return kparams;
		}
		#endregion
	}
}

