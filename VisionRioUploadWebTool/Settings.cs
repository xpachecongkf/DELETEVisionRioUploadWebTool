using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VisionRioUploadWebTool
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class formSettings
    {

        private formSettingsEnvironment[] environmentsField;

        private formSettingsQueryFilterList queryFilterListField;

        private formSettingsDefaults defaultsField;

        private formSettingsImportMetaData[] importMetaDataListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("environment", IsNullable = false)]
        public formSettingsEnvironment[] environments
        {
            get
            {
                return this.environmentsField;
            }
            set
            {
                this.environmentsField = value;
            }
        }

        /// <remarks/>
        public formSettingsQueryFilterList queryFilterList
        {
            get
            {
                return this.queryFilterListField;
            }
            set
            {
                this.queryFilterListField = value;
            }
        }

        /// <remarks/>
        public formSettingsDefaults defaults
        {
            get
            {
                return this.defaultsField;
            }
            set
            {
                this.defaultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("importMetaData", IsNullable = false)]
        public formSettingsImportMetaData[] importMetaDataList
        {
            get
            {
                return this.importMetaDataListField;
            }
            set
            {
                this.importMetaDataListField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsEnvironment
    {

        private string nameField;

        private string urlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsQueryFilterList
    {

        private formSettingsQueryFilterListQueryFilter queryFilterField;

        /// <remarks/>
        public formSettingsQueryFilterListQueryFilter queryFilter
        {
            get
            {
                return this.queryFilterField;
            }
            set
            {
                this.queryFilterField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsQueryFilterListQueryFilter
    {

        private formSettingsQueryFilterListQueryFilterFilterFields filterFieldsField;

        private string idField;

        /// <remarks/>
        public formSettingsQueryFilterListQueryFilterFilterFields filterFields
        {
            get
            {
                return this.filterFieldsField;
            }
            set
            {
                this.filterFieldsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsQueryFilterListQueryFilterFilterFields
    {

        private formSettingsQueryFilterListQueryFilterFilterFieldsFilterField filterFieldField;

        /// <remarks/>
        public formSettingsQueryFilterListQueryFilterFilterFieldsFilterField filterField
        {
            get
            {
                return this.filterFieldField;
            }
            set
            {
                this.filterFieldField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsQueryFilterListQueryFilterFilterFieldsFilterField
    {

        private object dataSectionNameField;

        private string fieldNameField;

        private string fieldValueField;

        private string dataTypeField;

        private string operatorField;

        /// <remarks/>
        public object dataSectionName
        {
            get
            {
                return this.dataSectionNameField;
            }
            set
            {
                this.dataSectionNameField = value;
            }
        }

        /// <remarks/>
        public string fieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }

        /// <remarks/>
        public string fieldValue
        {
            get
            {
                return this.fieldValueField;
            }
            set
            {
                this.fieldValueField = value;
            }
        }

        /// <remarks/>
        public string dataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        public string @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsDefaults
    {

        private formSettingsDefaultsFieldValues fieldValuesField;

        /// <remarks/>
        public formSettingsDefaultsFieldValues fieldValues
        {
            get
            {
                return this.fieldValuesField;
            }
            set
            {
                this.fieldValuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsDefaultsFieldValues
    {

        private formSettingsDefaultsFieldValuesDefaultFieldValues defaultFieldValuesField;

        /// <remarks/>
        public formSettingsDefaultsFieldValuesDefaultFieldValues defaultFieldValues
        {
            get
            {
                return this.defaultFieldValuesField;
            }
            set
            {
                this.defaultFieldValuesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsDefaultsFieldValuesDefaultFieldValues
    {

        private formSettingsDefaultsFieldValuesDefaultFieldValuesDefaultFieldValue defaultFieldValueField;

        private string moduleField;

        private string objectTypeField;

        /// <remarks/>
        public formSettingsDefaultsFieldValuesDefaultFieldValuesDefaultFieldValue defaultFieldValue
        {
            get
            {
                return this.defaultFieldValueField;
            }
            set
            {
                this.defaultFieldValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string module
        {
            get
            {
                return this.moduleField;
            }
            set
            {
                this.moduleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string objectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsDefaultsFieldValuesDefaultFieldValuesDefaultFieldValue
    {

        private string dataSectionNameField;

        private string fieldNameField;

        private string fieldValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dataSectionName
        {
            get
            {
                return this.dataSectionNameField;
            }
            set
            {
                this.dataSectionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fieldValue
        {
            get
            {
                return this.fieldValueField;
            }
            set
            {
                this.fieldValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsImportMetaData
    {

        private string worksheetNameField;

        private string moduleField;

        private string objectTypeField;

        private string guiField;

        private string queryFilterIdField;

        private formSettingsImportMetaDataActions actionsField;

        private formSettingsImportMetaDataDataMap dataMapField;

        private formSettingsImportMetaDataRelationship[] relationshipsField;

        private string idField;

        /// <remarks/>
        public string worksheetName
        {
            get
            {
                return this.worksheetNameField;
            }
            set
            {
                this.worksheetNameField = value;
            }
        }

        /// <remarks/>
        public string module
        {
            get
            {
                return this.moduleField;
            }
            set
            {
                this.moduleField = value;
            }
        }

        /// <remarks/>
        public string objectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
            }
        }

        /// <remarks/>
        public string gui
        {
            get
            {
                return this.guiField;
            }
            set
            {
                this.guiField = value;
            }
        }

        /// <remarks/>
        public string queryFilterId
        {
            get
            {
                return this.queryFilterIdField;
            }
            set
            {
                this.queryFilterIdField = value;
            }
        }

        /// <remarks/>
        public formSettingsImportMetaDataActions actions
        {
            get
            {
                return this.actionsField;
            }
            set
            {
                this.actionsField = value;
            }
        }

        /// <remarks/>
        public formSettingsImportMetaDataDataMap dataMap
        {
            get
            {
                return this.dataMapField;
            }
            set
            {
                this.dataMapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("relationship", IsNullable = false)]
        public formSettingsImportMetaDataRelationship[] relationships
        {
            get
            {
                return this.relationshipsField;
            }
            set
            {
                this.relationshipsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsImportMetaDataActions
    {

        private formSettingsImportMetaDataActionsAction[] actionField;

        private string dataSectionNameField;

        private string fieldNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("action")]
        public formSettingsImportMetaDataActionsAction[] action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dataSectionName
        {
            get
            {
                return this.dataSectionNameField;
            }
            set
            {
                this.dataSectionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsImportMetaDataActionsAction
    {

        private string fromField;

        private string toField;

        private string labelField;

        private string to2Field;

        private string label2Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string to2
        {
            get
            {
                return this.to2Field;
            }
            set
            {
                this.to2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string label2
        {
            get
            {
                return this.label2Field;
            }
            set
            {
                this.label2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsImportMetaDataDataMap
    {

        private formSettingsImportMetaDataDataMapMapping[] mappingField;

        private bool overrideWithPopSpecIdField;

        private bool overrideWithPopSpecIdFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mapping")]
        public formSettingsImportMetaDataDataMapMapping[] mapping
        {
            get
            {
                return this.mappingField;
            }
            set
            {
                this.mappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool overrideWithPopSpecId
        {
            get
            {
                return this.overrideWithPopSpecIdField;
            }
            set
            {
                this.overrideWithPopSpecIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool overrideWithPopSpecIdSpecified
        {
            get
            {
                return this.overrideWithPopSpecIdFieldSpecified;
            }
            set
            {
                this.overrideWithPopSpecIdFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsImportMetaDataDataMapMapping
    {

        private string fromField;

        private bool requiredField;

        private bool keyField;

        private string sectionField;

        private string toField;

        private string locSectionField;

        private string locFieldField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string from
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string section
        {
            get
            {
                return this.sectionField;
            }
            set
            {
                this.sectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string to
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string locSection
        {
            get
            {
                return this.locSectionField;
            }
            set
            {
                this.locSectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string locField
        {
            get
            {
                return this.locFieldField;
            }
            set
            {
                this.locFieldField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class formSettingsImportMetaDataRelationship
    {

        private string srcMetaDataIdField;

        private string dstMetaDataIdField;

        private string forwardStringField;

        private string reverseStringField;

        private string smartSectionNameField;

        private string idField;

        private string typeField;

        private bool requiredField;

        /// <remarks/>
        public string srcMetaDataId
        {
            get
            {
                return this.srcMetaDataIdField;
            }
            set
            {
                this.srcMetaDataIdField = value;
            }
        }

        /// <remarks/>
        public string dstMetaDataId
        {
            get
            {
                return this.dstMetaDataIdField;
            }
            set
            {
                this.dstMetaDataIdField = value;
            }
        }

        /// <remarks/>
        public string forwardString
        {
            get
            {
                return this.forwardStringField;
            }
            set
            {
                this.forwardStringField = value;
            }
        }

        /// <remarks/>
        public string reverseString
        {
            get
            {
                return this.reverseStringField;
            }
            set
            {
                this.reverseStringField = value;
            }
        }

        /// <remarks/>
        public string smartSectionName
        {
            get
            {
                return this.smartSectionNameField;
            }
            set
            {
                this.smartSectionNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
            }
        }
    }




}