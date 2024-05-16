namespace TestApp.Entities
{
    public class AddGrupo3
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class add
        {

            private addAddattr[] addattrField;

            private string classnameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("add-attr")]
            public addAddattr[] addattr
            {
                get
                {
                    return this.addattrField;
                }
                set
                {
                    this.addattrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("class-name")]
            public string classname
            {
                get
                {
                    return this.classnameField;
                }
                set
                {
                    this.classnameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class addAddattr
        {

            private addAddattrValue valueField;

            private string attrnameField;

            /// <remarks/>
            public addAddattrValue value
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

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("attr-name")]
            public string attrname
            {
                get
                {
                    return this.attrnameField;
                }
                set
                {
                    this.attrnameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class addAddattrValue
        {

            private string typeField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
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


    }
}
