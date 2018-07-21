using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ArkEcosystem.Client.API.Two.Models
{
    [JsonObject]
    public class Transaction
    {
        public string Id { get; set; }
        public string BlockId { get; set; }
        public byte Type { get; set; }
        public long Amount { get; set; }
        public long Fee { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Signature { get; set; }
        public string VendorField { get; set; }
        public string Asset { get; set; } // TODO
        public long Confirmations { get; set; }
        public Timestamp Timestamp { get; set; }
    }

    [JsonObject]
    public class TransactionTypes
    {
        public byte Transfer { get; set; }
        public byte SecondSignature { get; set; }
        public byte DelegateRegistration { get; set; }
        public byte Vote { get; set; }
        public byte MultiSignature { get; set; }
        public byte IPFS { get; set; }
        public byte TimelockTransfer { get; set; }
        public byte MultiPayment { get; set; }
        public byte DelegateResignation { get; set; }
    }
}