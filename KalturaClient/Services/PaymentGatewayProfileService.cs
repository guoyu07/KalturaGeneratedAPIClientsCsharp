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
using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class PaymentGatewayProfileAddRequestBuilder : StandaloneRequestBuilder<PaymentGatewayProfile>
	{
		#region Constants
		public const string PAYMENT_GATEWAY = "paymentGateway";
		#endregion

		public PaymentGatewayProfile PaymentGateway
		{
			set;
			get;
		}

		public PaymentGatewayProfileAddRequestBuilder()
			: base("paymentgatewayprofile", "add")
		{
		}

		public PaymentGatewayProfileAddRequestBuilder(PaymentGatewayProfile paymentGateway)
			: this()
		{
			this.PaymentGateway = paymentGateway;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("paymentGateway"))
				kparams.AddIfNotNull("paymentGateway", PaymentGateway);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<PaymentGatewayProfile>(result);
		}
	}

	public class PaymentGatewayProfileDeleteRequestBuilder : StandaloneRequestBuilder<bool>
	{
		#region Constants
		public const string PAYMENT_GATEWAY_ID = "paymentGatewayId";
		#endregion

		public int PaymentGatewayId
		{
			set;
			get;
		}

		public PaymentGatewayProfileDeleteRequestBuilder()
			: base("paymentgatewayprofile", "delete")
		{
		}

		public PaymentGatewayProfileDeleteRequestBuilder(int paymentGatewayId)
			: this()
		{
			this.PaymentGatewayId = paymentGatewayId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("paymentGatewayId"))
				kparams.AddIfNotNull("paymentGatewayId", PaymentGatewayId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class PaymentGatewayProfileGenerateSharedSecretRequestBuilder : StandaloneRequestBuilder<PaymentGatewayProfile>
	{
		#region Constants
		public const string PAYMENT_GATEWAY_ID = "paymentGatewayId";
		#endregion

		public int PaymentGatewayId
		{
			set;
			get;
		}

		public PaymentGatewayProfileGenerateSharedSecretRequestBuilder()
			: base("paymentgatewayprofile", "generateSharedSecret")
		{
		}

		public PaymentGatewayProfileGenerateSharedSecretRequestBuilder(int paymentGatewayId)
			: this()
		{
			this.PaymentGatewayId = paymentGatewayId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("paymentGatewayId"))
				kparams.AddIfNotNull("paymentGatewayId", PaymentGatewayId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<PaymentGatewayProfile>(result);
		}
	}

	public class PaymentGatewayProfileGetConfigurationRequestBuilder : StandaloneRequestBuilder<PaymentGatewayConfiguration>
	{
		#region Constants
		public const string ALIAS = "alias";
		public const string INTENT = "intent";
		public const string EXTRA_PARAMETERS = "extraParameters";
		#endregion

		public string Alias
		{
			set;
			get;
		}
		public string Intent
		{
			set;
			get;
		}
		public IList<KeyValue> ExtraParameters
		{
			set;
			get;
		}

		public PaymentGatewayProfileGetConfigurationRequestBuilder()
			: base("paymentgatewayprofile", "getConfiguration")
		{
		}

		public PaymentGatewayProfileGetConfigurationRequestBuilder(string alias, string intent, IList<KeyValue> extraParameters)
			: this()
		{
			this.Alias = alias;
			this.Intent = intent;
			this.ExtraParameters = extraParameters;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("alias"))
				kparams.AddIfNotNull("alias", Alias);
			if (!isMapped("intent"))
				kparams.AddIfNotNull("intent", Intent);
			if (!isMapped("extraParameters"))
				kparams.AddIfNotNull("extraParameters", ExtraParameters);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<PaymentGatewayConfiguration>(result);
		}
	}

	public class PaymentGatewayProfileListRequestBuilder : StandaloneRequestBuilder<ListResponse<PaymentGatewayProfile>>
	{
		#region Constants
		#endregion


		public PaymentGatewayProfileListRequestBuilder()
			: base("paymentgatewayprofile", "list")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<PaymentGatewayProfile>>(result);
		}
	}

	public class PaymentGatewayProfileUpdateRequestBuilder : StandaloneRequestBuilder<PaymentGatewayProfile>
	{
		#region Constants
		public const string PAYMENT_GATEWAY_ID = "paymentGatewayId";
		public const string PAYMENT_GATEWAY = "paymentGateway";
		#endregion

		public int PaymentGatewayId
		{
			set;
			get;
		}
		public PaymentGatewayProfile PaymentGateway
		{
			set;
			get;
		}

		public PaymentGatewayProfileUpdateRequestBuilder()
			: base("paymentgatewayprofile", "update")
		{
		}

		public PaymentGatewayProfileUpdateRequestBuilder(int paymentGatewayId, PaymentGatewayProfile paymentGateway)
			: this()
		{
			this.PaymentGatewayId = paymentGatewayId;
			this.PaymentGateway = paymentGateway;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("paymentGatewayId"))
				kparams.AddIfNotNull("paymentGatewayId", PaymentGatewayId);
			if (!isMapped("paymentGateway"))
				kparams.AddIfNotNull("paymentGateway", PaymentGateway);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<PaymentGatewayProfile>(result);
		}
	}


	public class PaymentGatewayProfileService
	{
		private PaymentGatewayProfileService()
		{
		}

		public static PaymentGatewayProfileAddRequestBuilder Add(PaymentGatewayProfile paymentGateway)
		{
			return new PaymentGatewayProfileAddRequestBuilder(paymentGateway);
		}

		public static PaymentGatewayProfileDeleteRequestBuilder Delete(int paymentGatewayId)
		{
			return new PaymentGatewayProfileDeleteRequestBuilder(paymentGatewayId);
		}

		public static PaymentGatewayProfileGenerateSharedSecretRequestBuilder GenerateSharedSecret(int paymentGatewayId)
		{
			return new PaymentGatewayProfileGenerateSharedSecretRequestBuilder(paymentGatewayId);
		}

		public static PaymentGatewayProfileGetConfigurationRequestBuilder GetConfiguration(string alias, string intent, IList<KeyValue> extraParameters)
		{
			return new PaymentGatewayProfileGetConfigurationRequestBuilder(alias, intent, extraParameters);
		}

		public static PaymentGatewayProfileListRequestBuilder List()
		{
			return new PaymentGatewayProfileListRequestBuilder();
		}

		public static PaymentGatewayProfileUpdateRequestBuilder Update(int paymentGatewayId, PaymentGatewayProfile paymentGateway)
		{
			return new PaymentGatewayProfileUpdateRequestBuilder(paymentGatewayId, paymentGateway);
		}
	}
}
