﻿using CCXT.NET.Coin.Private;
using Newtonsoft.Json;

namespace CCXT.NET.Binance.Private
{
    /// <summary>
    ///
    /// </summary>
    public class BAddressItem : CCXT.NET.Coin.Private.AddressItem, IAddressItem
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "asset")]
        public override string currency
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public override string address
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "addressTag")]
        public override string tag
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public override bool success
        {
            get;
            set;
        }
    }
}