using System.Xml.Serialization;

namespace XmlGeneration.Core.XmlSchema
{
    
        /// <remarks/>
        [XmlType(AnonymousType = true)]
        [XmlRoot(Namespace = "tv:noNamespaceSchemaLocation", IsNullable = false)]
        public class tv
        {

            public void Save(string fileName)
            {
                using (var writer = new System.IO.StreamWriter(fileName))
                {
                    var serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(writer, this);
                    writer.Flush();
                }
            }

            private tvChannel channelField;

            private tvProgramme[] programmeField;

            /// <remarks/>
            public tvChannel channel
            {
                get
                {
                    return this.channelField;
                }
                set
                {
                    this.channelField = value;
                }
            }

            /// <remarks/>
            [XmlElement("programme")]
            public tvProgramme[] programme
            {
                get
                {
                    return this.programmeField;
                }
                set
                {
                    this.programmeField = value;
                }
            }
        }

        /// <remarks/>
        [XmlType(AnonymousType = true)]
        public partial class tvChannel
        {

            private string displaynameField;

            private string idField;

            /// <remarks/>
            [XmlElement("display-name")]
            public string displayname
            {
                get
                {
                    return this.displaynameField;
                }
                set
                {
                    this.displaynameField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [XmlType(AnonymousType = true)]
        public partial class tvProgramme
        {
            private string channelField;

            private tvProgrammeLength lengthField;

            private string titleField;

            private string categoryField;

            private string descField;

            private tvProgrammeName[] creditsField;

            private string imageField;

            private string startField;

            private string stopField;

            /// <remarks/>
            [XmlAttribute()]
            public string channel
            {
                get
                {
                    return this.channelField;
                }
                set
                {
                    this.channelField = value;
                }
            }

            /// <remarks/>
            public tvProgrammeLength length
            {
                get
                {
                    return this.lengthField;
                }
                set
                {
                    this.lengthField = value;
                }
            }

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string category
            {
                get
                {
                    return this.categoryField;
                }
                set
                {
                    this.categoryField = value;
                }
            }

            /// <remarks/>
            public string desc
            {
                get
                {
                    return this.descField;
                }
                set
                {
                    this.descField = value;
                }
            }

            /// <remarks/>
            [XmlArrayItem("name", IsNullable = false)]
            public tvProgrammeName[] credits
            {
                get
                {
                    return this.creditsField;
                }
                set
                {
                    this.creditsField = value;
                }
            }

            /// <remarks/>
            public string image
            {
                get
                {
                    return this.imageField;
                }
                set
                {
                    this.imageField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string start
            {
                get
                {
                    return this.startField;
                }
                set
                {
                    this.startField = value;
                }
            }

            /// <remarks/>
            [XmlAttribute()]
            public string stop
            {
                get
                {
                    return this.stopField;
                }
                set
                {
                    this.stopField = value;
                }
            }

            
        }

        /// <remarks/>
        [XmlType(AnonymousType = true)]
        public partial class tvProgrammeLength
        {

            private string unitsField;

            private ushort valueField;

            /// <remarks/>
            [XmlAttribute()]
            public string units
            {
                get
                {
                    return this.unitsField;
                }
                set
                {
                    this.unitsField = value;
                }
            }

            /// <remarks/>
            [XmlText()]
            public ushort Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [XmlType(AnonymousType = true)]
        public partial class tvProgrammeName
        {

            private string functionField;

            private string valueField;

            /// <remarks/>
            [XmlAttribute()]
            public string function
            {
                get
                {
                    return this.functionField;
                }
                set
                {
                    this.functionField = value;
                }
            }

            /// <remarks/>
            [XmlText()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

    public static class CommonFunctions
    {
        public static string GetIpAddress()
        {

            System.Web.HttpContext context = System.Web.HttpContext.Current;
            var ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                var addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
    }
    
}
