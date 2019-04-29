using System.Xml.Serialization;
using System.Collections.Generic;

namespace Vision.Rio.UploadDesktopTool.Models
{

    [XmlRoot(ElementName = "environment")]
    public class Environment
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "url")]
        public string Url { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [XmlRoot(ElementName = "environments")]
    public class Environments
    {
        [XmlElement(ElementName = "environment")]
        public List<Environment> Environment { get; set; }
    }

    [XmlRoot(ElementName = "filterField")]
    public class FilterField
    {
        [XmlElement(ElementName = "dataSectionName")]
        public string DataSectionName { get; set; }
        [XmlElement(ElementName = "fieldName")]
        public string FieldName { get; set; }
        [XmlElement(ElementName = "fieldValue")]
        public string FieldValue { get; set; }
        [XmlElement(ElementName = "dataType")]
        public string DataType { get; set; }
        [XmlElement(ElementName = "operator")]
        public string Operator { get; set; }
    }

    [XmlRoot(ElementName = "filterFields")]
    public class FilterFields
    {
        [XmlElement(ElementName = "filterField")]
        public List<FilterField> FilterField { get; set; }
    }

    [XmlRoot(ElementName = "queryFilter")]
    public class QueryFilter
    {
        [XmlElement(ElementName = "filterFields")]
        public FilterFields FilterFields { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "queryFilterList")]
    public class QueryFilterList
    {
        [XmlElement(ElementName = "queryFilter")]
        public List<QueryFilter> QueryFilter { get; set; }
    }

    [XmlRoot(ElementName = "defaultFieldValue")]
    public class DefaultFieldValue
    {
        [XmlAttribute(AttributeName = "dataSectionName")]
        public string DataSectionName { get; set; }
        [XmlAttribute(AttributeName = "fieldName")]
        public string FieldName { get; set; }
        [XmlAttribute(AttributeName = "fieldValue")]
        public string FieldValue { get; set; }
    }

    [XmlRoot(ElementName = "defaultFieldValues")]
    public class DefaultFieldValues
    {
        [XmlElement(ElementName = "defaultFieldValue")]
        public List<DefaultFieldValue> DefaultFieldValue { get; set; }
        [XmlAttribute(AttributeName = "module")]
        public string Module { get; set; }
        [XmlAttribute(AttributeName = "objectType")]
        public string ObjectType { get; set; }
    }

    [XmlRoot(ElementName = "fieldValues")]
    public class FieldValues
    {
        [XmlElement(ElementName = "defaultFieldValues")]
        public List<DefaultFieldValues> DefaultFieldValues { get; set; }
    }

    [XmlRoot(ElementName = "defaults")]
    public class Defaults
    {
        [XmlElement(ElementName = "fieldValues")]
        public FieldValues FieldValues { get; set; }
    }

    [XmlRoot(ElementName = "action")]
    public class Action
    {
        [XmlAttribute(AttributeName = "from")]
        public string From { get; set; }
        [XmlAttribute(AttributeName = "to")]
        public string To { get; set; }
        [XmlAttribute(AttributeName = "label")]
        public string Label { get; set; }
        [XmlAttribute(AttributeName = "to2")]
        public string To2 { get; set; }
        [XmlAttribute(AttributeName = "label2")]
        public string Label2 { get; set; }
    }

    [XmlRoot(ElementName = "mapping")]
    public class Mapping
    {
        [XmlAttribute(AttributeName = "from")]
        public string From { get; set; }
        [XmlAttribute(AttributeName = "locSection")]
        public string LocSection { get; set; }
        [XmlAttribute(AttributeName = "locField")]
        public string LocField { get; set; }
        [XmlAttribute(AttributeName = "defaultValue")]
        public string DefaultValue { get; set; }
        [XmlAttribute(AttributeName = "to")]
        public string To { get; set; }
        [XmlAttribute(AttributeName = "required")]
        public bool Required { get; set; }
        [XmlAttribute(AttributeName = "key")]
        public bool Key { get; set; }
        [XmlAttribute(AttributeName = "section")]
        public string Section { get; set; }
    }

    [XmlRoot(ElementName = "dataMap")]
    public class DataMap
    {
        [XmlElement(ElementName = "mapping")]
        public List<Mapping> Mapping { get; set; }
        [XmlAttribute(AttributeName = "overrideWithPopSpecId")]
        public bool OverrideWithSpecId { get; set; }
    }

    [XmlRoot(ElementName = "actions")]
    public class Actions
    {
        [XmlElement(ElementName = "action")]
        public List<Action> Action { get; set; }
        [XmlAttribute(AttributeName = "dataSectionName")]
        public string DataSectionName { get; set; }
        [XmlAttribute(AttributeName = "fieldName")]
        public string FieldName { get; set; }
    }
    [XmlRoot(ElementName = "importMetaData")]
    public class ImportMetaData
    {
        [XmlElement(ElementName = "worksheetName")]
        public string WorksheetName { get; set; }
        [XmlElement(ElementName = "module")]
        public string Module { get; set; }
        [XmlElement(ElementName = "objectType")]
        public string ObjectType { get; set; }
        [XmlElement(ElementName = "gui")]
        public string Gui { get; set; }
        [XmlElement(ElementName = "queryFilterId")]
        public string QueryFilterId { get; set; }
        [XmlElement(ElementName = "actions")]
        public Actions Actions { get; set; }
        [XmlElement(ElementName = "dataMap")]
        public DataMap DataMap { get; set; }
        [XmlElement(ElementName = "relationships")]
        public Relationships Relationships { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        public override string ToString()
        {
            return Id;
        }
    }

    [XmlRoot(ElementName = "relationship")]
    public class Relationship
    {
        [XmlElement(ElementName = "srcMetaDataId")]
        public string SrcMetaDataId { get; set; }
        [XmlElement(ElementName = "dstMetaDataId")]
        public string DstMetaDataId { get; set; }
        [XmlElement(ElementName = "forwardString")]
        public string ForwardString { get; set; }
        [XmlElement(ElementName = "reverseString")]
        public string ReverseString { get; set; }
        [XmlElement(ElementName = "smartSectionName")]
        public string SmartSectionName { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "required")]
        public bool Required { get; set; }
    }

    [XmlRoot(ElementName = "relationships")]
    public class Relationships
    {
        [XmlElement(ElementName = "relationship")]
        public List<Relationship> Relationship { get; set; }
    }

    [XmlRoot(ElementName = "importMetaDataList")]
    public class ImportMetaDataList
    {
        [XmlElement(ElementName = "importMetaData")]
        public List<ImportMetaData> ImportMetaData { get; set; }
    }

    [XmlRoot(ElementName = "formSettings")]
    public class SettingsDto
    {
        [XmlElement(ElementName = "environments")]
        public Environments Environments { get; set; }
        [XmlElement(ElementName = "importMetaDataList")]
        public ImportMetaDataList ImportMetaDataList { get; set; }
        [XmlElement(ElementName = "queryFilterList")]
        public QueryFilterList QueryFilterList { get; set; }
        [XmlElement(ElementName = "defaults")]
        public Defaults Defaults { get; set; }
    }
}
