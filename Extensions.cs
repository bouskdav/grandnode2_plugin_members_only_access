using Grand.Domain.Localization;
using Grand.Web.Common.Models;
using System.Reflection;

namespace Widgets.MembersOnly
{
    public static class MyExtensions
    {
        //public static SlideModel ToModel(this PictureMembersOnly entity)
        //{
        //    return entity.MapTo<PictureMembersOnly, SlideModel>();
        //}

        //public static PictureMembersOnly ToEntity(this SlideModel model)
        //{
        //    return model.MapTo<SlideModel, PictureMembersOnly>();
        //}


        //public static SlideListModel ToListModel(this PictureMembersOnly entity)
        //{
        //    return entity.MapTo<PictureMembersOnly, SlideListModel>();
        //}

        public static List<TranslationEntity> ToLocalizedProperty<T>(this IList<T> list) where T : ILocalizedModelLocal
        {
            var local = new List<TranslationEntity>();
            foreach (var item in list)
            {
                Type[] interfaces = item.GetType().GetInterfaces();
                PropertyInfo[] props = item.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
                foreach (var prop in props)
                {
                    bool insert = true;

                    foreach (var i in interfaces)
                    {
                        if (i.HasProperty(prop.Name))
                        {
                            insert = false;
                        }
                    }

                    if (insert && prop.GetValue(item) != null)
                        local.Add(new TranslationEntity()
                        {
                            LanguageId = item.LanguageId,
                            LocaleKey = prop.Name,
                            LocaleValue = prop.GetValue(item).ToString(),
                        });
                }
            }
            return local;
        }
        public static bool HasProperty(this Type obj, string propertyName)
        {
            return obj.GetProperty(propertyName) != null;
        }
    }
}