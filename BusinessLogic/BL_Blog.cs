namespace BusinessLogic
{
    public class BL_Blog
    {
        private readonly DA_Blog _dA_blog;

        public BL_Blog(DA_Blog dA_blog)
        {
            _dA_blog = dA_blog;
        }

        #region GetBlogs
        public async Task<BlogListResponseModel> GetBlogs()
        {
            try
            {
                return await _dA_blog.GetBlogs();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region CreateBlog
        public async Task<int> CreateBlog(BlogRequestModel requestModel)
        {
            try
            {
                if (string.IsNullOrEmpty(requestModel.BlogTitle))
                    throw new Exception("Blog Title cannot be empty");
                if (string.IsNullOrEmpty(requestModel.BlogAuthor))
                    throw new Exception("Blog Author cannot be empty");
                if (string.IsNullOrEmpty(requestModel.BlogContent))
                    throw new Exception("Blog Content cannot be empty");

                return await _dA_blog.CreateBlog(requestModel);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region PatchBlog

        public async Task<int> PatchBlog(BlogRequestModel requestModel, int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception("Id is invalid");
                return await _dA_blog.PatchBlog(requestModel, id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region DeleteBlog

        public async Task<int> DeleteBlog(int id)
        {
            try
            {
                if (id == 0)
                    throw new Exception("Id is invaild");
                return await _dA_blog.DeleteBlog(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
