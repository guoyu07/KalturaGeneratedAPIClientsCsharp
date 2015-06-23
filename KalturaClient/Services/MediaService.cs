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
using System.IO;

namespace Kaltura
{

	public class KalturaMediaService : KalturaServiceBase
	{
	public KalturaMediaService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaMediaEntry Add(KalturaMediaEntry entry)
		{
			KalturaParams kparams = new KalturaParams();
			if (entry != null)
				kparams.Add("entry", entry.ToParams());
			_Client.QueueServiceCall("media", "add", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry AddContent(string entryId)
		{
			return this.AddContent(entryId, null);
		}

		public KalturaMediaEntry AddContent(string entryId, KalturaResource resource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (resource != null)
				kparams.Add("resource", resource.ToParams());
			_Client.QueueServiceCall("media", "addContent", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry AddFromUrl(KalturaMediaEntry mediaEntry, string url)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("media", "addFromUrl", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry AddFromSearchResult()
		{
			return this.AddFromSearchResult(null);
		}

		public KalturaMediaEntry AddFromSearchResult(KalturaMediaEntry mediaEntry)
		{
			return this.AddFromSearchResult(mediaEntry, null);
		}

		public KalturaMediaEntry AddFromSearchResult(KalturaMediaEntry mediaEntry, KalturaSearchResult searchResult)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			if (searchResult != null)
				kparams.Add("searchResult", searchResult.ToParams());
			_Client.QueueServiceCall("media", "addFromSearchResult", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry AddFromUploadedFile(KalturaMediaEntry mediaEntry, string uploadTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			_Client.QueueServiceCall("media", "addFromUploadedFile", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry AddFromRecordedWebcam(KalturaMediaEntry mediaEntry, string webcamTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddStringIfNotNull("webcamTokenId", webcamTokenId);
			_Client.QueueServiceCall("media", "addFromRecordedWebcam", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry AddFromEntry(string sourceEntryId)
		{
			return this.AddFromEntry(sourceEntryId, null);
		}

		public KalturaMediaEntry AddFromEntry(string sourceEntryId, KalturaMediaEntry mediaEntry)
		{
			return this.AddFromEntry(sourceEntryId, mediaEntry, Int32.MinValue);
		}

		public KalturaMediaEntry AddFromEntry(string sourceEntryId, KalturaMediaEntry mediaEntry, int sourceFlavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("sourceEntryId", sourceEntryId);
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddIntIfNotNull("sourceFlavorParamsId", sourceFlavorParamsId);
			_Client.QueueServiceCall("media", "addFromEntry", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry AddFromFlavorAsset(string sourceFlavorAssetId)
		{
			return this.AddFromFlavorAsset(sourceFlavorAssetId, null);
		}

		public KalturaMediaEntry AddFromFlavorAsset(string sourceFlavorAssetId, KalturaMediaEntry mediaEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("sourceFlavorAssetId", sourceFlavorAssetId);
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			_Client.QueueServiceCall("media", "addFromFlavorAsset", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public long Convert(string entryId)
		{
			return this.Convert(entryId, Int32.MinValue);
		}

		public long Convert(string entryId, int conversionProfileId)
		{
			return this.Convert(entryId, conversionProfileId, null);
		}

		public long Convert(string entryId, int conversionProfileId, IList<KalturaConversionAttribute> dynamicConversionAttributes)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			foreach(KalturaConversionAttribute obj in dynamicConversionAttributes)
			{
				kparams.Add("dynamicConversionAttributes", obj.ToParams());
			}
			_Client.QueueServiceCall("media", "convert", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return long.Parse(result.InnerText);
		}

		public KalturaMediaEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaMediaEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("media", "get", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public string GetMrss(string entryId)
		{
			return this.GetMrss(entryId, null);
		}

		public string GetMrss(string entryId, IList<KalturaExtendingItemMrssParameter> extendingItemsArray)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			foreach(KalturaExtendingItemMrssParameter obj in extendingItemsArray)
			{
				kparams.Add("extendingItemsArray", obj.ToParams());
			}
			_Client.QueueServiceCall("media", "getMrss", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaMediaEntry Update(string entryId, KalturaMediaEntry mediaEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			_Client.QueueServiceCall("media", "update", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry UpdateContent(string entryId, KalturaResource resource)
		{
			return this.UpdateContent(entryId, resource, Int32.MinValue);
		}

		public KalturaMediaEntry UpdateContent(string entryId, KalturaResource resource, int conversionProfileId)
		{
			return this.UpdateContent(entryId, resource, conversionProfileId, null);
		}

		public KalturaMediaEntry UpdateContent(string entryId, KalturaResource resource, int conversionProfileId, KalturaEntryReplacementOptions advancedOptions)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (resource != null)
				kparams.Add("resource", resource.ToParams());
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			if (advancedOptions != null)
				kparams.Add("advancedOptions", advancedOptions.ToParams());
			_Client.QueueServiceCall("media", "updateContent", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaMediaEntry ApproveReplace(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "approveReplace", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry CancelReplace(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "cancelReplace", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaListResponse List()
		{
			return this.List(null);
		}

		public KalturaMediaListResponse List(KalturaMediaEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaMediaListResponse List(KalturaMediaEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("media", "list", "KalturaMediaListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaListResponse)KalturaObjectFactory.Create(result, "KalturaMediaListResponse");
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaMediaEntryFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			_Client.QueueServiceCall("media", "count", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public string Upload(FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("media", "upload", null, kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaMediaEntry UpdateThumbnail(string entryId, int timeOffset)
		{
			return this.UpdateThumbnail(entryId, timeOffset, Int32.MinValue);
		}

		public KalturaMediaEntry UpdateThumbnail(string entryId, int timeOffset, int flavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("timeOffset", timeOffset);
			kparams.AddIntIfNotNull("flavorParamsId", flavorParamsId);
			_Client.QueueServiceCall("media", "updateThumbnail", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry UpdateThumbnailFromSourceEntry(string entryId, string sourceEntryId, int timeOffset)
		{
			return this.UpdateThumbnailFromSourceEntry(entryId, sourceEntryId, timeOffset, Int32.MinValue);
		}

		public KalturaMediaEntry UpdateThumbnailFromSourceEntry(string entryId, string sourceEntryId, int timeOffset, int flavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("sourceEntryId", sourceEntryId);
			kparams.AddIntIfNotNull("timeOffset", timeOffset);
			kparams.AddIntIfNotNull("flavorParamsId", flavorParamsId);
			_Client.QueueServiceCall("media", "updateThumbnailFromSourceEntry", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaMediaEntry UpdateThumbnailJpeg(string entryId, FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("media", "updateThumbnailJpeg", "KalturaMediaEntry", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}

		public KalturaBaseEntry UpdateThumbnailFromUrl(string entryId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("media", "updateThumbnailFromUrl", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public int RequestConversion(string entryId, string fileFormat)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("fileFormat", fileFormat);
			_Client.QueueServiceCall("media", "requestConversion", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public void Flag(KalturaModerationFlag moderationFlag)
		{
			KalturaParams kparams = new KalturaParams();
			if (moderationFlag != null)
				kparams.Add("moderationFlag", moderationFlag.ToParams());
			_Client.QueueServiceCall("media", "flag", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Reject(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "reject", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Approve(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "approve", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaModerationFlagListResponse ListFlags(string entryId)
		{
			return this.ListFlags(entryId, null);
		}

		public KalturaModerationFlagListResponse ListFlags(string entryId, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("media", "listFlags", "KalturaModerationFlagListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaModerationFlagListResponse)KalturaObjectFactory.Create(result, "KalturaModerationFlagListResponse");
		}

		public void AnonymousRank(string entryId, int rank)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("rank", rank);
			_Client.QueueServiceCall("media", "anonymousRank", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaBulkUpload BulkUploadAdd(FileStream fileData)
		{
			return this.BulkUploadAdd(fileData, null);
		}

		public KalturaBulkUpload BulkUploadAdd(FileStream fileData, KalturaBulkUploadJobData bulkUploadData)
		{
			return this.BulkUploadAdd(fileData, bulkUploadData, null);
		}

		public KalturaBulkUpload BulkUploadAdd(FileStream fileData, KalturaBulkUploadJobData bulkUploadData, KalturaBulkUploadEntryData bulkUploadEntryData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			if (bulkUploadData != null)
				kparams.Add("bulkUploadData", bulkUploadData.ToParams());
			if (bulkUploadEntryData != null)
				kparams.Add("bulkUploadEntryData", bulkUploadEntryData.ToParams());
			_Client.QueueServiceCall("media", "bulkUploadAdd", "KalturaBulkUpload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result, "KalturaBulkUpload");
		}
	}
}