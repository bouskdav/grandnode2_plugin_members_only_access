namespace Widgets.MembersOnly.Services
{
    public partial class MembersOnlyService : IMembersOnlyService
    {
        #region Fields

        //private readonly IRepository<PictureMembersOnly> _reporistoryPictureMembersOnly;
        //private readonly IAclService _aclService;
        //private readonly IWorkContext _workContext;
        //private readonly ICacheBase _cacheBase;

        ///// <summary>
        ///// Key for membersOnlys
        ///// </summary>
        ///// <remarks>
        ///// {0} : Store id
        ///// {1} : MembersOnly type
        ///// {2} : Object entry / categoryId || collectionId
        ///// </remarks>
        //public const string SLIDERS_MODEL_KEY = "Grand.membersOnly-{0}-{1}-{2}";
        //public const string SLIDERS_PATTERN_KEY = "Grand.membersOnly";

        #endregion
        
        //public MembersOnlyService(IRepository<PictureMembersOnly> reporistoryPictureMembersOnly,
        //    IWorkContext workContext, IAclService aclService,
        //    ICacheBase cacheManager)
        //{
        //    _reporistoryPictureMembersOnly = reporistoryPictureMembersOnly;
        //    _workContext = workContext;
        //    _aclService = aclService;
        //    _cacheBase = cacheManager;
        //}
        ///// <summary>
        ///// Delete a membersOnly
        ///// </summary>
        ///// <param name="membersOnly">MembersOnly</param>
        //public virtual async Task DeleteMembersOnly(PictureMembersOnly slide)
        //{
        //    if (slide == null)
        //        throw new ArgumentNullException(nameof(slide));

        //    //clear cache
        //    await _cacheBase.RemoveByPrefix(SLIDERS_PATTERN_KEY);

        //    await _reporistoryPictureMembersOnly.DeleteAsync(slide);
        //}

        ///// <summary>
        ///// Gets all 
        ///// </summary>
        ///// <returns>Picture MembersOnlys</returns>
        //public virtual async Task<IList<PictureMembersOnly>> GetPictureMembersOnlys()
        //{
        //    return await Task.FromResult(_reporistoryPictureMembersOnly.Table.OrderBy(x => x.MembersOnlyTypeId).ThenBy(x => x.DisplayOrder).ToList());
        //}

        ///// <summary>
        ///// Gets by type 
        ///// </summary>
        ///// <returns>Picture MembersOnlys</returns>
        //public virtual async Task<IList<PictureMembersOnly>> GetPictureMembersOnlys(MembersOnlyType membersOnlyType, string objectEntry = "")
        //{
        //    string cacheKey = string.Format(SLIDERS_MODEL_KEY, _workContext.CurrentStore.Id, membersOnlyType.ToString(), objectEntry);
        //    return await _cacheBase.GetAsync(cacheKey, async () =>
        //    {
        //        var query = from s in _reporistoryPictureMembersOnly.Table
        //                    where s.MembersOnlyTypeId == membersOnlyType && s.Published
        //                    select s;

        //        if (!string.IsNullOrEmpty(objectEntry))
        //            query = query.Where(x => x.ObjectEntry == objectEntry);

        //        var items = query.ToList();
        //        return await Task.FromResult(items.Where(c => _aclService.Authorize(c, _workContext.CurrentStore.Id)).ToList());
        //    });
        //}


        ///// <summary>
        ///// Gets a tax rate
        ///// </summary>
        ///// <param name="slideId">Slide identifier</param>
        ///// <returns>Tax rate</returns>
        //public virtual Task<PictureMembersOnly> GetById(string slideId)
        //{
        //    return _reporistoryPictureMembersOnly.GetByIdAsync(slideId);
        //}

        ///// <summary>
        ///// Inserts a slide
        ///// </summary>
        ///// <param name="slide">Picture MembersOnly</param>
        //public virtual async Task InsertPictureMembersOnly(PictureMembersOnly slide)
        //{
        //    if (slide == null)
        //        throw new ArgumentNullException(nameof(slide));

        //    //clear cache
        //    await _cacheBase.RemoveByPrefix(SLIDERS_PATTERN_KEY);

        //    await _reporistoryPictureMembersOnly.InsertAsync(slide);
        //}

        ///// <summary>
        ///// Updates slide
        ///// </summary>
        ///// <param name="slide">Picture MembersOnly</param>
        //public virtual async Task UpdatePictureMembersOnly(PictureMembersOnly slide)
        //{
        //    if (slide == null)
        //        throw new ArgumentNullException(nameof(slide));

        //    //clear cache
        //    await _cacheBase.RemoveByPrefix(SLIDERS_PATTERN_KEY);

        //    await _reporistoryPictureMembersOnly.UpdateAsync(slide);
        //}

        ///// <summary>
        ///// Delete slide
        ///// </summary>
        ///// <param name="slide">Picture MembersOnly</param>
        //public virtual async Task DeletePictureMembersOnly(PictureMembersOnly slide)
        //{
        //    if (slide == null)
        //        throw new ArgumentNullException(nameof(slide));

        //    //clear cache
        //    await _cacheBase.RemoveByPrefix(SLIDERS_PATTERN_KEY);

        //    await _reporistoryPictureMembersOnly.DeleteAsync(slide);
        //}
    }
}
