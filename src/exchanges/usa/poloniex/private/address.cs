﻿using CCXT.NET.Coin.Private;
using Newtonsoft.Json;

namespace CCXT.NET.Poloniex.Private
{
    /// <summary>
    ///
    /// </summary>
    public class PAddressItem : CCXT.NET.Coin.Private.AddressItem, IAddressItem
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        private long successValue
        {
            set
            {
                this.success = value == 1;
            }
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public override string address
        {
            get;
            set;
        }
    }
}