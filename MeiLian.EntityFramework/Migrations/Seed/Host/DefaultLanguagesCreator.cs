using System.Collections.Generic;
using System.Linq;
using Abp.Localization;
using MeiLian.EntityFramework;

namespace MeiLian.Migrations.Seed.Host
{
    public class DefaultLanguagesCreator
    {
        public static List<ApplicationLanguage> InitialLanguages { get; private set; }

        private readonly MeiLianDbContext _context;

        static DefaultLanguagesCreator()
        {
            InitialLanguages = new List<ApplicationLanguage>
            {
                new ApplicationLanguage(null, "en", "English", "famfamfam-flag-gb"),
                new ApplicationLanguage(null, "ar", "???????", "famfamfam-flag-sa"),
                new ApplicationLanguage(null, "de", "German", "famfamfam-flag-de"),
                new ApplicationLanguage(null, "it", "Italiano", "famfamfam-flag-it"),
                new ApplicationLanguage(null, "fr", "Fran?ais", "famfamfam-flag-fr"),
                new ApplicationLanguage(null, "pt-BR", "Portuguese", "famfamfam-flag-br"),
                new ApplicationLanguage(null, "tr", "T��rk?e", "famfamfam-flag-tr"),
                new ApplicationLanguage(null, "ru", "������ܧڧ�", "famfamfam-flag-ru"),
                new ApplicationLanguage(null, "zh-CN", "��������", "famfamfam-flag-cn"),
                new ApplicationLanguage(null, "es", "Espa?ol", "famfamfam-flag-es")
            };
        }

        public DefaultLanguagesCreator(MeiLianDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateLanguages();
        }

        private void CreateLanguages()
        {
            foreach (var language in InitialLanguages)
            {
                AddLanguageIfNotExists(language);
            }
        }

        private void AddLanguageIfNotExists(ApplicationLanguage language)
        {
            if (_context.Languages.Any(l => l.TenantId == language.TenantId && l.Name == language.Name))
            {
                return;
            }

            _context.Languages.Add(language);

            _context.SaveChanges();
        }
    }
}
