﻿using CCXT.NET.Coin.Private;
using CCXT.NET.Coin.Types;
using CCXT.NET.Configuration;
using Newtonsoft.Json;
using System;

namespace CCXT.NET.ItBit.Private
{
    /// <summary>
    ///
    /// </summary>
    public class TTransferItem : CCXT.NET.Coin.Private.TransferItem, ITransferItem
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "txnHash")]
        public override string transactionId
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "originTransactionType")]
        public override TransactionType transactionType
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "destinationAddress")]
        public override string toAddress
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "walletName")]
        public string walletName
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        private string status
        {
            set
            {
                isCompleted = value == "completed";
            }
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "transactionType")]
        private string typeValue
        {
            set
            {
                transactionType = TransactionTypeConverter.FromString(value);
            }
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        private DateTime timeValue
        {
            set
            {
                timestamp = CUnixTime.ConvertToUnixTimeMilli(value);
            }
        }
    }
}