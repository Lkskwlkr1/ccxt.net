﻿using CCXT.NET.Coin.Public;
using Newtonsoft.Json;

namespace CCXT.NET.Zb.Public
{
    /// <summary>
    ///
    /// </summary>
    public class ZTicker : CCXT.NET.Coin.Public.Ticker, ITicker
    {
        /// <summary>
        ///
        /// </summary>
        public ZTicker()
        {
            this.result = new ZTickerItem();
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "ticker")]
        public new ZTickerItem result
        {
            get;
            set;
        }
    }

    /// <summary>
    ///
    /// </summary>
    public class ZTickerItem : CCXT.NET.Coin.Public.TickerItem, ITickerItem
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "buy")]
        public override decimal bidPrice
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "sell")]
        public override decimal askPrice
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "last")]
        public override decimal closePrice
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "high")]
        public override decimal highPrice
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "low")]
        public override decimal lowPrice
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "vol")]
        public override decimal baseVolume
        {
            get;
            set;
        }
    }
}