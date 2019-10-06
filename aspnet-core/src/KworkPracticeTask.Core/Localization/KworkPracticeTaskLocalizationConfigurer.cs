using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace KworkPracticeTask.Localization
{
    public static class KworkPracticeTaskLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(KworkPracticeTaskConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(KworkPracticeTaskLocalizationConfigurer).GetAssembly(),
                        "KworkPracticeTask.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
