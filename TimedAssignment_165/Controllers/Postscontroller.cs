using Microsoft.AspNetCore.Mvc;
using TimedAssignment.Services.PostServices;

namespace TimedAssignment_165.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Postscontroller : ControllerBase
    {
        private readonly IPostService _postService;

        public Postscontroller(IPostService postService)
        {
            _postService = postService;
        }
    }
}