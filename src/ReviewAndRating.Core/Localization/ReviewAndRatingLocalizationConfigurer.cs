using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ReviewAndRating.Localization
{
    public static class ReviewAndRatingLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ReviewAndRatingConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ReviewAndRatingLocalizationConfigurer).GetAssembly(),
                        "ReviewAndRating.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
