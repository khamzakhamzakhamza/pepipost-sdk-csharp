/*
 * PepipostAPI.Standard
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
using PepipostAPI.Standard;
using PepipostAPI.Standard.Utilities;


namespace PepipostAPI.Standard.Models
{
    public class EmailBody : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.Personalizations> personalizations;
        private string tags;
        private Models.From mfrom;
        private string subject;
        private string content;
        private List<Models.EmailBodyAttachments> attachments;
        private Models.Settings settings;
        private string replyToId;
        private int? templateId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("personalizations")]
        public List<Models.Personalizations> Personalizations 
        { 
            get 
            {
                return this.personalizations; 
            } 
            set 
            {
                this.personalizations = value;
                onPropertyChanged("Personalizations");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tags")]
        public string Tags 
        { 
            get 
            {
                return this.tags; 
            } 
            set 
            {
                this.tags = value;
                onPropertyChanged("Tags");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("from")]
        public Models.From From 
        { 
            get 
            {
                return this.mfrom; 
            } 
            set 
            {
                this.mfrom = value;
                onPropertyChanged("From");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("subject")]
        public string Subject 
        { 
            get 
            {
                return this.subject; 
            } 
            set 
            {
                this.subject = value;
                onPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("content")]
        public string Content 
        { 
            get 
            {
                return this.content; 
            } 
            set 
            {
                this.content = value;
                onPropertyChanged("Content");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("attachments")]
        public List<Models.EmailBodyAttachments> Attachments 
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
        [JsonProperty("settings")]
        public Models.Settings Settings 
        { 
            get 
            {
                return this.settings; 
            } 
            set 
            {
                this.settings = value;
                onPropertyChanged("Settings");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("replyToId")]
        public string ReplyToId 
        { 
            get 
            {
                return this.replyToId; 
            } 
            set 
            {
                this.replyToId = value;
                onPropertyChanged("ReplyToId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("templateId")]
        public int? TemplateId 
        { 
            get 
            {
                return this.templateId; 
            } 
            set 
            {
                this.templateId = value;
                onPropertyChanged("TemplateId");
            }
        }
    }
} 