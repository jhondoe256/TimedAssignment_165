using Microsoft.AspNetCore.Mvc;
using TimedAssignment.Services.LikeServices;

namespace TimedAssignment_165.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Likescontroller : ControllerBase
    {
        private readonly ILikeService _likeService;

        public Likescontroller(ILikeService likeService)
        {
            _likeService = likeService;
        }
    }
}