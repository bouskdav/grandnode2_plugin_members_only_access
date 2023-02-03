using Grand.Business.Core.Interfaces.Common.Localization;
using Grand.Business.Core.Interfaces.Storage;
using Grand.Domain.Data;
using Grand.Infrastructure.Plugins;

namespace Widgets.MembersOnly
{
    /// <summary>
    /// PLugin
    /// </summary>
    public class MembersOnlyWidgetPlugin : BasePlugin, IPlugin
    {
        private readonly IPictureService _pictureService;
        private readonly ITranslationService _translationService;
        private readonly ILanguageService _languageService;
        private readonly IDatabaseContext _databaseContext;

        public MembersOnlyWidgetPlugin(IPictureService pictureService,
            ITranslationService translationService,
            ILanguageService languageService,
            IDatabaseContext databaseContext)
        {
            _pictureService = pictureService;
            _translationService = translationService;
            _languageService = languageService;
            _databaseContext = databaseContext;
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        public override async Task Install()
        {
            ////Create index
            //await _databaseContext.CreateIndex(_pictureMembersOnlyRepository, OrderBuilder<PictureMembersOnly>.Create().Ascending(x => x.MembersOnlyTypeId).Ascending(x => x.DisplayOrder), "MembersOnlyTypeId_DisplayOrder");

            ////pictures
            //var sampleImagesPath = CommonPath.MapPath("Plugins/Widgets.MembersOnly/Assets/membersOnly/sample-images/");
            //var byte1 = File.ReadAllBytes(sampleImagesPath + "banner1.png");
            //var byte2 = File.ReadAllBytes(sampleImagesPath + "banner2.png");

            //var pictureMembersOnly1 = new PictureMembersOnly()
            //{
            //    DisplayOrder = 0,
            //    Link = "",
            //    Name = "Sample membersOnly 1",
            //    FullWidth = true,
            //    Published = true,
            //    Description = "<div class=\"row slideRow justify-content-start\"><div class=\"col-lg-6 d-flex flex-column justify-content-center align-items-center\"><div><div class=\"animate-top animate__animated animate__backInDown\" >exclusive - modern - elegant</div><div class=\"animate-center-title animate__animated animate__backInLeft animate__delay-05s\">Smart watches</div><div class=\"animate-center-content animate__animated animate__backInLeft animate__delay-1s\">Go to collection and see more...</div><a href=\"/smartwatches\" class=\"animate-bottom btn btn-info animate__animated animate__backInUp animate__delay-15s\"> SHOP NOW </a></div></div></div>"
            //};

            //var pic1 = await _pictureService.InsertPicture(byte1, "image/png", "banner_1",reference: Grand.Domain.Common.Reference.Widget, objectId: pictureMembersOnly1.Id, validateBinary: false);
            //pictureMembersOnly1.PictureId = pic1.Id;
            //await _pictureMembersOnlyRepository.InsertAsync(pictureMembersOnly1);


            //var pictureMembersOnly2 = new PictureMembersOnly()
            //{
            //    DisplayOrder = 1,
            //    Link = "https://grandnode.com",
            //    Name = "Sample membersOnly 2",
            //    FullWidth = true,
            //    Published = true,
            //    Description = "<div class=\"row slideRow\"><div class=\"col-md-6 offset-md-6 col-12 offset-0 d-flex flex-column justify-content-center align-items-start px-0 pr-md-3\"><div class=\"slide-title text-dark animate__animated animate__fadeInRight animate__delay-05s\"><h2 class=\"mt-0\">Redmi Note 9</h2></div><div class=\"slide-content animate__animated animate__fadeInRight animate__delay-1s\"><p class=\"mb-0\"><span>Equipped with a high-performance octa-core processor <br/> with a maximum clock frequency of 2.0 GHz.</span></p></div><div class=\"slide-price animate__animated animate__fadeInRight animate__delay-15s d-inline-flex align-items-center justify-content-start w-100 mt-2\"><p class=\"actual\">$249.00</p><p class=\"old-price\">$399.00</p></div><div class=\"slide-button animate__animated animate__fadeInRight animate__delay-2s mt-3\"><a class=\"btn btn-outline-info\" href=\"/redmi-note-9\">BUY REDMI NOTE 9</a></div></div></div>",
            //};
            //var pic2 = await _pictureService.InsertPicture(byte2, "image/png", "banner_2", reference: Grand.Domain.Common.Reference.Widget, objectId: pictureMembersOnly2.Id, validateBinary: false);
            //pictureMembersOnly2.PictureId = pic2.Id;

            //await _pictureMembersOnlyRepository.InsertAsync(pictureMembersOnly2);

            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.DisplayOrder", "Display order");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.LimitedToGroups", "Limited to groups");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.LimitedToStores", "Limited to stores");


            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.FriendlyName", "Widget MembersOnly");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Added", "MembersOnly added");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Addnew", "Add new membersOnly");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.AvailableStores", "Available stores");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.AvailableStores.Hint", "Select stores for which the membersOnly will be shown.");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Backtolist", "Back to list");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Category", "Category");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Category.Hint", "Select the category where membersOnly should appear.");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Category.Required", "Category is required");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Description", "Description");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Description.Hint", "Enter the description of the membersOnly");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.DisplayOrder", "Display Order");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.DisplayOrder.Hint", "The membersOnly display order. 1 represents the first item in the list.");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Edit", "Edit membersOnly");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Edited", "MembersOnly edited");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Displayorder", "Display Order");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Link", "Link");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.ObjectType", "MembersOnly type");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Picture", "Picture");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Published", "Published");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Title", "Title");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.FullWidth", "Full width");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.FullWidth.hint", "Full width");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Info", "Info");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.LimitedToStores", "Limited to stores");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.LimitedToStores.Hint", "Determines whether the membersOnly is available only at certain stores.");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Link", "URL");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Link.Hint", "Enter URL. Leave empty if you don't want this picture to be clickable.");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Manage", "Manage Bootstrap MembersOnly");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Collection", "Collection");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Collection.Hint", "Select the collection where membersOnly should appear.");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Collection.Required", "Collection is required");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Brand", "Brand");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Brand.Hint", "Select the brand where membersOnly should appear.");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Brand.Required", "Brand is required");

            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Name", "Name");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Name.Hint", "Enter the name of the membersOnly");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Name.Required", "Name is required");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Picture", "Picture");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Picture.Required", "Picture is required");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Published", "Published");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Published.Hint", "Specify it should be visible or not");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.MembersOnlyType", "MembersOnly type");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.MembersOnlyType.Hint", "Choose the membersOnly type. Home page, category or collection page.");
            //await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Widgets.MembersOnly.Stores", "Stores");


            await base.Install();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override async Task Uninstall()
        {

            ////clear repository
            //await _pictureMembersOnlyRepository.DeleteAsync(_pictureMembersOnlyRepository.Table.ToList());

            ////locales
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Added");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Addnew");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.AvailableStores");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.AvailableStores.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Backtolist");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Category");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Category.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Category.Required");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Description");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Description.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.DisplayOrder");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.DisplayOrder.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Edit");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Edited");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Displayorder");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Link");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.ObjectType");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Picture");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Published");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Fields.Title");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Info");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.LimitedToStores");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.LimitedToStores.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Link");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Link.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Manage");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Collection");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Collection.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Collection.Required");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Brand");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Brand.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Brand.Required");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Name");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Name.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Name.Required");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Picture");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Picture.Required");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Published");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Published.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.MembersOnlyType");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.MembersOnlyType.Hint");
            //await this.DeletePluginTranslationResource(_translationService, _languageService, "Widgets.MembersOnly.Stores");

            await base.Uninstall();
        }

        public override string ConfigurationUrl()
        {
            return MembersOnlyWidgetDefaults.ConfigurationUrl;
        }
    }
}
