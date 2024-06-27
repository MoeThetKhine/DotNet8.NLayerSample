using DbService.Entity;
using Model.Setup.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class ChangeModel
    {
        #region BlogModel

        public static BlogModel Change(this Tbl_Blog dataModel)
        {
            return new BlogModel
            {
                BlogId = dataModel.BlogId,
                BlogTitle = dataModel.BlogTitle,
                BlogAuthor = dataModel.BlogAuthor,
                BlogContent = dataModel.BlogContent,
            };
        }

        #endregion

        #region Tbl_Blog

        public static Tbl_Blog Change(this BlogRequestModel requestModel)
        {
            return new Tbl_Blog
            {
                BlogTitle = requestModel.BlogTitle,
                BlogAuthor = requestModel.BlogAuthor,
                BlogContent = requestModel.BlogContent
            };
        }

        #endregion
    }
    
}
