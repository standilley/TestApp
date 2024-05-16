namespace TestApp.Entities
{
    public class ModifyUsuario
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class modify
        {

            private modifyAssociation associationField;

            private modifyModifyattr modifyattrField;

            private string classnameField;

            /// <remarks/>
            public modifyAssociation association
            {
                get
                {
                    return this.associationField;
                }
                set
                {
                    this.associationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("modify-attr")]
            public modifyModifyattr modifyattr
            {
                get
                {
                    return this.modifyattrField;
                }
                set
                {
                    this.modifyattrField = value;
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
        public partial class modifyAssociation
        {

            private string stateField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string state
            {
                get
                {
                    return this.stateField;
                }
                set
                {
                    this.stateField = value;
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

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class modifyModifyattr
        {

            private modifyModifyattrRemovevalue removevalueField;

            private modifyModifyattrAddvalue addvalueField;

            private string attrnameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("remove-value")]
            public modifyModifyattrRemovevalue removevalue
            {
                get
                {
                    return this.removevalueField;
                }
                set
                {
                    this.removevalueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("add-value")]
            public modifyModifyattrAddvalue addvalue
            {
                get
                {
                    return this.addvalueField;
                }
                set
                {
                    this.addvalueField = value;
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
        public partial class modifyModifyattrRemovevalue
        {

            private modifyModifyattrRemovevalueValue valueField;

            /// <remarks/>
            public modifyModifyattrRemovevalueValue value
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
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class modifyModifyattrRemovevalueValue
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

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class modifyModifyattrAddvalue
        {

            private modifyModifyattrAddvalueValue valueField;

            /// <remarks/>
            public modifyModifyattrAddvalueValue value
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
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class modifyModifyattrAddvalueValue
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
