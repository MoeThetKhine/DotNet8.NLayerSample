using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Setup.Blog;
using PresentationLayer.Resources;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : BaseController
    {
        private readonly BL_Blog _bL_Blog;

        public BlogController(BL_Blog bL_Blog)
        {
            _bL_Blog = bL_Blog;
        }
        #region HttpGet
        [HttpGet]
        public async Task<IActionResult> GetBlog()
        {
            try
            {
                return Content(await _bL_Blog.GetBlogs());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region HttpPost
        [HttpPost]
        public async Task<IActionResult> CreateBlog([FromBody] BlogRequestModel requestModel)
        {
            try
            {
                int result = await _bL_Blog.CreateBlog(requestModel);
                return result > 0 ? Created() : BadRequest(MessageResource.SaveFail);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region HttpPatch

        [HttpPatch("id")]
        public async Task<IActionResult> PatchBlog([FromBody] BlogRequestModel requestModel, int id)
        {
            try
            {
                int result = await _bL_Blog.PatchBlog(requestModel, id);
                return result > 0 ? Updated() : BadRequest(MessageResource.SaveFail);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region HttpDelete

        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            try
            {
                int result = await _bL_Blog.DeleteBlog(id);
                return result > 0 ? Deleted() : BadRequest(MessageResource.DeleteFail);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

    }
}
