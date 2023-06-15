using TimedAssignment.Models.Posts;

namespace TimedAssignment.Services.PostServices
{
    public class PostService : IPostService
    {
        //interact w/ the Database from here!!!
        
        public Task<bool> AddPost(PostCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PostDetail> GetPostById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PostListItem>> GetPosts()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdatePost(PostEdit model)
        {
            throw new NotImplementedException();
        }
    }
}