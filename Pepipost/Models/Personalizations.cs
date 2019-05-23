/*
 * Pepipost
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Pepipost;
using Pepipost.Utilities;

namespace Pepipost.Models
{
    public class Personalizations : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string recipient;
        private string xApiheaderCc;
        private string xApiheader;
        private object attributes;
        private object xHeaders;
        private List<Models.Attachments> attachments;
        private List<string> recipientCc;
        private List<string> recipientBcc;

        /// <summary>
        /// Emails to be passed in Apicall
        /// </summary>
        [JsonProperty("recipient")]
        public string Recipient 
        { 
            get 
            {
                return this.recipient; 
            } 
            set 
            {
                this.recipient = value;
                onPropertyChanged("Recipient");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("x-apiheader_cc")]
        public string XApiheaderCc 
        { 
            get 
            {
                return this.xApiheaderCc; 
            } 
            set 
            {
                this.xApiheaderCc = value;
                onPropertyChanged("XApiheaderCc");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("x-apiheader")]
        public string XApiheader 
        { 
            get 
            {
                return this.xApiheader; 
            } 
            set 
            {
                this.xApiheader = value;
                onPropertyChanged("XApiheader");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("attributes")]
        public object Attributes 
        { 
            get 
            {
                return this.attributes; 
            } 
            set 
            {
                this.attributes = value;
                onPropertyChanged("Attributes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("x-headers")]
        public object XHeaders
        {
            get
            {
                return this.xHeaders;
            }
            set
            {
                this.xHeaders = value;
                onPropertyChanged("XHeaders");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("attachments")]
        public List<Models.Attachments> Attachments 
        { 
            get 
            {
                return this.attachments; 
            } 
            set 
            {
                this.attachments = value;
                onPropertyChanged("Attachments");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("recipient_cc")]
        public List<string> RecipientCc 
        { 
            get 
            {
                return this.recipientCc; 
            } 
            set 
            {
                this.recipientCc = value;
                onPropertyChanged("RecipientCc");
            }
        }

        /// <summary>
        /// TODO: Updated by vikram for bcc functionality support in SDK
        /// </summary>
        [JsonProperty("recipient_bcc")]
        public List<string> RecipientBcc
        {
            get
            {
                return this.recipientBcc;
            }
            set
            {
                this.recipientBcc = value;
                onPropertyChanged("RecipientBcc");
            }
        }

    }
} 