using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Vision.Rio.UploadDesktopTool.Exceptions;
using Vision.Rio.UploadDesktopTool.Models;

namespace Vision.Rio.UploadDesktopTool
{

    class SettingsLoader
    {
        SettingsDto SettingsDto;

        public Environment SelectedEnvironment { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private static SettingsLoader instance;

        private SettingsLoader()
        {
            string SettingsFileName = Path.Combine(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData),
                @"NKF\RIO Desktop\Settings.xml");
            System.Console.WriteLine(SettingsFileName);
            XmlSerializer serializer = new XmlSerializer(typeof(SettingsDto));
            if (File.Exists(SettingsFileName))
            {
                XmlReader reader = XmlReader.Create(new StringReader(Properties.Resources.Settings));
                SettingsDto = (SettingsDto)serializer.Deserialize(reader);
            }
            else
            {
                FileStream fileStream = new FileStream(SettingsFileName, FileMode.Open);
                XmlReader reader = XmlReader.Create(fileStream);
                SettingsDto = (SettingsDto)serializer.Deserialize(reader);
                fileStream.Close();
            }
            CacheImportMetaData();
            CacheQueryFilters();
            CacheDefaults();
        }

        public static SettingsLoader Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingsLoader();
                }

                return instance;
            }
        }

        public List<Environment> GetEnvironmentList()
        {
            return SettingsDto.Environments.Environment;
        }

        private static Dictionary<string, ImportMetaData> worksheetNameToImportMetaData = 
            new Dictionary<string, ImportMetaData>();
        private static Dictionary<string, ImportMetaData> importMetaDataIdToImportMetaData =
            new Dictionary<string, ImportMetaData>();
        private static Dictionary<string, Dictionary<string, Mapping>> worksheetNameToExtColNameToMappingDict = 
            new Dictionary<string, Dictionary<string, Mapping>>();
        private static Dictionary<string, Dictionary<string, Relationship>> worksheetNameToAssociationIdToAssociationDictDict =
            new Dictionary<string, Dictionary<string, Relationship>>();
        private static Dictionary<string, Dictionary<string, Action>> worksheetNameToExtActionToActionDictDict =
            new Dictionary<string, Dictionary<string, Action>>();
        private static Dictionary<string, Actions> worksheetNameToActionMappingDict =
            new Dictionary<string, Actions>();
        private static Dictionary<string, bool> worksheetNameToSpecOverrideDict =
            new Dictionary<string, bool>();
        //private static Dictionary<string, List<Models.Rio.Upload.FieldQueryFilter>> queryFilterIdToFilterFieldListDict =
        //    new Dictionary<string, List<Models.Rio.Upload.FieldQueryFilter>>();
        private static Dictionary<string, string> fieldKeyToDefaultValueDict =
            new Dictionary<string, string>();

        public string GetObjectTypeDefaultValue(string moduleName, string objectTypeName, string dataSectionName, string FieldName)
        {
            string key = moduleName + objectTypeName + dataSectionName + FieldName;
            string defaultValue;
            fieldKeyToDefaultValueDict.TryGetValue(key, out defaultValue);
            return defaultValue;
        }

        public string GetModuleDefaultValue(string moduleName, string dataSectionName, string FieldName)
        {
            string key = moduleName + dataSectionName + FieldName;
            string defaultValue;
            fieldKeyToDefaultValueDict.TryGetValue(key, out defaultValue);
            return defaultValue;
        }

        private void CacheDefaults()
        {
            string baseKey;
            string fieldKey;

            foreach (DefaultFieldValues defaultFieldValues in SettingsDto.Defaults.FieldValues.DefaultFieldValues)
            {
                baseKey = defaultFieldValues.Module + defaultFieldValues.ObjectType;
                foreach (DefaultFieldValue defaultFieldValue in defaultFieldValues.DefaultFieldValue)
                {
                    fieldKey = baseKey + defaultFieldValue.DataSectionName + defaultFieldValue.FieldName;
                    fieldKeyToDefaultValueDict.Add(fieldKey, defaultFieldValue.FieldValue);
                }
            }
        }

        private List<Models.Rio.Upload.FieldQueryFilter> GenerateFieldQueryFilterList(List<FilterField> filterFieldList)
        {
            List<Models.Rio.Upload.FieldQueryFilter> result = new List<Models.Rio.Upload.FieldQueryFilter>();

            foreach (FilterField filterField in filterFieldList)
            {
                result.Add(new Models.Rio.Upload.FieldQueryFilter
                {
                    DataSectionName = filterField.DataSectionName,
                    FieldName = filterField.FieldName,
                    FieldValues = filterField.FieldValue,
                    DataType = filterField.DataType,
                    Operator = filterField.Operator
                });
            }
            return result;
        }

        private void CacheQueryFilters()
        {
            List<QueryFilter> queryFilterList = SettingsDto.QueryFilterList.QueryFilter;
            List<Models.Rio.Upload.FieldQueryFilter> fieldQueryFilters;
            foreach (QueryFilter queryFilter in queryFilterList)
            {
                fieldQueryFilters = GenerateFieldQueryFilterList(queryFilter.FilterFields.FilterField);
                queryFilterIdToFilterFieldListDict.Add(queryFilter.Id, fieldQueryFilters);
            }
        }

        public bool HasQueryFilterId(string queryFilterId)
        {
            return queryFilterIdToFilterFieldListDict.ContainsKey(queryFilterId);
        }

        public List<Models.Rio.Upload.FieldQueryFilter> GetQueryFilterList(string queryFilterId)
        {
            List<Models.Rio.Upload.FieldQueryFilter> result;
            if (!queryFilterIdToFilterFieldListDict.TryGetValue(queryFilterId, out result))
            {
                // TODO: Throw exception when not found.
            }
            return result;
        }

        /// <summary>
        /// Cache the meta data in the Settings.xml file for fast access.
        /// </summary>
        public void CacheImportMetaData()
        {
            List<ImportMetaData> importMetaDataList = SettingsDto.ImportMetaDataList.ImportMetaData;
            Dictionary<string, Mapping> extColNameToMappingDict;
            Dictionary<string, Action> extActionToActionDict;
            Dictionary<string, Relationship> associationIdToAssociationDict;

            foreach (ImportMetaData imd in importMetaDataList)
            {
                worksheetNameToImportMetaData.Add(imd.WorksheetName, imd);
                importMetaDataIdToImportMetaData.Add(imd.Id, imd);

                worksheetNameToSpecOverrideDict.Add(imd.WorksheetName, imd.DataMap.OverrideWithSpecId);

                extColNameToMappingDict = new Dictionary<string, Mapping>();
                foreach (Mapping m in imd.DataMap.Mapping)
                {
                    //TODO: Need to catch duplicate column names in mapping.
                    extColNameToMappingDict.Add(m.From, m);
                }

                worksheetNameToExtColNameToMappingDict.Add(imd.WorksheetName, extColNameToMappingDict);

                associationIdToAssociationDict = new Dictionary<string, Relationship>();
                foreach (Relationship a in imd.Relationships.Relationship)
                {
                    //TODO: Need to catch duplicate relationship names.
                    associationIdToAssociationDict.Add(a.Id, a);
                }
                worksheetNameToAssociationIdToAssociationDictDict.Add(imd.WorksheetName, associationIdToAssociationDict);

                extActionToActionDict = new Dictionary<string, Action>();
                foreach (Action a in imd.Actions.Action)
                {
                    extActionToActionDict.Add(a.From, a);
                }
                worksheetNameToExtActionToActionDictDict.Add(imd.WorksheetName, extActionToActionDict);

                worksheetNameToActionMappingDict.Add(imd.WorksheetName, imd.Actions);
            }
        }

        public bool IsSpecIdOverrideEnabled(string worksheetName)
        {
            if (!worksheetNameToSpecOverrideDict.TryGetValue(worksheetName, out bool result))
            {
                WorksheetNameNotFoundException.SetMessageItems(worksheetName);
            }
            return result;
        }

        public Actions GetActionMapping(string worksheetName)
        {
            if (!worksheetNameToActionMappingDict.TryGetValue(worksheetName, out Actions result))
            {
                WorksheetNameNotFoundException.SetMessageItems(worksheetName);
            }
            return result;
        }

        public Dictionary<string, Action> GetExtActionToActionDict(string worksheetName)
        {
            if (!worksheetNameToExtActionToActionDictDict.TryGetValue(worksheetName, out Dictionary<string, Action> result))
            {
                WorksheetNameNotFoundException.SetMessageItems(worksheetName);
            }
            return result;
        }

        public Dictionary<string, Mapping> GetExtColNameToMappingDict(string worksheetName)
        {
            if (!worksheetNameToExtColNameToMappingDict.TryGetValue(worksheetName, out Dictionary<string, Mapping> result))
            {
                WorksheetNameNotFoundException.SetMessageItems(worksheetName);
            }
            return result;
        }

        public Mapping GetMapping(string worksheetName, string colName)
        {
            Dictionary<string, Mapping> mappingDict = GetExtColNameToMappingDict(worksheetName);

            if (!mappingDict.TryGetValue(colName, out Mapping mapping))
            {
                MappingNotFoundException.SetMessageItems(worksheetName, colName);
            }

            return mapping;
        }

        public ImportMetaData GetImportMetaDataByWorksheetName(string worksheetName)
        {
            if (!worksheetNameToImportMetaData.TryGetValue(worksheetName, out ImportMetaData result))
            {
                WorksheetNameNotFoundException.SetMessageItems(worksheetName);
            }
            return result;
        }

        public ImportMetaData GetImportMetaDataById(string id)
        {
            importMetaDataIdToImportMetaData.TryGetValue(id, out ImportMetaData result);
            return result;
        }

    }
}
