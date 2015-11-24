using System.Xml.Serialization;

namespace XmlGeneration.Core.XmlSchema.SecondOutput
{ 
                    /// <remarks/>
                    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
                    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
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

                        private tvProgramme[] programmeField;

                        /// <remarks/>
                        [System.Xml.Serialization.XmlElementAttribute("programme")]
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
                    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
                    public partial class tvProgramme
                    {

                        private System.DateTime dateField;

                        private string titleField;

                        private string subTitleField;

                        private string descField;

                        private string channelField;

                        private string startField;

                        private string stopField;

                        private string originidField;

                        private string reserveField;

                        /// <remarks/>
                        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
                        public System.DateTime date
                        {
                            get
                            {
                                return this.dateField;
                            }
                            set
                            {
                                this.dateField = value;
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
                        public string subTitle
                        {
                            get
                            {
                                return this.subTitleField;
                            }
                            set
                            {
                                this.subTitleField = value;
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
                        [System.Xml.Serialization.XmlAttributeAttribute()]
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
                        [System.Xml.Serialization.XmlAttributeAttribute()]
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
                        [System.Xml.Serialization.XmlAttributeAttribute()]
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

                        /// <remarks/>
                        [System.Xml.Serialization.XmlAttributeAttribute()]
                        public string originid
                        {
                            get
                            {
                                return this.originidField;
                            }
                            set
                            {
                                this.originidField = value;
                            }
                        }

                        /// <remarks/>
                        [System.Xml.Serialization.XmlAttributeAttribute()]
                        public string reserve
                        {
                            get
                            {
                                return this.reserveField;
                            }
                            set
                            {
                                this.reserveField = value;
                            }
                        }
                    }


}