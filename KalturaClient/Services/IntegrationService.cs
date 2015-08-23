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

	public class KalturaIntegrationService : KalturaServiceBase
	{
	public KalturaIntegrationService(KalturaClient client)
			: base(client)
		{
		}

		public int Dispatch(KalturaIntegrationJobData data, KalturaBatchJobObjectType objectType, string objectId)
		{
			KalturaParams kparams = new KalturaParams();
			if (data != null)
				kparams.Add("data", data.ToParams());
			kparams.AddStringEnumIfNotNull("objectType", objectType);
			kparams.AddStringIfNotNull("objectId", objectId);
			_Client.QueueServiceCall("integration_integration", "dispatch", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public void Notify(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("integration_integration", "notify", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
