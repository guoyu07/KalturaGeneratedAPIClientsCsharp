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
namespace Kaltura
{
	public sealed class KalturaAnswerCuePointOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAnswerCuePointOrderBy CREATED_AT_ASC = new KalturaAnswerCuePointOrderBy("+createdAt");
		public static readonly KalturaAnswerCuePointOrderBy IS_CORRECT_ASC = new KalturaAnswerCuePointOrderBy("+isCorrect");
		public static readonly KalturaAnswerCuePointOrderBy PARTNER_SORT_VALUE_ASC = new KalturaAnswerCuePointOrderBy("+partnerSortValue");
		public static readonly KalturaAnswerCuePointOrderBy START_TIME_ASC = new KalturaAnswerCuePointOrderBy("+startTime");
		public static readonly KalturaAnswerCuePointOrderBy TRIGGERED_AT_ASC = new KalturaAnswerCuePointOrderBy("+triggeredAt");
		public static readonly KalturaAnswerCuePointOrderBy UPDATED_AT_ASC = new KalturaAnswerCuePointOrderBy("+updatedAt");
		public static readonly KalturaAnswerCuePointOrderBy CREATED_AT_DESC = new KalturaAnswerCuePointOrderBy("-createdAt");
		public static readonly KalturaAnswerCuePointOrderBy IS_CORRECT_DESC = new KalturaAnswerCuePointOrderBy("-isCorrect");
		public static readonly KalturaAnswerCuePointOrderBy PARTNER_SORT_VALUE_DESC = new KalturaAnswerCuePointOrderBy("-partnerSortValue");
		public static readonly KalturaAnswerCuePointOrderBy START_TIME_DESC = new KalturaAnswerCuePointOrderBy("-startTime");
		public static readonly KalturaAnswerCuePointOrderBy TRIGGERED_AT_DESC = new KalturaAnswerCuePointOrderBy("-triggeredAt");
		public static readonly KalturaAnswerCuePointOrderBy UPDATED_AT_DESC = new KalturaAnswerCuePointOrderBy("-updatedAt");

		private KalturaAnswerCuePointOrderBy(string name) : base(name) { }
	}
}