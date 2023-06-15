using Microsoft.AspNetCore.Mvc;
using TimedAssignment.Services.CommentServices;

namespace TimedAssignment_165.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Commentscontroller : ControllerBase
    {
        private readonly ICommentService _commentService;

        public Commentscontroller(ICommentService commentService)
        {
            _commentService = commentService;
        }
    }
}