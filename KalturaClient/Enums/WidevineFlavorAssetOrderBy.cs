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
// Copyright (C) 2006-2017  Kaltura Inc.
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
namespace Kaltura.Enums
{
	public sealed class WidevineFlavorAssetOrderBy : StringEnum
	{
		public static readonly WidevineFlavorAssetOrderBy CREATED_AT_ASC = new WidevineFlavorAssetOrderBy("+createdAt");
		public static readonly WidevineFlavorAssetOrderBy DELETED_AT_ASC = new WidevineFlavorAssetOrderBy("+deletedAt");
		public static readonly WidevineFlavorAssetOrderBy SIZE_ASC = new WidevineFlavorAssetOrderBy("+size");
		public static readonly WidevineFlavorAssetOrderBy UPDATED_AT_ASC = new WidevineFlavorAssetOrderBy("+updatedAt");
		public static readonly WidevineFlavorAssetOrderBy CREATED_AT_DESC = new WidevineFlavorAssetOrderBy("-createdAt");
		public static readonly WidevineFlavorAssetOrderBy DELETED_AT_DESC = new WidevineFlavorAssetOrderBy("-deletedAt");
		public static readonly WidevineFlavorAssetOrderBy SIZE_DESC = new WidevineFlavorAssetOrderBy("-size");
		public static readonly WidevineFlavorAssetOrderBy UPDATED_AT_DESC = new WidevineFlavorAssetOrderBy("-updatedAt");

		private WidevineFlavorAssetOrderBy(string name) : base(name) { }
	}
}